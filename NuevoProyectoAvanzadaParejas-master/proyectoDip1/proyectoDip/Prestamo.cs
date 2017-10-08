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
    public partial class Prestamo : Form
    {

        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioactual = "";


        public Prestamo(Usuario[] u, Grupo[] g, string ua)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioactual = ua;       


        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PrestarLey;
            PrestarLey = richTextBox1.Text;

            if (PrestarLey == "")
            {
                MessageBox.Show("Ingrese Ley que desea Prestar.");
            }
            else
            {
                if (PrestarLey != "")
                {
                    Ley nuevaLey = new Ley();
                    nuevaLey.setinfoDeLey(PrestarLey);
                    nuevaLey.asignarCopias();
                    for (int i = 0; i < 500; i++)
                    {

                        biblioLeyes[i] = nuevaLey;
                        listBox1.Items.Remove(PrestarLey);
                        i = 500;

                    }
                }

                MessageBox.Show("Ley Prestada exitosamente.");
                menu regresomeno = new menu();
                regresomeno.Show();
                this.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PrestarLey;
            PrestarLey = richTextBox1.Text;

            if (PrestarLey == "")
            {
                MessageBox.Show("Ingrese Ley que desea Prestar.");
            }
            else
            {
                if (PrestarLey != "")
                {
                    Ley nuevaLey = new Ley();
                    nuevaLey.setinfoDeLey(PrestarLey);
                    nuevaLey.asignarCopias();
                    for (int i = 0; i < 500; i++)
                    {

                        biblioLeyes[i] = nuevaLey;
                        listBox1.Items.Add(PrestarLey);
                        i = 500;

                    }
                }
            }
        }
    }
}
