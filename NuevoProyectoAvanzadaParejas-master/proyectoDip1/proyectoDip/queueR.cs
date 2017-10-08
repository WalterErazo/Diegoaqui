using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    class queueR
    {
        public int CAPACITY = 5;
        private Reglamentos[] cLeyes;
        private int f = -1;
        public int l = -1;
        private int sz = 0;
        public queueR()
        {
            f = -1;
            sz = -1;

            cLeyes = new Reglamentos[CAPACITY];


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
        public void enqueue(Reglamentos ley)
        {

            if (isFull() == true)
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
                    f = 0;
                }

            }

        }

        public Reglamentos dequeue()
        {
            Reglamentos rt = new Reglamentos();
            rt = null;
            if (isEmpty() == true)
            {
                MessageBox.Show("no hay leyes en el sistema");

                return rt;
            }
            else
            {
                rt = cLeyes[f];
                if (f == l)
                {
                    f = -1;
                    l = -1;

                }
                else
                {
                    f += 1;
                    sz -= 1;

                }
                return rt;
            }
        }

    }
}

    

