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
        public unsafe void RobarCarta()
        {
            int cartasMano = 0;

            Nodo* auxMons = ManoMonstruos.cabeza;
            while (auxMons != null)
            {
                cartasMano++;
                auxMons = auxMons->getSiguiente();
            }

            NodoHechizos* auxHech = ManoHechizos.cabeza;
            while (auxHech != null)
            {
                cartasMano++;
                auxHech = auxHech->getSiguiente();
            }

            NodoTrampaAtaque* auxTrampAtaq = ManoTrampasAtaque.cabeza;
            while (auxTrampAtaq != null)
            {
                cartasMano++;
                auxTrampAtaq = auxTrampAtaq->getSiguiente();
            }

            NodoTrampasInvocacion* auxTrampInv = ManoTrampasInvocacion.cabeza;
            while (auxTrampInv != null)
            {
                cartasMano++;
                auxTrampInv = auxTrampInv->getSiguiente();
            }

            if (cartasMano < 6)
            {
                Random random = new Random();
                int tipoRobo = random.Next(1, 4);

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

                        if (cantMonstruos == 0)
                        {
                            RobarCarta();
                            return;
                        }

                        aux2 = DeckMonstruo.cabeza;
                        int RobandoCarta = random.Next(1, cantMonstruos + 1);
                        for (int i = 0; i < RobandoCarta - 1; i++)
                        {
                            aux2 = aux2->getSiguiente();
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

                        aux3 = DeckHechizos.cabeza;
                        RobandoCarta = random.Next(1, cantHechizos + 1);
                        for (int i = 0; i < RobandoCarta - 1; i++)
                        {
                            aux3 = aux3->getSiguiente();
                        }

                        DeckHechizos.Eliminar(aux3->getHechizo());
                        ManoHechizos.Insertar(aux3->getHechizo());
                        break;

                    case 3:
                        int tipoHechizo = random.Next(1, 3);
                        if (tipoHechizo == 1)
                        {
                            NodoTrampaAtaque* aux4 = DeckTrampasAtaque.cabeza;
                            int cantidadTrampasAtaque = 0;
                            while (aux4 != null)
                            {
                                cantidadTrampasAtaque++;
                                aux4 = aux4->getSiguiente();
                            }

                            if (cantidadTrampasAtaque == 0)
                            {
                                RobarCarta();
                                return;
                            }

                            aux4 = DeckTrampasAtaque.cabeza;
                            RobandoCarta = random.Next(1, cantidadTrampasAtaque + 1);
                            for (int i = 0; i < RobandoCarta - 1; i++)
                            {
                                aux4 = aux4->getSiguiente();
                            }

                            DeckTrampasAtaque.Eliminar(aux4->getTrampa());
                            ManoTrampasAtaque.InsertarTr(aux4->getTrampa());
                        }
                        else
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
                            RobandoCarta = random.Next(1, cantidadTrampasInvocacion + 1);
                            for (int i = 0; i < RobandoCarta - 1; i++)
                            {
                                aux5 = aux5->getSiguiente();
                            }

                            DeckTrampasInvocacion.Eliminar(aux5->getTrampa());
                            ManoTrampasInvocacion.InsertarTra(aux5->getTrampa());
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No puedes robar más cartas, tu mano está llena.");
            }
        }
    }
}
