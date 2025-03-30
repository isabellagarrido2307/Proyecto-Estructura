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
        public NodoTrampasInvocacion* cabeza;
        public ListaTrampasInvocacion()
        {
            this.cabeza = null;
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
        }
        public void Eliminar(TrampasInvocacion _trampas)
        {
            NodoTrampasInvocacion* aux = cabeza;
            NodoTrampasInvocacion* aux2 = cabeza;
            if (cabeza->getTrampa() == _trampas)
            {
                cabeza = cabeza->getSiguiente();
                return;
            }
            while (aux != null)
            {
                if (aux->getTrampa() == _trampas)
                {
                    aux2->setSiguiente(aux->getSiguiente());
                    return;
                }
                aux2 = aux;
                aux = aux->getSiguiente();
            }
        }
    }
}
