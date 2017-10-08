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
    public partial class menu : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        Ley[] biblioLeyes = new Ley[500];
        queue copiasLey = new queue();
        string usuarioActualM;
        public menu()
        {
            InitializeComponent();
        }
        public menu(Usuario[] u,Grupo[] g ,string UsuarioActual="", Ley[] bl=null,queue cl=null)
        {
            InitializeComponent();

            users = u;
            usuarioActualM = UsuarioActual;
            grupos = g;
            biblioLeyes = bl;
            copiasLey = cl;
        }


        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificar_usuario mod = new modificar_usuario(users,grupos,usuarioActualM);
            mod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCLey cley = new FormCLey(users, grupos,usuarioActualM);
            cley.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModLey mley = new ModLey(users,grupos,usuarioActualM,biblioLeyes,copiasLey);
            mley.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCReg creg = new FormCReg(users, grupos, usuarioActualM, biblioLeyes);
            creg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModReg modificarreglamento = new ModReg(users, grupos, usuarioActualM, biblioLeyes);
            modificarreglamento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prestamo PrestarLey = new Prestamo(users, grupos, usuarioActualM);
            PrestarLey.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Devolucion Devolverley = new Devolucion(users, grupos, usuarioActualM);
            Devolverley.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 SalirSeccion = new Form1();
            SalirSeccion.Show();
            this.Hide();
        }
    }
}
