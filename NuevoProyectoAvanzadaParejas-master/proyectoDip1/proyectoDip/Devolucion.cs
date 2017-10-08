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
    public partial class Devolucion : Form
    {

        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioactual = "";
        
    

        public Devolucion(Usuario[] u, Grupo[] g, string ua)
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
            string DevolverLey;
            DevolverLey = richTextBox1.Text;

            if (DevolverLey == "")
            {
                MessageBox.Show("Ingrese Ley a devolver.");
            }
            else
            {
                if (DevolverLey != "")
                {
                    Ley nuevaLey = new Ley();
                    nuevaLey.setinfoDeLey(DevolverLey);
                    nuevaLey.asignarCopias();
                    for (int i = 0; i < 500; i++)
                    {                   
                        
                            biblioLeyes[i] = nuevaLey;
                            listBox1.Items.Add(DevolverLey);
                            i = 500;                    
                       
                    }
                    
                }

                MessageBox.Show("Ley fue devuelta con exito.");
                menu regresomeno = new menu();
                regresomeno.Show();
                this.Hide();
            }
        }
    }
}

   
