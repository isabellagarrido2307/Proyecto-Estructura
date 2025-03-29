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
        public ListaTrampasInvocacion CementerioTrampasInvocacion;
        public ListaTrampasAtaque CementerioTrampasAtaque;

        public Cementerio(ListaMonstruos cementerioMonstruos, ListaHechizos cementerioHechizos, ListaTrampasInvocacion cementerioTrampasInvocacion, ListaTrampasAtaque cementerioTrampasAtaque)
        {
            CementerioMonstruos = cementerioMonstruos;
            CementerioHechizos = cementerioHechizos;
            CementerioTrampasInvocacion = cementerioTrampasInvocacion;
            CementerioTrampasAtaque = cementerioTrampasAtaque;
        } 
    }
}
