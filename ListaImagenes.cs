using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaImagenes
    {
        public NodoImagenes* cabeza;
        public ListaImagenes()
        {
            this.cabeza = null;
        }

        public unsafe void Insertar(Image _monstruo)
        {
            NodoImagenes* nuevo = (NodoImagenes*)Marshal.AllocHGlobal(sizeof(NodoImagenes));
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
    }
}
