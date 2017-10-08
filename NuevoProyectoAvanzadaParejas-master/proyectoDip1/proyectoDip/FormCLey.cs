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
    public partial class FormCLey : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioactual = "";
        
        public FormCLey(Usuario[] u, Grupo[] g, string ua)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioactual = ua;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string IngreseLey;
            IngreseLey = txtIngreseLey.Text;

            if (IngreseLey == "")
            {
                MessageBox.Show("Ingrese Nueva Ley.");
            }
            else
            {
                if (IngreseLey != "")
                {
                    Ley nuevaLey = new Ley();
                    nuevaLey.setinfoDeLey(IngreseLey);
                    nuevaLey.asignarCopias();
                    for (int i = 0; i < 500; i++)
                    {
                        if (biblioLeyes[i] == null)
                        {
                            biblioLeyes[i] = nuevaLey;

                        }
                        else
                        {
                            MessageBox.Show("no hay espacio para una nueva ley");
                        }

                    }


                    MessageBox.Show("Ley Creada con Exito.");
                    menu m = new menu(users,grupos,usuarioactual,biblioLeyes);
                    m.Show();
                    this.Hide();
                    
                }
            }
        }

        private void FormCLey_Load(object sender, EventArgs e)
        {

        }
    }
}
