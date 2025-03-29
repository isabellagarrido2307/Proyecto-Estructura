using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaHechizos
    {
        public NodoHechizos* cabeza;
        public ListaHechizos()
        {
            cabeza = null;
        }

        public unsafe void Insertar(Hechizos _hechizo)
        {
            NodoHechizos pepe = new NodoHechizos(_hechizo);
            NodoHechizos* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoHechizos* aux = cabeza;
                aux->setSiguiente(cabeza);
                cabeza = aux;
            }
        }
        public void Eliminar(Hechizos _hechizo)
        {
            NodoHechizos* aux = cabeza;
            NodoHechizos* aux2 = cabeza;
            if (cabeza->getHechizo() == _hechizo)
            {
                cabeza = cabeza->getSiguiente();
                return;
            }
            while (aux != null)
            {
                if (aux->getHechizo() == _hechizo)
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
