using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe struct NodoTrampaAtaque
    {
        private unsafe NodoTrampaAtaque* siguiente;
        private TrampasAtaque trampas;
        public NodoTrampaAtaque(TrampasAtaque _trampas)
        {
            siguiente = null;
            trampas = _trampas;
        }

        public NodoTrampaAtaque* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(NodoTrampaAtaque* _siguiente)
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