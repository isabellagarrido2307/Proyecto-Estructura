using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe struct NodoImagenes
    {
        private NodoImagenes* siguiente;
        private Image imagen;
        public NodoImagenes(Image _imagen)
        {
            imagen = _imagen;
            siguiente = null;
        }
        public NodoImagenes* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(NodoImagenes* _siguiente)
        {
            siguiente = _siguiente;
        }
        public Image getImagen()
        {
            return imagen;
        }
        public void setMonstruo(Image _imagen)
        {
            imagen = _imagen;
        }


    }
}
