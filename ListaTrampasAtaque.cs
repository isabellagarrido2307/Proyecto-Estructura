using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaTrampasAtaque
    {
        private int tamano;
        public NodoTrampaAtaque* cabeza;
        public ListaTrampasAtaque()
        {
            cabeza = null;
            tamano = 0;
        }
        public int getTamano()
        {
            return tamano;
        }
        public unsafe void InsertarTr(TrampasAtaque _trampas)
        {
            NodoTrampaAtaque* nuevo = (NodoTrampaAtaque*)Marshal.AllocHGlobal(sizeof(Nodo));
            nuevo->setTrampa(_trampas);
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
        public void Eliminar(TrampasAtaque _trampas)
        {
            NodoTrampaAtaque* aux = cabeza;
            NodoTrampaAtaque* aux2 = null;
            while (aux != null)
            {
                if (aux->getTrampa() == _trampas)
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
        public TrampasAtaque BuscarMonstruo(string Nombre)
        {
            NodoTrampaAtaque* aux = cabeza;
            while (aux != null && aux->getTrampa().getNombre() != Nombre)
            {
                aux = aux->getSiguiente();
            }
            return aux->getTrampa();
        }
    }
}
