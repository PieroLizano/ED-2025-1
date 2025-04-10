using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.clases
{
    class ListaSimple
    {
        private Nodo primero = null;

        public void insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null)
            {
                primero = nuevo;
                //primero.Siguiente = null;
            }
            else
            {
                Nodo actual = primero;

                while(actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
                nuevo.Siguiente = null;
            }
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }
    }
}
