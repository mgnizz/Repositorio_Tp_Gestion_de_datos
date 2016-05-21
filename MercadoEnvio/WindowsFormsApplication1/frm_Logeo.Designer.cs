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
            this.SuspendLayout();
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(32, 35);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(55, 13);
            this.lab_username.TabIndex = 0;
            this.lab_username.Text = "Username";
            this.lab_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(35, 103);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(53, 13);
            this.lab_password.TabIndex = 1;
            this.lab_password.Text = "Password";
            // 
            // tex_username
            // 
            this.tex_username.Location = new System.Drawing.Point(116, 35);
            this.tex_username.Name = "tex_username";
            this.tex_username.Size = new System.Drawing.Size(121, 20);
            this.tex_username.TabIndex = 2;
            // 
            // tex_password
            // 
            this.tex_password.Location = new System.Drawing.Point(116, 95);
            this.tex_password.Name = "tex_password";
            this.tex_password.Size = new System.Drawing.Size(121, 20);
            this.tex_password.TabIndex = 3;
            // 
            // but_Ingresar
            // 
            this.but_Ingresar.Location = new System.Drawing.Point(88, 159);
            this.but_Ingresar.Name = "but_Ingresar";
            this.but_Ingresar.Size = new System.Drawing.Size(82, 39);
            this.but_Ingresar.TabIndex = 4;
            this.but_Ingresar.Text = "Ingresar";
            this.but_Ingresar.UseVisualStyleBackColor = true;
            // 
            // form_Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 218);
            this.Controls.Add(this.but_Ingresar);
            this.Controls.Add(this.tex_password);
            this.Controls.Add(this.tex_username);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_username);
            this.Name = "form_Logeo";
            this.Text = "Logeo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox tex_username;
        private System.Windows.Forms.TextBox tex_password;
        private System.Windows.Forms.Button but_Ingresar;
    }
}

