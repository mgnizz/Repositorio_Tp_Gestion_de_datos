namespace WindowsFormsApplication1
{
    partial class frm_Tareas_Usuario_Cliente
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
            this.but_Nueva = new System.Windows.Forms.Button();
            this.but_Comprar_ofertar = new System.Windows.Forms.Button();
            this.but_Ver = new System.Windows.Forms.Button();
            this.but_Facturas = new System.Windows.Forms.Button();
            this.but_Listado_estadistico = new System.Windows.Forms.Button();
            this.but_Modificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.but_Reputacion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
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
            // but_Comprar_ofertar
            // 
            this.but_Comprar_ofertar.Location = new System.Drawing.Point(103, 19);
            this.but_Comprar_ofertar.Name = "but_Comprar_ofertar";
            this.but_Comprar_ofertar.Size = new System.Drawing.Size(128, 23);
            this.but_Comprar_ofertar.TabIndex = 1;
            this.but_Comprar_ofertar.Text = "Comprar/Ofertar";
            this.but_Comprar_ofertar.UseVisualStyleBackColor = true;
            // 
            // but_Ver
            // 
            this.but_Ver.Location = new System.Drawing.Point(103, 19);
            this.but_Ver.Name = "but_Ver";
            this.but_Ver.Size = new System.Drawing.Size(128, 23);
            this.but_Ver.TabIndex = 2;
            this.but_Ver.Text = "Ver";
            this.but_Ver.UseVisualStyleBackColor = true;
            // 
            // but_Facturas
            // 
            this.but_Facturas.Location = new System.Drawing.Point(103, 5);
            this.but_Facturas.Name = "but_Facturas";
            this.but_Facturas.Size = new System.Drawing.Size(128, 23);
            this.but_Facturas.TabIndex = 3;
            this.but_Facturas.Text = "Facturas";
            this.but_Facturas.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Nueva);
            this.groupBox1.Controls.Add(this.but_Modificar);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Ver);
            this.groupBox2.Location = new System.Drawing.Point(24, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_Comprar_ofertar);
            this.groupBox3.Location = new System.Drawing.Point(24, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 57);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Realizar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.but_Reputacion);
            this.groupBox4.Controls.Add(this.but_Facturas);
            this.groupBox4.Location = new System.Drawing.Point(24, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 69);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.but_Listado_estadistico);
            this.groupBox5.Location = new System.Drawing.Point(24, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 72);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estadisticas";
            // 
            // but_Reputacion
            // 
            this.but_Reputacion.Location = new System.Drawing.Point(103, 32);
            this.but_Reputacion.Name = "but_Reputacion";
            this.but_Reputacion.Size = new System.Drawing.Size(128, 23);
            this.but_Reputacion.TabIndex = 4;
            this.but_Reputacion.Text = "Reputacion";
            this.but_Reputacion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 5;
            // 
            // frm_Tareas_Usuario_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 494);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Tareas_Usuario_Cliente";
            this.Text = "Tareas usuario cliente";
            this.Load += new System.EventHandler(this.frm_Tareas_Usuario_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Nueva;
        private System.Windows.Forms.Button but_Comprar_ofertar;
        private System.Windows.Forms.Button but_Ver;
        private System.Windows.Forms.Button but_Facturas;
        private System.Windows.Forms.Button but_Listado_estadistico;
        private System.Windows.Forms.Button but_Modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_Reputacion;
    }
}