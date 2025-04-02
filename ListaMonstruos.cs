using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaMonstruos
    {
        private int tamano;
        public Nodo* cabeza;
        public ListaMonstruos()
        {
            tamano = 0;
            this.cabeza = null;
        }
        public int getTamano()
        {
            return tamano;
        }
        public unsafe void Insertar(Monstruos _monstruo)
        {
            Nodo* nuevo = (Nodo*)Marshal.AllocHGlobal(sizeof(Nodo));
            nuevo->setMonstruo(_monstruo);
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
        public void Eliminar(Monstruos _monstruo)
        {
            Nodo* aux = cabeza;
            Nodo* aux2 = null;
            while (aux != null)
            {
                if (aux->getMonstruo() == _monstruo)
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
        public Monstruos BuscarMonstruo(string Nombre)
        {
            Nodo* aux = cabeza;
            while (aux != null && aux->getMonstruo().getNombre() != Nombre)
            {
                
                aux = aux->getSiguiente();
            }
            return aux->getMonstruo();
        }
    }
}