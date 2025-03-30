using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe struct NodoTrampa
    {
        private unsafe NodoTrampa* siguiente { get; set; }
        private TrampasAtaque trampas { get; set; }
        public NodoTrampa(TrampasAtaque _trampas)
        {
            siguiente = null;
            trampas = _trampas;
        }

        public NodoTrampa* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(NodoTrampa* _siguiente)
        {
            siguiente = _siguiente;
        }
        public TrampasAtaque getTrampa()
        {
            return trampas;
        }
        public void setTrampa(TrampasAtaque _trampas)
        {
            trampas = _trampas;
        }
    }
}
