using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Generar_Publicación;

namespace WindowsFormsApplication1
{
    public partial class frm_Tareas_Usuario_Empresa : Form
    {
        public frm_Tareas_Usuario_Empresa()
        {
            InitializeComponent();
        }

        private void but_Nueva_Click(object sender, EventArgs e)
        {
            frm_Nueva nueva_publicacion = new frm_Nueva();
            nueva_publicacion.Show(this);
        }

        private void but_Modificar_Click(object sender, EventArgs e)
        {
            frm_Modificar modificar_publicacion = new frm_Modificar();
            modificar_publicacion.Show(this);
        }
    }
}
