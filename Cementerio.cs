using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class Cementerio
    {
        public ListaMonstruos CementerioMonstruos;
        public ListaHechizos CementerioHechizos;
        public ListaTrampas CementerioTrampas;

        public Cementerio(ListaMonstruos cementerioMonstruos, ListaHechizos cementerioHechizos, ListaTrampas cementerioTrampas)
        {
            CementerioMonstruos = cementerioMonstruos;
            CementerioHechizos = cementerioHechizos;
            CementerioTrampas = cementerioTrampas;
        } 
    }
}
