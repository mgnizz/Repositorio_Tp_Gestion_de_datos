using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class frm_Gestion_Rol : Form
    {
        public frm_Gestion_Rol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void but_Eliminar_Click(object sender, EventArgs e)
        {
            //puede eliminar una funcionalidad si es seleccionada desde el datagridview o puede eliminar
            //el rol completo si no seleciona nada y directo da en eliminar
        }

        private void but_Agregar_Click(object sender, EventArgs e)
        {
            //si ingresa algun codigo q no exite, tiene la opcion de completar los campos y agregar el nuevo rol
            //si ingresa algun codigo q exite, tiene la opcion de agregar alguna funcionalidad mas eligiendola desde
            //el comboBox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //no habilitado si el codigo del rol existe, lo q permite es sobreescribir la descripcion, si ademas elige
            //alguna funcionalidad del datagridview, entonces podra elegir del combobox que funcionalidad reemplazar
        }

        private void frm_Gestion_Rol_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Listado_roles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //mostrara el listado de todos los roles q hay actualmente en el sistema
        }

        private void but_Buscar_Click(object sender, EventArgs e)
        {
            //luego de elegir el rol del datagridview, lo q hace el boton es buscar y acomodar los datos
            //del rol en la ventana de abajo
        }
    }
}
