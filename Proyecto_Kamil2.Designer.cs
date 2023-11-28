namespace Proyecto_Kamil
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeEmpladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeDirectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.directivoToolStripMenuItem,
            this.sucursalToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // directivoToolStripMenuItem
            // 
            this.directivoToolStripMenuItem.Name = "directivoToolStripMenuItem";
            this.directivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directivoToolStripMenuItem.Text = "Directivo";
            this.directivoToolStripMenuItem.Click += new System.EventHandler(this.directivoToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeEmpladosToolStripMenuItem,
            this.datosDeDirectivoToolStripMenuItem,
            this.modificarDatosDeSucursalToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // datosDeEmpladosToolStripMenuItem
            // 
            this.datosDeEmpladosToolStripMenuItem.Name = "datosDeEmpladosToolStripMenuItem";
            this.datosDeEmpladosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.datosDeEmpladosToolStripMenuItem.Text = "Datos de Emplados";
            this.datosDeEmpladosToolStripMenuItem.Click += new System.EventHandler(this.datosDeEmpladosToolStripMenuItem_Click);
            // 
            // datosDeDirectivoToolStripMenuItem
            // 
            this.datosDeDirectivoToolStripMenuItem.Name = "datosDeDirectivoToolStripMenuItem";
            this.datosDeDirectivoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.datosDeDirectivoToolStripMenuItem.Text = "Datos de Directivo";
            this.datosDeDirectivoToolStripMenuItem.Click += new System.EventHandler(this.datosDeDirectivoToolStripMenuItem_Click);
            // 
            // modificarDatosDeSucursalToolStripMenuItem
            // 
            this.modificarDatosDeSucursalToolStripMenuItem.Name = "modificarDatosDeSucursalToolStripMenuItem";
            this.modificarDatosDeSucursalToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.modificarDatosDeSucursalToolStripMenuItem.Text = "Modificar Datos de Sucursal";
            this.modificarDatosDeSucursalToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeSucursalToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleToolStripMenuItem,
            this.directivosToolStripMenuItem,
            this.tiendasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // empleToolStripMenuItem
            // 
            this.empleToolStripMenuItem.Name = "empleToolStripMenuItem";
            this.empleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.empleToolStripMenuItem.Text = "Consultar Empleados";
            this.empleToolStripMenuItem.Click += new System.EventHandler(this.empleToolStripMenuItem_Click);
            // 
            // directivosToolStripMenuItem
            // 
            this.directivosToolStripMenuItem.Name = "directivosToolStripMenuItem";
            this.directivosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.directivosToolStripMenuItem.Text = "Consultar Directivos";
            this.directivosToolStripMenuItem.Click += new System.EventHandler(this.directivosToolStripMenuItem_Click);
            // 
            // tiendasToolStripMenuItem
            // 
            this.tiendasToolStripMenuItem.Name = "tiendasToolStripMenuItem";
            this.tiendasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tiendasToolStripMenuItem.Text = "Buscar Tienda";
            this.tiendasToolStripMenuItem.Click += new System.EventHandler(this.tiendasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Consultas y Registros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeEmpladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeDirectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendasToolStripMenuItem;
    }
}

