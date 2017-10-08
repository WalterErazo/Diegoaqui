using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
   public class queue
    {
        public int CAPACITY = 5;
        private string[] cLeyes;
        private int f = -1;
        public int l = -1;
        private int sz = 0;
        public queue()
        {
            f = -1;
            sz = -1;
            
            cLeyes = new string[CAPACITY];


        }

        public Boolean isEmpty()
        {
            if (sz == 0)
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
            if (sz == (CAPACITY))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public void enqueue( string ley)
        {

           if (isFull()== true)
            {
                MessageBox.Show("las copias estan llenas");
            }
            else
            {
                l += 1;
                cLeyes[l] = ley;
                sz++;
                if (l == 0)
                {
                    f= 0;
                }
                
            }
              
        }

        public string dequeue()
        {
            string lt = "";
            if (isEmpty() == true)
            {
                MessageBox.Show("no hay más leyes en el sistema");

                return lt;
            }
            else
            {
                lt = cLeyes[f];
                if (f == l)
                {
                    f = -1;
                    l = -1;

                }
                else
                {
                    f+=1;
                    sz -= 1;
                   
                }
                return lt;
            }
        }

    }
}
