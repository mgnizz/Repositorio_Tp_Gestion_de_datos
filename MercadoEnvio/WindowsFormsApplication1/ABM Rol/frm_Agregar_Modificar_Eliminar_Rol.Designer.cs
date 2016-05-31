namespace WindowsFormsApplication1.ABM_Rol
{
    partial class Form2
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
            this.lab_codigo_rol = new System.Windows.Forms.Label();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_Funcionalidades = new System.Windows.Forms.ComboBox();
            this.tex_Codigo_rol = new System.Windows.Forms.TextBox();
            this.but_Modificar = new System.Windows.Forms.Button();
            this.tex_Descripcion = new System.Windows.Forms.TextBox();
            this.but_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.gro_Datos_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.but_Agregar);
            this.gro_Datos_rol.Controls.Add(this.lab_codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.lab_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.label3);
            this.gro_Datos_rol.Controls.Add(this.com_Funcionalidades);
            this.gro_Datos_rol.Controls.Add(this.tex_Codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.but_Modificar);
            this.gro_Datos_rol.Controls.Add(this.tex_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.but_Eliminar);
            this.gro_Datos_rol.Controls.Add(this.dataGridView1);
            this.gro_Datos_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(287, 293);
            this.gro_Datos_rol.TabIndex = 24;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado de funcionalidades";
            // 
            // com_Funcionalidades
            // 
            this.com_Funcionalidades.FormattingEnabled = true;
            this.com_Funcionalidades.Location = new System.Drawing.Point(23, 214);
            this.com_Funcionalidades.Name = "com_Funcionalidades";
            this.com_Funcionalidades.Size = new System.Drawing.Size(121, 21);
            this.com_Funcionalidades.TabIndex = 20;
            // 
            // tex_Codigo_rol
            // 
            this.tex_Codigo_rol.Location = new System.Drawing.Point(90, 27);
            this.tex_Codigo_rol.Name = "tex_Codigo_rol";
            this.tex_Codigo_rol.Size = new System.Drawing.Size(40, 20);
            this.tex_Codigo_rol.TabIndex = 7;
            // 
            // but_Modificar
            // 
            this.but_Modificar.Location = new System.Drawing.Point(115, 250);
            this.but_Modificar.Name = "but_Modificar";
            this.but_Modificar.Size = new System.Drawing.Size(75, 23);
            this.but_Modificar.TabIndex = 19;
            this.but_Modificar.Text = "Modificar";
            this.but_Modificar.UseVisualStyleBackColor = true;
            // 
            // tex_Descripcion
            // 
            this.tex_Descripcion.Location = new System.Drawing.Point(90, 61);
            this.tex_Descripcion.Name = "tex_Descripcion";
            this.tex_Descripcion.Size = new System.Drawing.Size(160, 20);
            this.tex_Descripcion.TabIndex = 8;
            // 
            // but_Eliminar
            // 
            this.but_Eliminar.Location = new System.Drawing.Point(196, 250);
            this.but_Eliminar.Name = "but_Eliminar";
            this.but_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.but_Eliminar.TabIndex = 18;
            this.but_Eliminar.Text = "Eliminar";
            this.but_Eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 70);
            this.dataGridView1.TabIndex = 16;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(34, 250);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(75, 23);
            this.but_Agregar.TabIndex = 21;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 327);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "Form2";
            this.Text = "Agregar/Modificar/Eliminar";
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Label lab_codigo_rol;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_Funcionalidades;
        private System.Windows.Forms.TextBox tex_Codigo_rol;
        private System.Windows.Forms.Button but_Modificar;
        private System.Windows.Forms.TextBox tex_Descripcion;
        private System.Windows.Forms.Button but_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Agregar;
    }
}