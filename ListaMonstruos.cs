using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaMonstruos
    {
        public Nodo* cabeza;
        public ListaMonstruos()
        {
            cabeza = null;
        }

        public unsafe void Insertar(Monstruos _monstruo)
        {
            Nodo pepe = new Nodo(_monstruo);
            Nodo* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo* aux = cabeza;
                aux->setSiguiente(cabeza);
                cabeza = aux;
            }
        }
        public void Eliminar(Monstruos _monstruo)
        {
            Nodo* aux = cabeza;
            Nodo* aux2 = cabeza;
            if (cabeza->getMonstruo() == _monstruo)
            {
                cabeza = cabeza->getSiguiente();
                return;
            }
            while (aux != null)
            {
                if (aux->getMonstruo() == _monstruo)
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