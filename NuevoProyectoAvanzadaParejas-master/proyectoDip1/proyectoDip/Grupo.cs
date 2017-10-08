using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
   public class Grupo
    {
        string nombre;
        Usuario parlamentario;
        Usuario[] asesores = new Usuario[8];
        int contador = 0;

        public int getContador()
        {
            return contador; ;
        }
        public void setNombre(string n)
        {
            this.nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setParlamentario(Usuario p)
        {
            this.parlamentario = p;
        }
        public Usuario getParlamentario()
        {
            return parlamentario;
        }
        public void asignarAsesor(Usuario a)
        {

            for (int i = 0; i < 8; i++)
            {
                if (asesores[i] == a)
                {
                    
                    break;
                }
                if (asesores[i] == null)
                {
                    asesores[i] = a;
                    break;
                    
                }
              

            }
        }
            public bool VerificarAsesor(Usuario a)
        {
            for (int i = 0; i < 8; i++)
            {
                if (asesores[i]!= null&& asesores[i] == a)
                {
                    return true;
                    break;
                }
               
            }
            return false;
            }
      
        public void eliminarAsesores()
        {
            asesores = null;
        }

        public void eliminarAsesor(string id)
        {
            for (int i = 0; i < 8; i++)
            {
                if (asesores[i] != null)
                {
                    if (asesores[i].getId() == id)
                    {
                        asesores[i] = null;
                        contador--;
                        break;
                    }
                }
            }

        }
        }
    }

