using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class NodoTrampasInvocacion
    {
        private unsafe NodoTrampasInvocacion* siguiente { get; set; }
        private TrampasInvocacion trampas { get; set; }
        public NodoTrampasInvocacion(TrampasInvocacion _trampas)
        {
            siguiente = null;
            trampas = _trampas;
        }
        public NodoTrampasInvocacion* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(NodoTrampasInvocacion* _siguiente)
        {
            siguiente = _siguiente;
        }
        public TrampasInvocacion getTrampa()
        {
            return trampas;
        }
        public void setTrampa(TrampasInvocacion _trampas)
        {
            trampas = _trampas;
        }
    }
}
