using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.ABM_Rubro;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Visibilidad;

namespace WindowsFormsApplication1
{
    public partial class frm_Tareas_Administrador : Form
    {
        public frm_Tareas_Administrador()
        {
            InitializeComponent();
        }

        private void but_Gestionar_Rol_Click(object sender, EventArgs e)
        {
            //lleva al formulario rol
            frm_Gestion_Rol rol = new frm_Gestion_Rol();
            rol.Show(this);
        }

        private void but_Gestionar_Rubro_Click(object sender, EventArgs e)
        {
            //lleva al formulario rubro
            frm_Gestion_rubro rubro = new frm_Gestion_rubro();
            rubro.Show(this);
            
        }

        private void but_Gestionar_Usuarios_Click(object sender, EventArgs e)
        {
            //lleva al formulario usuario
            frm_Gestion_usuario usuario = new frm_Gestion_usuario();
            usuario.Show(this);            
        }

        private void but_Gestionar_Visibilidad_Click(object sender, EventArgs e)
        {
            //lleva al formulario visibilidad
            frm_Gestion_visibilidad visibilidad = new frm_Gestion_visibilidad();
            visibilidad.Show(this);
        }
    }
}
