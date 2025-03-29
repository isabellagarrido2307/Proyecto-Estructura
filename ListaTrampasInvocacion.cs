using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaTrampasInvocacion
    {
        public NodoTrampasInvocacion* cabeza;
        public ListaTrampasInvocacion()
        {
            cabeza = null;
        }
        public unsafe void Insertar(TrampasInvocacion _trampas)
        {
            NodoTrampasInvocacion pepe = new NodoTrampasInvocacion(_trampas);
            NodoTrampasInvocacion* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoTrampasInvocacion* aux = cabeza;
                aux->setSiguiente(cabeza);
                cabeza = aux;
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
