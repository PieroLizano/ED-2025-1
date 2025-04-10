using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.clases
{
    internal class ListaCircular
    {
        private Nodo prim = null;
        private Nodo ulti = null;

        public void insertar(int num) 
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;
            
            if(prim == null) 
            {
                prim = nuevo;
                nuevo.Siguiente = nuevo;
                ulti = nuevo;
            }
            else
            {
                ulti.Siguiente = nuevo;
                nuevo.Siguiente = prim;
                ulti = nuevo;
            }
        }
        public void mostrar(ListBox list) 
        {
            if (prim == null)
                return;

            Nodo actual = prim;

            do 
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;                    
            }while (actual != prim);
        }
        public void eliminar(int num) 
        {
            if (prim == null)
                return;

            Nodo actual = prim;
            Nodo ante = null;

            do
            {
                if (actual.Numero == num) 
                {
                    if (actual == prim & actual == ulti) 
                    {
                        prim = null; ulti = null;
                    }else if (actual == prim) 
                    {
                        prim = prim.Siguiente;
                        ulti.Siguiente = prim;
                    }else if (actual == ulti) 
                    {
                        ante.Siguiente = prim;
                        ulti = ante;
                    }
                    else 
                    {
                        ante.Siguiente = actual.Siguiente;
                    }
                    return;
                }
                ante = actual;
                actual = actual.Siguiente;
            } while (actual != prim);
        }
    }

}
