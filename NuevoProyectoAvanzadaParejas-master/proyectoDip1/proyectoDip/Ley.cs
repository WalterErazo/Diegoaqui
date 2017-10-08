using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public class Ley
    {
        private Reglamentos[] reglamentosDeLey;
        private string infoDeLey;
        private  string contenidoDeLey;
        private int numReglamentos=0;
        queue copiasLey = new queue();
        queue copiasReg = new queue();
        private int copaiasDisponibles = 5;
        Reglamentos[] reg = new Reglamentos[5];

        public int getCopiasDisponibles()
        {
            return copaiasDisponibles;
        }

        public string getinfoDeLey()
        {
            return infoDeLey;
        }
        public void setinfoDeLey(string nombreDeLey)
        {
            this.infoDeLey = nombreDeLey;

        }

        public int numerodereglamentos (){
            for (int i =0; 1<5; i++)
            {
                if (reg[i] != null)
                {
                    numReglamentos += 1;
                }
            }
  
            return numReglamentos;

                    
            }

        public void crearReglamento(string info)
        {
            Reglamentos r = new Reglamentos();
            r.setInfoReglamento(info);
            for (int i =0; i<5; i++)
            {
                if (reg[i] == null)
                {
                    reg[i] = r;
                    break;
                }
            }
        }
        public void modificarReglamento(int num, string mod)
        {
            if (reg[num] != null)
            {
                reg[num].setInfoReglamento(mod);
            }else
            {
                MessageBox.Show("NO existe el reglamento No. " + num);
            }
        }
        public void eliminarReglamento(int num)
        {
            if(reg[num]!=null)
            {
                reg[num] = null;
            }
            else
            {
                MessageBox.Show("NO existe el reglamento No. "+ num);
            }
           
        }

        public void asignarCopias()
        {
            for (int i = 0; i < 5; i++)
            {
                copiasLey.enqueue(infoDeLey);

            }
        }
             public void asignarCopiasReg()
             {
            for (int i = 0; i < 5; i++)
            {
                if (reg[i] != null)
                {
                    reg[i].asignarCopiasR();
                }

            }
         }
        public Reglamentos[] getReglamentos()
        {
            return reglamentosDeLey;
        }

        public void setReglamentos(Reglamentos[] rglmts)
        {
            this.reglamentosDeLey = rglmts;
        }

    }
}
