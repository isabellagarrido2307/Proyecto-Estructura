using System;
using System.Collections.Generic;
using System.Linq;
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
            NodoTrampa pepe = new NodoTrampa(_trampas);
            NodoTrampa* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoTrampa* aux = cabeza;
                aux->setSiguiente(cabeza);
                cabeza = aux;
            }
        }
        public void Eliminar(TrampasAtaque _trampas)
        {
            NodoTrampa* aux = cabeza;
            NodoTrampa* aux2 = cabeza;
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
