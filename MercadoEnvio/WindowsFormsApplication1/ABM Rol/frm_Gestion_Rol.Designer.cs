namespace WindowsFormsApplication1.ABM_Rol
{
    partial class frm_Gestion_Rol
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
            this.but_Agregar = new System.Windows.Forms.Button();
            this.dgv_Listado_roles = new System.Windows.Forms.DataGridView();
            this.gro_Elegir_rol = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_roles)).BeginInit();
            this.gro_Elegir_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Buscar
            // 
            this.but_Buscar.Location = new System.Drawing.Point(177, 129);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(73, 23);
            this.but_Buscar.TabIndex = 15;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            this.but_Buscar.Click += new System.EventHandler(this.but_Buscar_Click);
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(143, 181);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(119, 35);
            this.but_Agregar.TabIndex = 17;
            this.but_Agregar.Text = "Agregar nuevo rol";
            this.but_Agregar.UseVisualStyleBackColor = true;
            this.but_Agregar.Click += new System.EventHandler(this.but_Agregar_Click);
            // 
            // dgv_Listado_roles
            // 
            this.dgv_Listado_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado_roles.Location = new System.Drawing.Point(19, 19);
            this.dgv_Listado_roles.Name = "dgv_Listado_roles";
            this.dgv_Listado_roles.Size = new System.Drawing.Size(231, 104);
            this.dgv_Listado_roles.TabIndex = 22;
            this.dgv_Listado_roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Listado_roles_CellContentClick);
            // 
            // gro_Elegir_rol
            // 
            this.gro_Elegir_rol.Controls.Add(this.but_Buscar);
            this.gro_Elegir_rol.Controls.Add(this.dgv_Listado_roles);
            this.gro_Elegir_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Elegir_rol.Name = "gro_Elegir_rol";
            this.gro_Elegir_rol.Size = new System.Drawing.Size(291, 163);
            this.gro_Elegir_rol.TabIndex = 24;
            this.gro_Elegir_rol.TabStop = false;
            this.gro_Elegir_rol.Text = "Elegir rol";
            // 
            // frm_Gestion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 240);
            this.Controls.Add(this.gro_Elegir_rol);
            this.Controls.Add(this.but_Agregar);
            this.Name = "frm_Gestion_Rol";
            this.Load += new System.EventHandler(this.frm_Gestion_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_roles)).EndInit();
            this.gro_Elegir_rol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.DataGridView dgv_Listado_roles;
        private System.Windows.Forms.GroupBox gro_Elegir_rol;

    }
}