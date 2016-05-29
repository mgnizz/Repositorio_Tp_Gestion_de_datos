namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class frm_Gestion_usuario_empresa
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
            this.but_Nuevo_empresa = new System.Windows.Forms.Button();
            this.gro_Elegir_usuario = new System.Windows.Forms.GroupBox();
            this.gro_Filtro = new System.Windows.Forms.GroupBox();
            this.tex_Mail = new System.Windows.Forms.TextBox();
            this.che_Razon_social = new System.Windows.Forms.CheckBox();
            this.che_CUIT = new System.Windows.Forms.CheckBox();
            this.tex_Apellido = new System.Windows.Forms.TextBox();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.che_Mail = new System.Windows.Forms.CheckBox();
            this.but_Buscar = new System.Windows.Forms.Button();
            this.dgv_Listado_usuario = new System.Windows.Forms.DataGridView();
            this.gro_Elegir_usuario.SuspendLayout();
            this.gro_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Nuevo_empresa
            // 
            this.but_Nuevo_empresa.Location = new System.Drawing.Point(130, 339);
            this.but_Nuevo_empresa.Name = "but_Nuevo_empresa";
            this.but_Nuevo_empresa.Size = new System.Drawing.Size(127, 23);
            this.but_Nuevo_empresa.TabIndex = 29;
            this.but_Nuevo_empresa.Text = "Nuevo empresa";
            this.but_Nuevo_empresa.UseVisualStyleBackColor = true;
            // 
            // gro_Elegir_usuario
            // 
            this.gro_Elegir_usuario.Controls.Add(this.gro_Filtro);
            this.gro_Elegir_usuario.Controls.Add(this.but_Buscar);
            this.gro_Elegir_usuario.Controls.Add(this.dgv_Listado_usuario);
            this.gro_Elegir_usuario.Location = new System.Drawing.Point(12, 12);
            this.gro_Elegir_usuario.Name = "gro_Elegir_usuario";
            this.gro_Elegir_usuario.Size = new System.Drawing.Size(377, 321);
            this.gro_Elegir_usuario.TabIndex = 28;
            this.gro_Elegir_usuario.TabStop = false;
            this.gro_Elegir_usuario.Text = "Elegir usuario";
            // 
            // gro_Filtro
            // 
            this.gro_Filtro.Controls.Add(this.tex_Mail);
            this.gro_Filtro.Controls.Add(this.che_Razon_social);
            this.gro_Filtro.Controls.Add(this.che_CUIT);
            this.gro_Filtro.Controls.Add(this.tex_Apellido);
            this.gro_Filtro.Controls.Add(this.tex_Nombre);
            this.gro_Filtro.Controls.Add(this.che_Mail);
            this.gro_Filtro.Location = new System.Drawing.Point(19, 19);
            this.gro_Filtro.Name = "gro_Filtro";
            this.gro_Filtro.Size = new System.Drawing.Size(334, 137);
            this.gro_Filtro.TabIndex = 28;
            this.gro_Filtro.TabStop = false;
            this.gro_Filtro.Text = "Filtrar por";
            // 
            // tex_Mail
            // 
            this.tex_Mail.Location = new System.Drawing.Point(121, 93);
            this.tex_Mail.Name = "tex_Mail";
            this.tex_Mail.Size = new System.Drawing.Size(193, 20);
            this.tex_Mail.TabIndex = 34;
            // 
            // che_Razon_social
            // 
            this.che_Razon_social.AutoSize = true;
            this.che_Razon_social.Location = new System.Drawing.Point(28, 28);
            this.che_Razon_social.Name = "che_Razon_social";
            this.che_Razon_social.Size = new System.Drawing.Size(87, 17);
            this.che_Razon_social.TabIndex = 27;
            this.che_Razon_social.Text = "Razon social";
            this.che_Razon_social.UseVisualStyleBackColor = true;
            this.che_Razon_social.CheckedChanged += new System.EventHandler(this.che_Nombre_CheckedChanged);
            // 
            // che_CUIT
            // 
            this.che_CUIT.AutoSize = true;
            this.che_CUIT.Location = new System.Drawing.Point(28, 67);
            this.che_CUIT.Name = "che_CUIT";
            this.che_CUIT.Size = new System.Drawing.Size(51, 17);
            this.che_CUIT.TabIndex = 28;
            this.che_CUIT.Text = "CUIT";
            this.che_CUIT.UseVisualStyleBackColor = true;
            // 
            // tex_Apellido
            // 
            this.tex_Apellido.Location = new System.Drawing.Point(121, 65);
            this.tex_Apellido.Name = "tex_Apellido";
            this.tex_Apellido.Size = new System.Drawing.Size(127, 20);
            this.tex_Apellido.TabIndex = 32;
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(121, 28);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(161, 20);
            this.tex_Nombre.TabIndex = 31;
            // 
            // che_Mail
            // 
            this.che_Mail.AutoSize = true;
            this.che_Mail.Location = new System.Drawing.Point(28, 93);
            this.che_Mail.Name = "che_Mail";
            this.che_Mail.Size = new System.Drawing.Size(45, 17);
            this.che_Mail.TabIndex = 30;
            this.che_Mail.Text = "Mail";
            this.che_Mail.UseVisualStyleBackColor = true;
            // 
            // but_Buscar
            // 
            this.but_Buscar.Location = new System.Drawing.Point(236, 284);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(65, 23);
            this.but_Buscar.TabIndex = 15;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_Listado_usuario
            // 
            this.dgv_Listado_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado_usuario.Location = new System.Drawing.Point(19, 171);
            this.dgv_Listado_usuario.Name = "dgv_Listado_usuario";
            this.dgv_Listado_usuario.Size = new System.Drawing.Size(282, 107);
            this.dgv_Listado_usuario.TabIndex = 22;
            this.dgv_Listado_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Listado_usuario_CellContentClick);
            // 
            // frm_Gestion_usuario_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 385);
            this.Controls.Add(this.but_Nuevo_empresa);
            this.Controls.Add(this.gro_Elegir_usuario);
            this.Name = "frm_Gestion_usuario_empresa";
            this.Text = "Gestion usuario empresa";
            this.gro_Elegir_usuario.ResumeLayout(false);
            this.gro_Filtro.ResumeLayout(false);
            this.gro_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Nuevo_empresa;
        private System.Windows.Forms.GroupBox gro_Elegir_usuario;
        private System.Windows.Forms.GroupBox gro_Filtro;
        private System.Windows.Forms.TextBox tex_Mail;
        private System.Windows.Forms.CheckBox che_Razon_social;
        private System.Windows.Forms.CheckBox che_CUIT;
        private System.Windows.Forms.TextBox tex_Apellido;
        private System.Windows.Forms.TextBox tex_Nombre;
        private System.Windows.Forms.CheckBox che_Mail;
        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.DataGridView dgv_Listado_usuario;
    }
}