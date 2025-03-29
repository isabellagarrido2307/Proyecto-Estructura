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
        public ListaTrampasInvocacion CampoTrampasInvocacion;
        public ListaTrampasAtaque CampoTrampasAtaque;
        public ListaTrampasInvocacion DeckTrampasInvocacion;
        public ListaTrampasAtaque DeckTrampasAtaque;
        public Cementerio Cementerio;
        public ListaMonstruos ManoMonstruos;
        public ListaHechizos ManoHechizos;
        public ListaTrampasInvocacion ManoTrampasInvocacion;
        public ListaTrampasAtaque ManoTrampasAtaque;
        public Jugador()
        {
            Vida = 8000;
            CampoMonstruos = new ListaMonstruos();
            DeckMonstruo = new ListaMonstruos();
            CampoHechizos = new ListaHechizos();
            DeckHechizos = new ListaHechizos();
            CampoTrampasInvocacion = new ListaTrampasInvocacion();
            DeckTrampasInvocacion = new ListaTrampasInvocacion();
            CampoTrampasAtaque = new ListaTrampasAtaque();
            DeckTrampasAtaque = new ListaTrampasAtaque();
            Cementerio = new Cementerio(new ListaMonstruos(), new ListaHechizos(), new ListaTrampasInvocacion(), new ListaTrampasAtaque());
            ManoMonstruos = new ListaMonstruos();
            ManoHechizos = new ListaHechizos();
            ManoTrampasInvocacion = new ListaTrampasInvocacion();
            ManoTrampasAtaque = new ListaTrampasAtaque();
        }
        public unsafe void RobarCarta ()
        {
            int cartasCampo = 0;
            Nodo* auxMons = ManoMonstruos.cabeza;
            while (auxMons != null)
            {
                cartasCampo++;
                auxMons = auxMons->getSiguiente();
            }
            NodoHechizos* auxHech = ManoHechizos.cabeza;
            while (auxHech != null)
            {
                cartasCampo++;
                auxHech = auxHech->getSiguiente();
            }
            NodoTrampaAtaque* auxTrampAtaq = ManoTrampasAtaque.cabeza;
            while (auxTrampAtaq != null)
            {
                cartasCampo++;
                auxTrampAtaq = auxTrampAtaq->getSiguiente();
            }
            NodoTrampasInvocacion* auxTrampInv = ManoTrampasInvocacion.cabeza;
            while (auxTrampInv != null)
            {
                cartasCampo++;
                auxTrampInv = auxTrampInv->getSiguiente();
            }

            if (cartasCampo < 6)
            {
                Random random = new Random();
                int tipoRobo = random.Next(1, 3);
                switch (tipoRobo)
                {
                    case 1:
                        Nodo* aux2 = DeckMonstruo.cabeza;
                        int cantMonstruos = 0;
                        while (aux2 != null)
                        {
                            cantMonstruos++;
                            aux2 = aux2->getSiguiente();
                        }
                        if (cantMonstruos != 0)
                        {
                            RobarCarta();
                            return;
                        }
                        aux2 = DeckMonstruo.cabeza;
                        int RobandoCarta = random.Next(1, cantMonstruos);
                        for (int i = 0; i < RobandoCarta; i++)
                        {
                            if (aux2->getSiguiente != null)
                            {
                                aux2 = aux2->getSiguiente();
                            }
                        }
                        DeckMonstruo.Eliminar(aux2->getMonstruo());
                        ManoMonstruos.Insertar(aux2->getMonstruo());
                        
                        break;
                    case 2:
                        NodoHechizos* aux3 = DeckHechizos.cabeza;
                        int cantHechizos = 0;
                        while (aux3 != null)
                        {
                            cantHechizos++;
                            aux3 = aux3->getSiguiente();
                        }
                        if (cantHechizos == 0)
                        {
                            RobarCarta();
                            return;
                        }
                        RobandoCarta = random.Next(1, 8);
                        for (int i = 0; i < RobandoCarta; i++)
                        {
                            if (aux3->getSiguiente != null)
                            {
                                aux3 = aux3->getSiguiente();
                            }
                        }
                        DeckHechizos.Eliminar(aux3->getHechizo());
                        ManoHechizos.Insertar(aux3->getHechizo());
                        break;
                    case 3:
                        int tipoHechizo = random.Next(1, 2);
                        if (tipoHechizo == 1)
                        {
                            NodoTrampaAtaque* aux4 = DeckTrampasAtaque.cabeza;
                            int cantidadTrampasAtaque = 0;
                            while (aux4 != null)
                            {
                                cantidadTrampasAtaque++;
                                aux4 = aux4->getSiguiente();
                            }
                            aux4 = DeckTrampasAtaque.cabeza;
                            if (cantidadTrampasAtaque == 0)
                            {
                                RobarCarta();
                                return;
                            }
                            else {
                                RobandoCarta = random.Next(1, 3);
                                for (int i = 0; i < RobandoCarta; i++)
                                {
                                    if (aux4->getSiguiente != null)
                                    {
                                        aux4 = aux4->getSiguiente();
                                    }
                                }
                                DeckTrampasAtaque.Eliminar(aux4->getTrampa());
                                ManoTrampasAtaque.Insertar(aux4->getTrampa());
                            }
                        }
                        if (tipoHechizo == 2)
                        {
                            NodoTrampasInvocacion* aux5 = DeckTrampasInvocacion.cabeza;
                            int cantidadTrampasInvocacion = 0;
                            while (aux5 != null)
                            {
                                cantidadTrampasInvocacion++;
                                aux5 = aux5->getSiguiente();
                            }
                            if (cantidadTrampasInvocacion == 0)
                            {
                                RobarCarta();
                                return;
                            }
                            aux5 = DeckTrampasInvocacion.cabeza;
                            RobandoCarta = random.Next(1, 8);
                            for (int i = 0; i < RobandoCarta; i++)
                            {
                                if (aux5->getSiguiente != null)
                                {
                                    aux5 = aux5->getSiguiente();
                                }
                            }
                            DeckTrampasInvocacion.Eliminar(aux5->getTrampa());
                            ManoTrampasInvocacion.Insertar(aux5->getTrampa());
                        }
                        RobandoCarta = random.Next(1, 8);
                        break;
                    
                }
            } else
            {
                MessageBox.Show("No puedes robar mas cartas");
            }
        }
    }
}
