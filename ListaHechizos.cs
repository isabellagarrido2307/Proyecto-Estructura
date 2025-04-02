using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaHechizos
    {
        private int tamano;
        public NodoHechizos* cabeza;
        public ListaHechizos()
        {
            tamano = 0;
            this.cabeza = null;
        }
        public int getTamano()
        {
            return tamano;
        }
        public unsafe void Insertar(Hechizos _hechizo)
        {
            NodoHechizos* nuevo = (NodoHechizos*)Marshal.AllocHGlobal(sizeof(NodoHechizos));
            nuevo->setHechizos(_hechizo);
            nuevo->setSiguiente(null);
            if (this.cabeza == null)
            {
                this.cabeza = nuevo;
            }
            else
            {
                nuevo->setSiguiente(this.cabeza);
                this.cabeza = nuevo;
            }
            tamano++;
        }
        public void Eliminar(Hechizos _hechizo)
        {
            NodoHechizos* aux = cabeza;
            NodoHechizos* aux2 = null;
            while (aux != null)
            {
                if (aux->getHechizo() == _hechizo)
                {
                    if (aux2 == null)
                    {
                        cabeza = aux->getSiguiente();
                    }
                    else
                    {
                        aux2->setSiguiente(aux->getSiguiente());
                    }
                    Marshal.FreeHGlobal((IntPtr)aux);
                    return;
                }
                aux2 = aux;
                aux = aux->getSiguiente();
            }
            tamano--;
        }
    }
}

