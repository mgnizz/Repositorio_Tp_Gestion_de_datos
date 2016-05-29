namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class frm_Gestion_usuario
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
            this.gro_Tipo_de_gestion = new System.Windows.Forms.GroupBox();
            this.but_Gestionar_Cliente = new System.Windows.Forms.Button();
            this.but_Gestionar_Empresa = new System.Windows.Forms.Button();
            this.gro_Tipo_de_gestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gro_Tipo_de_gestion
            // 
            this.gro_Tipo_de_gestion.Controls.Add(this.but_Gestionar_Empresa);
            this.gro_Tipo_de_gestion.Controls.Add(this.but_Gestionar_Cliente);
            this.gro_Tipo_de_gestion.Location = new System.Drawing.Point(13, 13);
            this.gro_Tipo_de_gestion.Name = "gro_Tipo_de_gestion";
            this.gro_Tipo_de_gestion.Size = new System.Drawing.Size(221, 110);
            this.gro_Tipo_de_gestion.TabIndex = 0;
            this.gro_Tipo_de_gestion.TabStop = false;
            this.gro_Tipo_de_gestion.Text = "Tipo de usuario";
            // 
            // but_Gestionar_Cliente
            // 
            this.but_Gestionar_Cliente.Location = new System.Drawing.Point(65, 30);
            this.but_Gestionar_Cliente.Name = "but_Gestionar_Cliente";
            this.but_Gestionar_Cliente.Size = new System.Drawing.Size(107, 23);
            this.but_Gestionar_Cliente.TabIndex = 0;
            this.but_Gestionar_Cliente.Text = "Gestionar Cliente";
            this.but_Gestionar_Cliente.UseVisualStyleBackColor = true;
            // 
            // but_Gestionar_Empresa
            // 
            this.but_Gestionar_Empresa.Location = new System.Drawing.Point(65, 71);
            this.but_Gestionar_Empresa.Name = "but_Gestionar_Empresa";
            this.but_Gestionar_Empresa.Size = new System.Drawing.Size(107, 23);
            this.but_Gestionar_Empresa.TabIndex = 1;
            this.but_Gestionar_Empresa.Text = "Gestionar Empresa";
            this.but_Gestionar_Empresa.UseVisualStyleBackColor = true;
            // 
            // frm_Gestion_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 143);
            this.Controls.Add(this.gro_Tipo_de_gestion);
            this.Name = "frm_Gestion_usuario";
            this.Text = "Form3";
            this.gro_Tipo_de_gestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Tipo_de_gestion;
        private System.Windows.Forms.Button but_Gestionar_Empresa;
        private System.Windows.Forms.Button but_Gestionar_Cliente;
    }
}