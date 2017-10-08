using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
    
    public class Reglamentos
    {
            private queue copiasReg = new queue();
        private int copiasDisponibles = 5;
        private int copiasEnLaCola = 5;
        private string infoReglamento = "";

        public void setInfoReglamento(string inforeglamento)
        {
            this.infoReglamento = inforeglamento;
        }
        public string getInfoReglamento()
        {
            return infoReglamento;
        }
        public void asignarCopiasR()
        {
            for (int i = 0; i < copiasEnLaCola; i++)
            {
                copiasReg.enqueue(infoReglamento);

            }
        }
        public void retirarCopiasMod(string mod)
        {
            int copiasModCola = 0;
            for (int i = 0; i < copiasDisponibles; i++)
            {
                copiasReg.dequeue();
                copiasDisponibles--;
                copiasModCola++;


            }
            for (int i = 0; i < copiasModCola; i++)
            {
                copiasReg.enqueue(mod);

            }

        }

    }

  
}