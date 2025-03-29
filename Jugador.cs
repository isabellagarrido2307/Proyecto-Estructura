using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class Jugador
    {
        public int Vida;
        public ListaMonstruos CampoMonstruos;
        public ListaMonstruos DeckMonstruo;
        public ListaHechizos CampoHechizos;
        public ListaHechizos DeckHechizos;
        public ListaTrampas CampoTrampas;
        public ListaTrampas DeckTrampas;
        public Cementerio Cementerio;
        public ListaMonstruos ManoMonstruos;
        public ListaHechizos ManoHechizos;
        public ListaTrampas ManoTrampas;
        public Jugador()
        {
            Vida = 8000;
            CampoMonstruos = new ListaMonstruos();
            DeckMonstruo = new ListaMonstruos();
            CampoHechizos = new ListaHechizos();
            DeckHechizos = new ListaHechizos();
            CampoTrampas = new ListaTrampas();
            DeckTrampas = new ListaTrampas();
            Cementerio = new Cementerio(new ListaMonstruos(), new ListaHechizos(), new ListaTrampas());
            ManoMonstruos = new ListaMonstruos();
            ManoHechizos = new ListaHechizos();
            ManoTrampas = new ListaTrampas();
        }

    }
}
