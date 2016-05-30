namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class frm_Gestion_visibilidad
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
            this.but_Agregar = new System.Windows.Forms.Button();
            this.but_Eliminar = new System.Windows.Forms.Button();
            this.but_Modificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tex_Comision_producto_vendido = new System.Windows.Forms.TextBox();
            this.tex_Descripcion = new System.Windows.Forms.TextBox();
            this.tex_Codigo_visibilidad = new System.Windows.Forms.TextBox();
            this.but_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_Comision_tipo_publicidad = new System.Windows.Forms.TextBox();
            this.tex_Comision_envio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(51, 282);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(75, 23);
            this.but_Agregar.TabIndex = 40;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            // 
            // but_Eliminar
            // 
            this.but_Eliminar.Location = new System.Drawing.Point(213, 282);
            this.but_Eliminar.Name = "but_Eliminar";
            this.but_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.but_Eliminar.TabIndex = 38;
            this.but_Eliminar.Text = "Eliminar";
            this.but_Eliminar.UseVisualStyleBackColor = true;
            // 
            // but_Modificar
            // 
            this.but_Modificar.Location = new System.Drawing.Point(132, 282);
            this.but_Modificar.Name = "but_Modificar";
            this.but_Modificar.Size = new System.Drawing.Size(75, 23);
            this.but_Modificar.TabIndex = 39;
            this.but_Modificar.Text = "Modificar";
            this.but_Modificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tex_Comision_envio);
            this.groupBox1.Controls.Add(this.tex_Comision_tipo_publicidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lab_Descripcion);
            this.groupBox1.Controls.Add(this.tex_Comision_producto_vendido);
            this.groupBox1.Controls.Add(this.tex_Descripcion);
            this.groupBox1.Controls.Add(this.tex_Codigo_visibilidad);
            this.groupBox1.Controls.Add(this.but_Buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 254);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos visibilidad";
            // 
            // tex_Comision_producto_vendido
            // 
            this.tex_Comision_producto_vendido.Location = new System.Drawing.Point(181, 118);
            this.tex_Comision_producto_vendido.Name = "tex_Comision_producto_vendido";
            this.tex_Comision_producto_vendido.Size = new System.Drawing.Size(120, 20);
            this.tex_Comision_producto_vendido.TabIndex = 6;
            // 
            // tex_Descripcion
            // 
            this.tex_Descripcion.Location = new System.Drawing.Point(181, 77);
            this.tex_Descripcion.Name = "tex_Descripcion";
            this.tex_Descripcion.Size = new System.Drawing.Size(120, 20);
            this.tex_Descripcion.TabIndex = 5;
            // 
            // tex_Codigo_visibilidad
            // 
            this.tex_Codigo_visibilidad.Location = new System.Drawing.Point(181, 39);
            this.tex_Codigo_visibilidad.Name = "tex_Codigo_visibilidad";
            this.tex_Codigo_visibilidad.Size = new System.Drawing.Size(61, 20);
            this.tex_Codigo_visibilidad.TabIndex = 4;
            // 
            // but_Buscar
            // 
            this.but_Buscar.Location = new System.Drawing.Point(246, 39);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(55, 23);
            this.but_Buscar.TabIndex = 3;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comisión por producto vendido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comisión por tipo de publicación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de visibilidad";
            // 
            // lab_Descripcion
            // 
            this.lab_Descripcion.AutoSize = true;
            this.lab_Descripcion.Location = new System.Drawing.Point(22, 77);
            this.lab_Descripcion.Name = "lab_Descripcion";
            this.lab_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lab_Descripcion.TabIndex = 7;
            this.lab_Descripcion.Text = "Descripcion";
            this.lab_Descripcion.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comisión por envío del producto";
            // 
            // tex_Comision_tipo_publicidad
            // 
            this.tex_Comision_tipo_publicidad.Location = new System.Drawing.Point(181, 160);
            this.tex_Comision_tipo_publicidad.Name = "tex_Comision_tipo_publicidad";
            this.tex_Comision_tipo_publicidad.Size = new System.Drawing.Size(120, 20);
            this.tex_Comision_tipo_publicidad.TabIndex = 9;
            // 
            // tex_Comision_envio
            // 
            this.tex_Comision_envio.Location = new System.Drawing.Point(181, 202);
            this.tex_Comision_envio.Name = "tex_Comision_envio";
            this.tex_Comision_envio.Size = new System.Drawing.Size(120, 20);
            this.tex_Comision_envio.TabIndex = 10;
            // 
            // frm_Gestion_visibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 343);
            this.Controls.Add(this.but_Agregar);
            this.Controls.Add(this.but_Eliminar);
            this.Controls.Add(this.but_Modificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Gestion_visibilidad";
            this.Text = "Gestion de visibilidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.Button but_Eliminar;
        private System.Windows.Forms.Button but_Modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tex_Comision_producto_vendido;
        private System.Windows.Forms.TextBox tex_Descripcion;
        private System.Windows.Forms.TextBox tex_Codigo_visibilidad;
        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.TextBox tex_Comision_envio;
        private System.Windows.Forms.TextBox tex_Comision_tipo_publicidad;
    }
}