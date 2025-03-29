using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    internal class Jugador
    {
        private int Vida;
        public ListaMonstruos monstruosJ;
        public Jugador()
        {
            Vida = 8000;
            ListaMonstruos lista = new ListaMonstruos();
            monstruosJ = new ListaMonstruos();
        }
    }
}
