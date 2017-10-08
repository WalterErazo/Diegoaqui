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
    public partial class modificar_usuario : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioActualM;
        int numarreglo=0;
        string grupoI;
        string grupoF;
       
        
    
        
        public modificar_usuario( Usuario[] u,Grupo[] g, string usuarioActual="", Ley[] bl=null )
        {
            InitializeComponent();
            users = u;
            grupos = g;

            users = u;
            usuarioActualM = usuarioActual;
            biblioLeyes = bl;

            for(int i =0; i < users.Length; i++)
            {
                if (users[i].getId() == usuarioActual)
                {
                    numarreglo = i;
                    break;
                }
            }
                    if(users[numarreglo].getId()== usuarioActualM)
                    {
                        if(users[numarreglo].getCargo()=="parlamentario"|| users[numarreglo].getCargo() == "Parlamentario")
                        {
                                     txtID.Text = users[numarreglo].getId();
                                     txtCargo.Text = users[numarreglo].getCargo();
                                     txtCargo.Hide();
                                      label4.Hide();
                                       txtGrupo.Text = users[numarreglo].getGrupo();
                                      txtGrupo.Hide();
                                         label1.Hide();
                                     txtContra.Text = users[numarreglo].getContra();
                                       

                        }
                        if (users[numarreglo].getCargo() == "asesor" || users[numarreglo].getCargo() == "Asesor")
                        {
                            txtID.Text = users[numarreglo].getId();
                            txtCargo.Text = users[numarreglo].getCargo();
                            label4.Hide();
                             txtCargo.Hide();
                             grupoI=txtGrupo.Text = users[numarreglo].getGrupo();
                            txtContra.Text = users[numarreglo].getContra();

                        }
                    }
                }
               
              
              
            

        private void modificar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labID_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          

           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtContra.Text != ""  && txtID.Text != "")
            {

                users[numarreglo].setId(txtID.Text);
                users[numarreglo].setCargo(txtCargo.Text);
                users[numarreglo].setContra(txtContra.Text);
                grupoF = txtGrupo.Text;
                if(grupoF != grupoI)
                {
                    for(int i =0; i<200; i++)
                    {
                        if (grupos[i] != null)
                        {
                            if (grupos[i].getNombre() == grupoF)
                            {
                                if (grupos[i].getContador() == 8)
                                {
                                    MessageBox.Show("El grupo al que desea entrar esta lleno");
                                    break;
                                }
                                else
                                {
                                    grupos[i].asignarAsesor(users[numarreglo]);
                                    grupos[posArregloG()].eliminarAsesor(usuarioActualM);
                                    users[numarreglo].setGrupo(grupos[i].getNombre());

        
                                }
                                
                                }
                            }
                        }
                    }
                
                MessageBox.Show("Usuario modificado con exito");
                menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("no puede dejar campos vacios");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string grupoE;
            for (int i = 0; i < 999; i++)
            {
                if (users[i] != null)
                {
                    if (users[i].getId() == usuarioActualM)
                    {
                        if (users[i].getCargo() == "parlamentario" || users[i].getCargo() == "Parlamentario")
                        {
                            grupoE = users[i].getGrupo();
                            for (int a = 0; a < 999; a++)
                            {
                                if (users[a]!= null && users[a].getGrupo() == grupoE)
                                {
                                    users[a] = null;
                                }
                                for (int b = 0; b < 200; b++)
                                {
                                    if (grupos[b] != null&& grupos[b].getNombre() == grupoE)
                                    {
                                        grupos[b] = null;
                                    }
                                }
                            }


                        }
                        if (users[i].getCargo() == "asesor" || users[i].getCargo() == "Asesor")
                        {
                            grupoE = users[i].getGrupo();
                            for (int a = 0; a < 200; a++)
                            {
                                if (grupos[a].getNombre() == grupoE)
                                {
                                    grupos[a].eliminarAsesor(users[i].getId());

                                }

                            }
                        }
                        MessageBox.Show("Usuario Eliminado");
                        Form1 f1 = new Form1(users, grupos);
                    }
                }

            }
        }
            
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
            m.Show();
            this.Hide();

        }
        private int posArregloG()
        { int n = 0;
            for(int i = 0; i < 200; i++)
            {
                if(grupos[i].getNombre()== grupoI)
                {
                    return n;
                }
            }
            return n;
        }
      
    }
}
