﻿namespace TPWinForm_Equipo10A
{
    partial class frmMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListarMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarLogica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarFisica = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListarMarcas
            // 
            this.dgvListarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMarcas.Location = new System.Drawing.Point(13, 80);
            this.dgvListarMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListarMarcas.MinimumSize = new System.Drawing.Size(281, 341);
            this.dgvListarMarcas.Name = "dgvListarMarcas";
            this.dgvListarMarcas.RowHeadersWidth = 51;
            this.dgvListarMarcas.Size = new System.Drawing.Size(281, 341);
            this.dgvListarMarcas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(13, 428);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(116, 428);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 38);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(214, 428);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 38);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 38);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Marcas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmAccion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalir});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(73, 24);
            this.tsmArchivo.Text = "Archivo";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmSalir.Size = new System.Drawing.Size(167, 26);
            this.tsmSalir.Text = "Salir";
            // 
            // tsmAccion
            // 
            this.tsmAccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregar,
            this.tsmModificar,
            this.tsmEliminar});
            this.tsmAccion.Name = "tsmAccion";
            this.tsmAccion.Size = new System.Drawing.Size(68, 24);
            this.tsmAccion.Text = "Accion";
            // 
            // tsmAgregar
            // 
            this.tsmAgregar.Name = "tsmAgregar";
            this.tsmAgregar.Size = new System.Drawing.Size(224, 26);
            this.tsmAgregar.Text = "Agregar";
            this.tsmAgregar.Click += new System.EventHandler(this.tsmAgregar_Click);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(224, 26);
            this.tsmModificar.Text = "Modificar";
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarLogica,
            this.tsmEliminarFisica});
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(224, 26);
            this.tsmEliminar.Text = "Eliminar";
            // 
            // tsmEliminarLogica
            // 
            this.tsmEliminarLogica.Name = "tsmEliminarLogica";
            this.tsmEliminarLogica.Size = new System.Drawing.Size(136, 26);
            this.tsmEliminarLogica.Text = "Logica";
            // 
            // tsmEliminarFisica
            // 
            this.tsmEliminarFisica.Name = "tsmEliminarFisica";
            this.tsmEliminarFisica.Size = new System.Drawing.Size(136, 26);
            this.tsmEliminarFisica.Text = "Fisica";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(300, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvListarMarcas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 709);
            this.MinimizeBox = false;
            this.Name = "frmMarcas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListarMarcas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmAccion;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarLogica;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarFisica;
    }
}