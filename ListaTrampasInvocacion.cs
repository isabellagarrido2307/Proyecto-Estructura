using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaTrampasInvocacion
    {
        private int tamano;
        public NodoTrampasInvocacion* cabeza;
        public ListaTrampasInvocacion()
        {
            tamano = 0;
            this.cabeza = null;
        }
        public int getTamano()
        {
            return tamano;
        }
        public unsafe void InsertarTra(TrampasInvocacion _trampas)
        {
            NodoTrampasInvocacion* nuevo = (NodoTrampasInvocacion*)Marshal.AllocHGlobal(sizeof(NodoTrampasInvocacion));
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
        public void Eliminar(TrampasInvocacion _trampas)
        {
            NodoTrampasInvocacion* aux = cabeza;
            NodoTrampasInvocacion* aux2 = null;
            while (aux != null)
            {
                if (aux->getTrampa() == _trampas)
                {
                    if(aux2 == null)
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
        public TrampasInvocacion BuscarMonstruo(string Nombre)
        {
            NodoTrampasInvocacion* aux = cabeza;
            while (aux != null && aux->getTrampa().getNombre() != Nombre)
            {
                aux = aux->getSiguiente();
            }
            return aux->getTrampa();
        }
    }
}
