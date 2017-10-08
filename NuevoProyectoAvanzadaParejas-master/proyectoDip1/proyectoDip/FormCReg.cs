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
    public partial class FormCReg : Form
    {

        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        queue copiasReg = new queue();
        string usuarioActualM;
        public FormCReg(Usuario[] u, Grupo[] g, string ua="",Ley[] bl=null)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioActualM = ua;
            biblioLeyes = bl;
        }

        private void FormCReg_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingreseReglamento;
            ingreseReglamento = txtInfoReg.Text;
            if (ingreseReglamento == "" && txtLey.Text == "")
            {
                MessageBox.Show("Debe ingresar el reglamento y la ley a la que pertenece");
            }
            else if (ingreseReglamento != "")
            {
                while (verificarLey() == false)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (biblioLeyes[i].getinfoDeLey() == txtLey.Text)
                        {
                            biblioLeyes[i].crearReglamento(txtInfoReg.Text);
                            biblioLeyes[i].asignarCopiasReg();
                            break;
                        }


                        break;
                    }
                    if (verificarLey() == true)
                    {
                        MessageBox.Show("No se encontro la ley a la cual desea asignar un reglamento");
                    }

                    MessageBox.Show("Reglamento Creado con Exito.");
                    menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
                    m.Show();
                    this.Hide();

                }
            }
        }  

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
            m.Show();
            this.Hide();

        }
        private bool verificarLey()
        {
            for (int n = 0; n < 500; n++)
            {
                if (biblioLeyes[n] != null)
                {
                    if (biblioLeyes[n].getinfoDeLey() == txtLey.Text)
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }
    }
}
