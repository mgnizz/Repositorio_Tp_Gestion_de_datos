namespace WindowsFormsApplication1.ABM_Rol
{
    partial class Form1
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
            this.gro_Datos_rol = new System.Windows.Forms.GroupBox();
            this.lab_Funcionalidad = new System.Windows.Forms.Label();
            this.lab_codigo_rol = new System.Windows.Forms.Label();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.com_Funcionalidades = new System.Windows.Forms.ComboBox();
            this.tex_Codigo_rol = new System.Windows.Forms.TextBox();
            this.tex_Descripcion = new System.Windows.Forms.TextBox();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.gro_Datos_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.lab_Funcionalidad);
            this.gro_Datos_rol.Controls.Add(this.lab_codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.lab_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.com_Funcionalidades);
            this.gro_Datos_rol.Controls.Add(this.tex_Codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.tex_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.but_Agregar);
            this.gro_Datos_rol.Location = new System.Drawing.Point(3, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(287, 195);
            this.gro_Datos_rol.TabIndex = 24;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
            // 
            // lab_Funcionalidad
            // 
            this.lab_Funcionalidad.AutoSize = true;
            this.lab_Funcionalidad.Location = new System.Drawing.Point(20, 102);
            this.lab_Funcionalidad.Name = "lab_Funcionalidad";
            this.lab_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.lab_Funcionalidad.TabIndex = 21;
            this.lab_Funcionalidad.Text = "Funcionalidad";
            // 
            // lab_codigo_rol
            // 
            this.lab_codigo_rol.AutoSize = true;
            this.lab_codigo_rol.Location = new System.Drawing.Point(20, 28);
            this.lab_codigo_rol.Name = "lab_codigo_rol";
            this.lab_codigo_rol.Size = new System.Drawing.Size(54, 13);
            this.lab_codigo_rol.TabIndex = 0;
            this.lab_codigo_rol.Text = "Codigo rol";
            // 
            // lab_Descripcion
            // 
            this.lab_Descripcion.AutoSize = true;
            this.lab_Descripcion.Location = new System.Drawing.Point(23, 61);
            this.lab_Descripcion.Name = "lab_Descripcion";
            this.lab_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lab_Descripcion.TabIndex = 1;
            this.lab_Descripcion.Text = "Descripcion";
            // 
            // com_Funcionalidades
            // 
            this.com_Funcionalidades.FormattingEnabled = true;
            this.com_Funcionalidades.Location = new System.Drawing.Point(104, 99);
            this.com_Funcionalidades.Name = "com_Funcionalidades";
            this.com_Funcionalidades.Size = new System.Drawing.Size(121, 21);
            this.com_Funcionalidades.TabIndex = 20;
            // 
            // tex_Codigo_rol
            // 
            this.tex_Codigo_rol.Location = new System.Drawing.Point(104, 25);
            this.tex_Codigo_rol.Name = "tex_Codigo_rol";
            this.tex_Codigo_rol.Size = new System.Drawing.Size(40, 20);
            this.tex_Codigo_rol.TabIndex = 7;
            // 
            // tex_Descripcion
            // 
            this.tex_Descripcion.Location = new System.Drawing.Point(104, 61);
            this.tex_Descripcion.Name = "tex_Descripcion";
            this.tex_Descripcion.Size = new System.Drawing.Size(160, 20);
            this.tex_Descripcion.TabIndex = 8;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(161, 154);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(103, 23);
            this.but_Agregar.TabIndex = 18;
            this.but_Agregar.Text = "Agregar nuevo";
            this.but_Agregar.UseVisualStyleBackColor = true;
            this.but_Agregar.Click += new System.EventHandler(this.but_Eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 245);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "Form1";
            this.Text = "Agregar nuevo  rol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Label lab_codigo_rol;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.ComboBox com_Funcionalidades;
        private System.Windows.Forms.TextBox tex_Codigo_rol;
        private System.Windows.Forms.TextBox tex_Descripcion;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.Label lab_Funcionalidad;
    }
}