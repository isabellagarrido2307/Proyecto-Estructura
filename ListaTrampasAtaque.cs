using System;
using System.Collections.Generic;
using System.Linq;
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
        public unsafe void Insertar(TrampasAtaque _trampas)
        {
            NodoTrampaAtaque pepe = new NodoTrampaAtaque(_trampas);
            NodoTrampaAtaque* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoTrampaAtaque* aux = cabeza;
                aux->setSiguiente(cabeza);
                cabeza = aux;
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
