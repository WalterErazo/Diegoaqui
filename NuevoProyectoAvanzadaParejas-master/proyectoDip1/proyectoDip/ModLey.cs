using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public partial class ModLey : Form
    {

        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        queue copiasLey = new queue();
        string usuarioActualM;
        public ModLey(Usuario[] u, Grupo[] g, string UsuarioActual = "", Ley[] bl = null, queue cl = null)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioActualM = UsuarioActual;
            biblioLeyes = bl;
            copiasLey = cl;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModLey_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIngMod.Text == "" && txtModBox.Text == "")
            {
                MessageBox.Show(" Debe ingresar la ley que desea modificar y el nuevo contenido");
            }
            else
            {
                for (int i = 0; i < 500; i++)
                {
                    if (biblioLeyes[i].getinfoDeLey() == txtIngMod.Text)
                    {
                        biblioLeyes[i].setinfoDeLey(txtModBox.Text);
                        MessageBox.Show("ley modificada con exito");
                        menu m = new menu(users, grupos, usuarioActualM, biblioLeyes, copiasLey);
                        m.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("la ley que desea modificar no se encuentra en el sistema");
                        txtIngMod.Clear();
                        txtModBox.Clear();
                        break;
                    }
                }
            }

        }

        private void txtIngMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtIngMod.Text == "")
            {
                MessageBox.Show(" Debe ingresar la ley que desea eliminar");
            }
            else
            {
                for (int i = 0; i < 500; i++)
                {
                    if (biblioLeyes[i].getinfoDeLey() == txtIngMod.Text)
                    {
                        biblioLeyes[i] = null;
                        MessageBox.Show("ley eliminada con exito");
                        menu m = new menu(users, grupos, usuarioActualM, biblioLeyes, copiasLey);
                        m.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("la ley que desea eliminar no se encuentra en el sistema");
                        txtIngMod.Clear();
                        txtModBox.Clear();
                        break;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu m = new menu(users, grupos, usuarioActualM, biblioLeyes, copiasLey);
            m.Show();
            this.Hide();
        }
    }
}
