﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe struct NodoHechizos
    {
        private unsafe NodoHechizos* siguiente;
        private Hechizos hechizos;
        public NodoHechizos(Hechizos _hechizos)
        {
            siguiente = null;
            hechizos = _hechizos;
        }
        public NodoHechizos* getSiguiente()
        {
            return siguiente;
        }
        public unsafe void setSiguiente(NodoHechizos* _siguiente)
        {
            siguiente = _siguiente;
        }
        public Hechizos getHechizo()
        {
            return hechizos;
        }
        public void setHechizos(Hechizos _hechizos)
        {
            hechizos = _hechizos;
        }
    }
}
