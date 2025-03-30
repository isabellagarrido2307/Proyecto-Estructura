using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaTrampas
    {
        public NodoTrampa* cabeza;
        public ListaTrampas()
        {
            cabeza = null;
        }
        public unsafe void Insertar(TrampasAtaque _trampas)
        {
            NodoTrampa* nuevo = (NodoTrampa*)Marshal.AllocHGlobal(sizeof(NodoTrampa));
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
            NodoTrampa* aux = cabeza;
            NodoTrampa* aux2 = cabeza;
            if (aux != null && aux->getTrampa() == _trampas)
            {
                cabeza = aux->getSiguiente(); 
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
