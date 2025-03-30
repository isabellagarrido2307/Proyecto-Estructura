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
        public NodoTrampaAtaque* cabeza;
        public ListaTrampasAtaque()
        {
            cabeza = null;
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
        }
        public void Eliminar(TrampasAtaque _trampas)
        {
            NodoTrampaAtaque* aux = cabeza;
            NodoTrampaAtaque* aux2 = cabeza;
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
