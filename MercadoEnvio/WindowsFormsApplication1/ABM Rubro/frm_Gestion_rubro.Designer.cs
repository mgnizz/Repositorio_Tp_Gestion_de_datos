namespace WindowsFormsApplication1.ABM_Rubro
{
    partial class frm_Gestion_rubro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tex_Descripcion_larga = new System.Windows.Forms.TextBox();
            this.tex_Descripcion_corta = new System.Windows.Forms.TextBox();
            this.tex_Codigo_rubro = new System.Windows.Forms.TextBox();
            this.but_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Eliminar = new System.Windows.Forms.Button();
            this.but_Modificar = new System.Windows.Forms.Button();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tex_Descripcion_larga);
            this.groupBox1.Controls.Add(this.tex_Descripcion_corta);
            this.groupBox1.Controls.Add(this.tex_Codigo_rubro);
            this.groupBox1.Controls.Add(this.but_Buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos rubro";
            // 
            // tex_Descripcion_larga
            // 
            this.tex_Descripcion_larga.Location = new System.Drawing.Point(28, 134);
            this.tex_Descripcion_larga.Name = "tex_Descripcion_larga";
            this.tex_Descripcion_larga.Size = new System.Drawing.Size(273, 20);
            this.tex_Descripcion_larga.TabIndex = 6;
            // 
            // tex_Descripcion_corta
            // 
            this.tex_Descripcion_corta.Location = new System.Drawing.Point(121, 77);
            this.tex_Descripcion_corta.Name = "tex_Descripcion_corta";
            this.tex_Descripcion_corta.Size = new System.Drawing.Size(100, 20);
            this.tex_Descripcion_corta.TabIndex = 5;
            this.tex_Descripcion_corta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tex_Codigo_rubro
            // 
            this.tex_Codigo_rubro.Location = new System.Drawing.Point(121, 39);
            this.tex_Codigo_rubro.Name = "tex_Codigo_rubro";
            this.tex_Codigo_rubro.Size = new System.Drawing.Size(78, 20);
            this.tex_Codigo_rubro.TabIndex = 4;
            // 
            // but_Buscar
            // 
            this.but_Buscar.Location = new System.Drawing.Point(205, 39);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(55, 23);
            this.but_Buscar.TabIndex = 3;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion larga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion corta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de rubro";
            // 
            // but_Eliminar
            // 
            this.but_Eliminar.Location = new System.Drawing.Point(215, 199);
            this.but_Eliminar.Name = "but_Eliminar";
            this.but_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.but_Eliminar.TabIndex = 34;
            this.but_Eliminar.Text = "Eliminar";
            this.but_Eliminar.UseVisualStyleBackColor = true;
            // 
            // but_Modificar
            // 
            this.but_Modificar.Location = new System.Drawing.Point(134, 199);
            this.but_Modificar.Name = "but_Modificar";
            this.but_Modificar.Size = new System.Drawing.Size(75, 23);
            this.but_Modificar.TabIndex = 35;
            this.but_Modificar.Text = "Modificar";
            this.but_Modificar.UseVisualStyleBackColor = true;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(53, 199);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(75, 23);
            this.but_Agregar.TabIndex = 36;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            // 
            // frm_Gestion_rubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 249);
            this.Controls.Add(this.but_Agregar);
            this.Controls.Add(this.but_Eliminar);
            this.Controls.Add(this.but_Modificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Gestion_rubro";
            this.Text = "Gestion de rubro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_Descripcion_larga;
        private System.Windows.Forms.TextBox tex_Descripcion_corta;
        private System.Windows.Forms.TextBox tex_Codigo_rubro;
        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.Button but_Eliminar;
        private System.Windows.Forms.Button but_Modificar;
        private System.Windows.Forms.Button but_Agregar;
    }
}