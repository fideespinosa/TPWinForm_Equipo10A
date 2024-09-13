﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using static System.Net.Mime.MediaTypeNames;


namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(@"
                                        SELECT 
                                        A.Codigo, 
                                        A.Nombre, 
                                        A.Descripcion, 
                                        M.Descripcion AS MarcaDescripcion, 
                                        C.Descripcion AS CategoriaDescripcion, 
                                        A.Precio, 
                                        I.ImagenUrl as Imagen
                                        FROM ARTICULOS AS A 
                                        LEFT JOIN Marcas AS M ON A.IdMarca = M.Id 
                                        LEFT JOIN Categorias AS C ON A.IdCategoria = C.Id
                                        LEFT JOIN IMAGENES AS I ON I.IdArticulo = A.Id"
                                        );

                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.MarcasCls = new Marcas();
                    aux.MarcasCls.Marca = (string)datos.lector["MarcaDescripcion"];
                    aux.CategoriasCls = new Categorias();
                    //validacion de null categoria
                    if (!(datos.lector["CategoriaDescripcion"] is DBNull))
                        aux.CategoriasCls.Descripcion = (string)datos.lector["CategoriaDescripcion"];


                    aux.Precio = (decimal)datos.lector["Precio"];

                    aux.Imagen = new ArtImg();
                    if (!(datos.lector["Imagen"] is DBNull))
                        aux.Imagen.ImagenUrl = datos.lector["Imagen"].ToString();

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

      public void AgregarImagen(ArtImg Imagen, Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");

                datos.setearParametro("@IdArticulo", ConsultarId(art));
                datos.setearParametro("@Url", Imagen.ImagenUrl);
                datos.EjecutarAccion();
                    
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int ConsultarId(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            int id=0;

            datos.SetearConsulta("select Id from ARTICULOS where Codigo = '" + art.Codigo + "'");

            datos.EjecutarLectura();

            while (datos.lector.Read())
            {
                id = (int)datos.lector["Id"];

            }
            return id;



        }
        public void Agregar(Articulo art, ArtImg img)
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datosImagen = new AccesoDatos();
            try
            {

                datos.SetearConsulta(
                                     "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, idMarca, idCategoria) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria); "
                                     );
                // Tabla articulos
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@IdMarca", art.MarcasCls.Id);
                datos.setearParametro("@IdCategoria", art.CategoriasCls.Id);
                //Tabla imagenes, insertados en 2do insert
                datos.EjecutarAccion();

                AgregarImagen(img, art);


            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
