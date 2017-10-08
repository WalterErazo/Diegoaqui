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
    public partial class CrearU : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        string grup;
        bool verificado = false;
        public CrearU(Usuario[] u, Grupo[] g)
        {
            InitializeComponent();
            users = u;
            grupos = g;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "" && txtGrupo.Text == "" && txtContra.Text == "" && txtCargo.Text == "")
            {
                MessageBox.Show("Por Favor llenar todos los cuadros de texto.");

            }
            else
            {
                if (txtCargo.Text == "")
                {
                    MessageBox.Show("Ingresar Cargo que desempaña.");

                }
                else
                {
                    if (txtContra.Text == "")
                    {
                        MessageBox.Show("Ingresar Contraseña.");
                    }
                    else
                    {
                        if (txtGrupo.Text == "")
                        {
                            MessageBox.Show("Ingresar el Grupo que pertenece.");
                        }
                        else
                        {
                            if (txtId.Text == "")
                            {
                                MessageBox.Show("Ingresar ID.");
                            }
                        }
                    }
                }
            }


            Usuario user = new Usuario();
            user.setId(txtId.Text);
            user.setCargo(txtCargo.Text);
            user.setGrupo(txtGrupo.Text);
            user.setContra(txtContra.Text);
            grup = txtGrupo.Text;
            Grupo nuevog = new Grupo();
            nuevog.setParlamentario(user);
            nuevog.setNombre(user.getGrupo());
           


                if (txtCargo.Text == "parlamentario" || txtCargo.Text == "Parlamentario")
            {
                    if (verificarGrupo() == false)

                    {
                    MessageBox.Show(" EL nombre de grupo ya fue utilizado");
                }
                if (verificarId() == false)
                {
                    MessageBox.Show(" EL nombre de usuario ya fue utilizado");
                }
                while (verificarGrupo() == true && verificarId() == true)
                {


                    añadirGrupo(nuevog);
                    añadirUsuario(user);
                    MessageBox.Show(" EL usuario y grupo fueron creados");
                    Form1 f1 = new Form1(users, grupos);
                    f1.Show();
                    this.Hide();

                    break;


                }
            }


            else if (txtCargo.Text == "asesor" || txtCargo.Text == "asesor")
            {
                if (verificarGrupo() == true)

                {
                    MessageBox.Show(" Usted fue asignado al gurpo desado" );
                }
                if (verificarId() == false)
                {
                    MessageBox.Show(" EL nombre de usuario ya fue utilizado");
                }
                while (verificarGrupo() == true && verificarId() == true)
                {


                    for (int i=0; i < 200; i++)
                    {
                        if (grupos[i] != null)
                        {
                            if(grupos[i].getNombre()== txtGrupo.Text)
                            {
                                grupos[i].asignarAsesor(user);
                            }
                        }

                    }
                    añadirUsuario(user);
                    MessageBox.Show(" EL usuario fue creado y añadido al grupo");
                    Form1 f1 = new Form1(users, grupos);
                    f1.Show();
                    this.Hide();

                    break;


                }

            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearU_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(users, grupos);
            f1.Show();
            this.Hide();
        }

        private void añadirUsuario(Usuario u)
        {
            for (int i = 0; i < 999; i++)
            {
                if (users[i] == null)
                {
                    users[i] = u;
                    break;
                }


            }
        }

        private void añadirGrupo(Grupo g)
        {
            for (int i = 0; i < 200; i++)
            {
                if (grupos[i] == null)
                {
                    grupos[i] = g;
                    break;
                }

            }
        }
        private bool verificarGrupo()
        {
            for (int n = 0; n < 200; n++)
            {
                if (grupos[n] != null)
                {
                    if (grupos[n].getNombre() == txtGrupo.Text)
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }
        private bool verificarId()
        {
            for (int n = 0; n < 999; n++)
            {
                if (users[n] != null)
                {
                    if (users[n].getId() == txtId.Text)
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
        

