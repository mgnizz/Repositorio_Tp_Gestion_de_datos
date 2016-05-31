namespace WindowsFormsApplication1
{
    partial class frm_Tareas_Usuario_Empresa
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
            this.but_Nueva = new System.Windows.Forms.Button();
            this.but_Modificar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.but_Listado_estadistico = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.but_Facturas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_Reputacion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Nueva);
            this.groupBox1.Controls.Add(this.but_Modificar);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // but_Nueva
            // 
            this.but_Nueva.Location = new System.Drawing.Point(103, 19);
            this.but_Nueva.Name = "but_Nueva";
            this.but_Nueva.Size = new System.Drawing.Size(128, 23);
            this.but_Nueva.TabIndex = 0;
            this.but_Nueva.Text = "Nueva";
            this.but_Nueva.UseVisualStyleBackColor = true;
            this.but_Nueva.Click += new System.EventHandler(this.but_Nueva_Click);
            // 
            // but_Modificar
            // 
            this.but_Modificar.Location = new System.Drawing.Point(103, 50);
            this.but_Modificar.Name = "but_Modificar";
            this.but_Modificar.Size = new System.Drawing.Size(128, 23);
            this.but_Modificar.TabIndex = 5;
            this.but_Modificar.Text = "Modificar ";
            this.but_Modificar.UseVisualStyleBackColor = true;
            this.but_Modificar.Click += new System.EventHandler(this.but_Modificar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.but_Listado_estadistico);
            this.groupBox5.Location = new System.Drawing.Point(46, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 72);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estadisticas";
            // 
            // but_Listado_estadistico
            // 
            this.but_Listado_estadistico.Location = new System.Drawing.Point(103, 30);
            this.but_Listado_estadistico.Name = "but_Listado_estadistico";
            this.but_Listado_estadistico.Size = new System.Drawing.Size(128, 23);
            this.but_Listado_estadistico.TabIndex = 4;
            this.but_Listado_estadistico.Text = "Listado estadistico";
            this.but_Listado_estadistico.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.but_Reputacion);
            this.groupBox4.Controls.Add(this.but_Facturas);
            this.groupBox4.Location = new System.Drawing.Point(46, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 78);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultar";
            // 
            // but_Facturas
            // 
            this.but_Facturas.Location = new System.Drawing.Point(103, 19);
            this.but_Facturas.Name = "but_Facturas";
            this.but_Facturas.Size = new System.Drawing.Size(128, 23);
            this.but_Facturas.TabIndex = 3;
            this.but_Facturas.Text = "Facturas";
            this.but_Facturas.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 7;
            // 
            // but_Reputacion
            // 
            this.but_Reputacion.Location = new System.Drawing.Point(103, 48);
            this.but_Reputacion.Name = "but_Reputacion";
            this.but_Reputacion.Size = new System.Drawing.Size(128, 23);
            this.but_Reputacion.TabIndex = 6;
            this.but_Reputacion.Text = "Reputacion";
            this.but_Reputacion.UseVisualStyleBackColor = true;
            // 
            // frm_Tareas_Usuario_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 299);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tareas_Usuario_Empresa";
            this.Text = "Tareas usuario empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Nueva;
        private System.Windows.Forms.Button but_Modificar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button but_Listado_estadistico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button but_Facturas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_Reputacion;
    }
}