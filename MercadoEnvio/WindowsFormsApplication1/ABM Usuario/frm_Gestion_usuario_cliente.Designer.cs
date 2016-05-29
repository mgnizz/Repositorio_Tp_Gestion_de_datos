namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class frm_Gestion_usuario_cliente
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
            this.but_Buscar = new System.Windows.Forms.Button();
            this.dgv_Listado_usuario = new System.Windows.Forms.DataGridView();
            this.gro_Elegir_usuario = new System.Windows.Forms.GroupBox();
            this.but_Nuevo_cliente = new System.Windows.Forms.Button();
            this.che_Nombre = new System.Windows.Forms.CheckBox();
            this.che_Apellido = new System.Windows.Forms.CheckBox();
            this.che_DNI = new System.Windows.Forms.CheckBox();
            this.che_Mail = new System.Windows.Forms.CheckBox();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.tex_Apellido = new System.Windows.Forms.TextBox();
            this.tex_DNI = new System.Windows.Forms.TextBox();
            this.tex_Mail = new System.Windows.Forms.TextBox();
            this.gro_Filtro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_usuario)).BeginInit();
            this.gro_Elegir_usuario.SuspendLayout();
            this.gro_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Buscar
            // 
            this.but_Buscar.Location = new System.Drawing.Point(236, 323);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(65, 23);
            this.but_Buscar.TabIndex = 15;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_Listado_usuario
            // 
            this.dgv_Listado_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado_usuario.Location = new System.Drawing.Point(19, 210);
            this.dgv_Listado_usuario.Name = "dgv_Listado_usuario";
            this.dgv_Listado_usuario.Size = new System.Drawing.Size(282, 107);
            this.dgv_Listado_usuario.TabIndex = 22;
            // 
            // gro_Elegir_usuario
            // 
            this.gro_Elegir_usuario.Controls.Add(this.gro_Filtro);
            this.gro_Elegir_usuario.Controls.Add(this.but_Buscar);
            this.gro_Elegir_usuario.Controls.Add(this.dgv_Listado_usuario);
            this.gro_Elegir_usuario.Location = new System.Drawing.Point(12, 12);
            this.gro_Elegir_usuario.Name = "gro_Elegir_usuario";
            this.gro_Elegir_usuario.Size = new System.Drawing.Size(337, 359);
            this.gro_Elegir_usuario.TabIndex = 26;
            this.gro_Elegir_usuario.TabStop = false;
            this.gro_Elegir_usuario.Text = "Elegir usuario";
            // 
            // but_Nuevo_cliente
            // 
            this.but_Nuevo_cliente.Location = new System.Drawing.Point(118, 391);
            this.but_Nuevo_cliente.Name = "but_Nuevo_cliente";
            this.but_Nuevo_cliente.Size = new System.Drawing.Size(127, 23);
            this.but_Nuevo_cliente.TabIndex = 27;
            this.but_Nuevo_cliente.Text = "Nuevo cliente";
            this.but_Nuevo_cliente.UseVisualStyleBackColor = true;
            // 
            // che_Nombre
            // 
            this.che_Nombre.AutoSize = true;
            this.che_Nombre.Location = new System.Drawing.Point(28, 28);
            this.che_Nombre.Name = "che_Nombre";
            this.che_Nombre.Size = new System.Drawing.Size(63, 17);
            this.che_Nombre.TabIndex = 27;
            this.che_Nombre.Text = "Nombre";
            this.che_Nombre.UseVisualStyleBackColor = true;
            // 
            // che_Apellido
            // 
            this.che_Apellido.AutoSize = true;
            this.che_Apellido.Location = new System.Drawing.Point(28, 67);
            this.che_Apellido.Name = "che_Apellido";
            this.che_Apellido.Size = new System.Drawing.Size(63, 17);
            this.che_Apellido.TabIndex = 28;
            this.che_Apellido.Text = "Apellido";
            this.che_Apellido.UseVisualStyleBackColor = true;
            // 
            // che_DNI
            // 
            this.che_DNI.AutoSize = true;
            this.che_DNI.Location = new System.Drawing.Point(28, 103);
            this.che_DNI.Name = "che_DNI";
            this.che_DNI.Size = new System.Drawing.Size(45, 17);
            this.che_DNI.TabIndex = 29;
            this.che_DNI.Text = "DNI";
            this.che_DNI.UseVisualStyleBackColor = true;
            // 
            // che_Mail
            // 
            this.che_Mail.AutoSize = true;
            this.che_Mail.Location = new System.Drawing.Point(28, 131);
            this.che_Mail.Name = "che_Mail";
            this.che_Mail.Size = new System.Drawing.Size(45, 17);
            this.che_Mail.TabIndex = 30;
            this.che_Mail.Text = "Mail";
            this.che_Mail.UseVisualStyleBackColor = true;
            this.che_Mail.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(87, 28);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(145, 20);
            this.tex_Nombre.TabIndex = 31;
            // 
            // tex_Apellido
            // 
            this.tex_Apellido.Location = new System.Drawing.Point(87, 64);
            this.tex_Apellido.Name = "tex_Apellido";
            this.tex_Apellido.Size = new System.Drawing.Size(145, 20);
            this.tex_Apellido.TabIndex = 32;
            // 
            // tex_DNI
            // 
            this.tex_DNI.Location = new System.Drawing.Point(87, 100);
            this.tex_DNI.Name = "tex_DNI";
            this.tex_DNI.Size = new System.Drawing.Size(85, 20);
            this.tex_DNI.TabIndex = 33;
            // 
            // tex_Mail
            // 
            this.tex_Mail.Location = new System.Drawing.Point(87, 128);
            this.tex_Mail.Name = "tex_Mail";
            this.tex_Mail.Size = new System.Drawing.Size(201, 20);
            this.tex_Mail.TabIndex = 34;
            // 
            // gro_Filtro
            // 
            this.gro_Filtro.Controls.Add(this.tex_Mail);
            this.gro_Filtro.Controls.Add(this.che_Nombre);
            this.gro_Filtro.Controls.Add(this.tex_DNI);
            this.gro_Filtro.Controls.Add(this.che_Apellido);
            this.gro_Filtro.Controls.Add(this.tex_Apellido);
            this.gro_Filtro.Controls.Add(this.che_DNI);
            this.gro_Filtro.Controls.Add(this.tex_Nombre);
            this.gro_Filtro.Controls.Add(this.che_Mail);
            this.gro_Filtro.Location = new System.Drawing.Point(19, 19);
            this.gro_Filtro.Name = "gro_Filtro";
            this.gro_Filtro.Size = new System.Drawing.Size(294, 169);
            this.gro_Filtro.TabIndex = 28;
            this.gro_Filtro.TabStop = false;
            this.gro_Filtro.Text = "Filtrar por";
            // 
            // frm_Gestion_usuario_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 433);
            this.Controls.Add(this.but_Nuevo_cliente);
            this.Controls.Add(this.gro_Elegir_usuario);
            this.Name = "frm_Gestion_usuario_cliente";
            this.Text = "Gestion usuario cliente";
            this.Load += new System.EventHandler(this.frm_Gestion_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_usuario)).EndInit();
            this.gro_Elegir_usuario.ResumeLayout(false);
            this.gro_Filtro.ResumeLayout(false);
            this.gro_Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.DataGridView dgv_Listado_usuario;
        private System.Windows.Forms.GroupBox gro_Elegir_usuario;
        private System.Windows.Forms.Button but_Nuevo_cliente;
        private System.Windows.Forms.GroupBox gro_Filtro;
        private System.Windows.Forms.TextBox tex_Mail;
        private System.Windows.Forms.CheckBox che_Nombre;
        private System.Windows.Forms.TextBox tex_DNI;
        private System.Windows.Forms.CheckBox che_Apellido;
        private System.Windows.Forms.TextBox tex_Apellido;
        private System.Windows.Forms.CheckBox che_DNI;
        private System.Windows.Forms.TextBox tex_Nombre;
        private System.Windows.Forms.CheckBox che_Mail;

    }
}