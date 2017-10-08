using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    class Stack
    {
        public int capacity = 5;
        private Ley[] leyes;
        private int t = -1;
        public Stack(int capacity)
        {
            leyes = new Ley[capacity];

        }

        public Boolean isEmpty()
        {
            if (t == -1)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public Boolean isFull()
        {
            if (t == (capacity - 1))
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public void push(Ley l)
        {
            if (isFull()==true)
            {
                MessageBox.Show("no hay espacio para una nueva ley");
            }
            else
            { t++;

                leyes[t] = l;
            }
        }

        public Ley pop ( )
        {
            Ley lt = new Ley();
            lt = null; 
            if (isEmpty() == true)
            {
                MessageBox.Show("no hay leyes en el sistema");
                return lt;
                  
            }
            else
            {
                lt = leyes[t];
                t--;
                return lt;
            }
        }
        public int size()
        {
            return t + 1;
        }



    }
}
