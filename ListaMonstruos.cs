using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaMonstruos
    {
        public Nodo* cabeza;
        public ListaMonstruos()
        {
            this.cabeza = null;
        }

        public unsafe void Insertar(Monstruos _monstruo)
        {
            Nodo* nuevo = (Nodo*)Marshal.AllocHGlobal(sizeof(Nodo));
            nuevo->setMonstruo(_monstruo);
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
        public void Eliminar(Monstruos _monstruo)
        {
            Nodo* aux = this.cabeza;
            Nodo* aux2 = this.cabeza;
            if (this.cabeza->getMonstruo() == _monstruo)
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