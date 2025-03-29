using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Nodo
    {
        private Nodo* siguiente {  get; set; }
        private Monstruos monstruo { get; set; }
        public Nodo(Monstruos _monstruo)
        {
            monstruo = _monstruo;
            siguiente = null;
        }
        public Nodo* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(Nodo* _siguiente)
        {
            siguiente = _siguiente;
        }
        public Monstruos getMonstruo()
        {
            return monstruo;
        }
        public void setMonstruo(Monstruos _monstruo)
        {
            monstruo = _monstruo;
        }


    }
}
