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
    public partial class ModReg : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        string usuarioActualM;
        Reglamentos[] tmp = new Reglamentos[5];

        public ModReg(Usuario[] u, Grupo[] g, string us,Ley[] bl=null)
        {
            InitializeComponent();
            users = u;
            grupos = g;
            usuarioActualM = us;
            biblioLeyes = bl;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu(users, grupos, usuarioActualM, biblioLeyes);
            m.Show();
            this.Hide();
        }

        private void ModReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (verificarLey() == false && verificarReg() ==true )
            {

                tmp[posicionReg()].setInfoReglamento(txtNewReg.Text);
                
                tmp[posicionReg()].asignarCopiasR();
                tmp[posicionReg()].retirarCopiasMod(txtNewReg.Text);

                    
                }


            }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private bool verificarReg()
        {
            if (verificarLey() == true)
            {
                for (int n = 0; n < 500; n++)
                {
                    if (biblioLeyes[n] != null)
                    {
                       tmp= biblioLeyes[n].getReglamentos();
                        if (tmp[posicionReg()].getInfoReglamento() == txtReg.Text)

                            return true; ;
                            break;
                        }
                    }
                }
            

            return false;
        }
        public int posicionReg()
        {
            int num=0;
            for (int i=0; i < 5; i++)
            {
                if(tmp[i]!=null)
                {
                    if (tmp[i].getInfoReglamento() == txtReg.Text)
                    {
                        return i;
                    }
                }
            }
            return num;
        }

        
    }
}
