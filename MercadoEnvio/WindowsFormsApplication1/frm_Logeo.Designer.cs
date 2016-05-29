namespace WindowsFormsApplication1
{
    partial class frm_Logeo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.tex_username = new System.Windows.Forms.TextBox();
            this.tex_password = new System.Windows.Forms.TextBox();
            this.but_Ingresar = new System.Windows.Forms.Button();
            this.gro_Inicio_de_sesion = new System.Windows.Forms.GroupBox();
            this.gro_Roles_a_elegir = new System.Windows.Forms.GroupBox();
            this.dgw_Roles_a_elegir = new System.Windows.Forms.DataGridView();
            this.but_Aceptar = new System.Windows.Forms.Button();
            this.gro_Inicio_de_sesion.SuspendLayout();
            this.gro_Roles_a_elegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Roles_a_elegir)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(6, 32);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(55, 13);
            this.lab_username.TabIndex = 0;
            this.lab_username.Text = "Username";
            this.lab_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(8, 63);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(53, 13);
            this.lab_password.TabIndex = 1;
            this.lab_password.Text = "Password";
            // 
            // tex_username
            // 
            this.tex_username.Location = new System.Drawing.Point(67, 29);
            this.tex_username.Name = "tex_username";
            this.tex_username.Size = new System.Drawing.Size(121, 20);
            this.tex_username.TabIndex = 2;
            // 
            // tex_password
            // 
            this.tex_password.Location = new System.Drawing.Point(67, 63);
            this.tex_password.Name = "tex_password";
            this.tex_password.Size = new System.Drawing.Size(121, 20);
            this.tex_password.TabIndex = 3;
            // 
            // but_Ingresar
            // 
            this.but_Ingresar.Location = new System.Drawing.Point(118, 98);
            this.but_Ingresar.Name = "but_Ingresar";
            this.but_Ingresar.Size = new System.Drawing.Size(82, 28);
            this.but_Ingresar.TabIndex = 4;
            this.but_Ingresar.Text = "Ingresar";
            this.but_Ingresar.UseVisualStyleBackColor = true;
            // 
            // gro_Inicio_de_sesion
            // 
            this.gro_Inicio_de_sesion.Controls.Add(this.lab_username);
            this.gro_Inicio_de_sesion.Controls.Add(this.but_Ingresar);
            this.gro_Inicio_de_sesion.Controls.Add(this.tex_username);
            this.gro_Inicio_de_sesion.Controls.Add(this.tex_password);
            this.gro_Inicio_de_sesion.Controls.Add(this.lab_password);
            this.gro_Inicio_de_sesion.Location = new System.Drawing.Point(34, 22);
            this.gro_Inicio_de_sesion.Name = "gro_Inicio_de_sesion";
            this.gro_Inicio_de_sesion.Size = new System.Drawing.Size(206, 132);
            this.gro_Inicio_de_sesion.TabIndex = 5;
            this.gro_Inicio_de_sesion.TabStop = false;
            this.gro_Inicio_de_sesion.Text = "Inicio de sesion";
            // 
            // gro_Roles_a_elegir
            // 
            this.gro_Roles_a_elegir.Controls.Add(this.but_Aceptar);
            this.gro_Roles_a_elegir.Controls.Add(this.dgw_Roles_a_elegir);
            this.gro_Roles_a_elegir.Location = new System.Drawing.Point(34, 177);
            this.gro_Roles_a_elegir.Name = "gro_Roles_a_elegir";
            this.gro_Roles_a_elegir.Size = new System.Drawing.Size(206, 157);
            this.gro_Roles_a_elegir.TabIndex = 6;
            this.gro_Roles_a_elegir.TabStop = false;
            this.gro_Roles_a_elegir.Text = "Roles a elegir";
            // 
            // dgw_Roles_a_elegir
            // 
            this.dgw_Roles_a_elegir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Roles_a_elegir.Location = new System.Drawing.Point(11, 20);
            this.dgw_Roles_a_elegir.Name = "dgw_Roles_a_elegir";
            this.dgw_Roles_a_elegir.Size = new System.Drawing.Size(177, 93);
            this.dgw_Roles_a_elegir.TabIndex = 0;
            // 
            // but_Aceptar
            // 
            this.but_Aceptar.Location = new System.Drawing.Point(118, 119);
            this.but_Aceptar.Name = "but_Aceptar";
            this.but_Aceptar.Size = new System.Drawing.Size(82, 32);
            this.but_Aceptar.TabIndex = 1;
            this.but_Aceptar.Text = "Aceptar";
            this.but_Aceptar.UseVisualStyleBackColor = true;
            this.but_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 376);
            this.Controls.Add(this.gro_Roles_a_elegir);
            this.Controls.Add(this.gro_Inicio_de_sesion);
            this.Name = "frm_Logeo";
            this.Text = "Logeo";
            this.gro_Inicio_de_sesion.ResumeLayout(false);
            this.gro_Inicio_de_sesion.PerformLayout();
            this.gro_Roles_a_elegir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Roles_a_elegir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox tex_username;
        private System.Windows.Forms.TextBox tex_password;
        private System.Windows.Forms.Button but_Ingresar;
        private System.Windows.Forms.GroupBox gro_Inicio_de_sesion;
        private System.Windows.Forms.GroupBox gro_Roles_a_elegir;
        private System.Windows.Forms.Button but_Aceptar;
        private System.Windows.Forms.DataGridView dgw_Roles_a_elegir;
    }
}

