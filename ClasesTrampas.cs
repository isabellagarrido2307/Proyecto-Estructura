using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    
    public unsafe class AgujeroOscuro : TrampasInvocacion
    {
        public AgujeroOscuro()
        {
            setNombre("Agujero Oscuro");
            setDireccion(Properties.Resources.AgujeroNegro);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            Nodo* aux = jugadorEnemigo.CampoMonstruos.cabeza;
            while (aux!= null)
            {
                jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                jugadorEnemigo.CampoMonstruos.Eliminar(aux->getMonstruo());
            }
            Nodo* aux1 = jugadorAliado.CampoMonstruos.cabeza;
            while (aux != null)
            {
                jugadorAliado.Cementerio.CementerioMonstruos.Insertar(aux1->getMonstruo());
                jugadorAliado.CampoMonstruos.Eliminar(aux1->getMonstruo());
            }
        }
    }

    public unsafe class AgujeroSinFondo : TrampasInvocacion
    {
        public AgujeroSinFondo()
        {
            setNombre("Agujero sin fondo");
            setDireccion(Properties.Resources.AgujeroSinFondo);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // validacion, si invoca, se hace en el main
            Nodo* aux = jugadorEnemigo.CampoMonstruos.cabeza;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < 2000)
                {
                    jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                    jugadorEnemigo.CampoMonstruos.Eliminar(aux->getMonstruo());
                }
            }
        }
    }
    public unsafe class AgujeroTrampa : TrampasInvocacion
    {
        public AgujeroTrampa()
        {
            setNombre("Agujero Trampa");
            setDireccion(Properties.Resources.AgujeroTrampa);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // validacion, si invoca, se hace en el main
            Nodo* aux = jugadorEnemigo.CampoMonstruos.cabeza;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < 1000)
                {
                    jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                    jugadorEnemigo.CampoMonstruos.Eliminar(aux->getMonstruo());
                }
            }
        }
    }
    public unsafe class ArmaduraSakuretsu : TrampasAtaque
    {
        public ArmaduraSakuretsu()
        {
            setNombre("Armadura Sakuretsu");
            setDireccion(Properties.Resources.ArmaduraSakuretsu);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class BalatroBalatrez : TrampasAtaque
    {
        public BalatroBalatrez()
        {
            setNombre("Balatro Balatrez");
            setDireccion(Properties.Resources.BalatroBalatrez);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class CadenasDeSombra : TrampasAtaque
    {
        public CadenasDeSombra()
        {
            setNombre("Cadenas de Sombra");
            setDireccion(Properties.Resources.CadenasSombra);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class CambioPreventivo : TrampasAtaque
    {
        public CambioPreventivo()
        {
            setNombre("Cambio Preventivo");
            setDireccion(Properties.Resources.CambioPreventivo);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class CilindroMagico : TrampasAtaque
    {
        public CilindroMagico()
        {
            setNombre("Cilindro Magico");
            setDireccion(Properties.Resources.CilindroMagico);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class EngatuzamientoLabioso : TrampasAtaque
    {
        public EngatuzamientoLabioso()
        {
            setNombre("Engatuzamiento Labioso");
            setDireccion(Properties.Resources.Engatuzamiento);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class EspantapajarosDeHierro : TrampasAtaque
    {
        public EspantapajarosDeHierro()
        {
            setNombre("Espantapajaros de hierro");
            setDireccion(Properties.Resources.EspantaHierro);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // metodo ataque battle phase
        }
    }
    public unsafe class EspejoDeFuerza : TrampasAtaque
    {
        public EspejoDeFuerza()
        {
            setNombre("Espejo de Fuerza");
            setDireccion(Properties.Resources.EspejoFuerza);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // si ataca, entonces:
            Nodo* aux = jugadorEnemigo.CampoMonstruos.cabeza;
            while (aux != null)
            {
                jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                jugadorEnemigo.CampoMonstruos.Eliminar(aux->getMonstruo());
            }
        }
    }
    public unsafe class Expropiese : TrampasAtaque
    {
        public Expropiese()
        {
            setNombre("Expropiese");
            setDireccion(Properties.Resources.Expropiese);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            Nodo* aux = jugadorAliado.CampoMonstruos.cabeza;
            if (aux == null)
            {
                Nodo* aux1 = jugadorEnemigo.CampoMonstruos.cabeza;
                if (aux1 != null)
                {
                    jugadorAliado.CampoMonstruos.Insertar(aux1->getMonstruo());
                    aux1->getMonstruo().setModo(false);
                }
            }
        }
    }
    public unsafe class JarraDeLaCodicia : TrampasAtaque
    {
        public JarraDeLaCodicia()
        {
            setNombre("Jarra de la codicia");
            setDireccion(Properties.Resources.JarraCodicia);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // requiere robar carta
        }
    }
    public unsafe class LlamarAlCondenado : TrampasInvocacion
    {
        public LlamarAlCondenado()
        {
            setNombre("LLamar al condenado");
            setDireccion(Properties.Resources.LlamarCondenado);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // si te atacan, entonces:
            Nodo* aux = jugadorAliado.CampoMonstruos.cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            Nodo* aux1 = jugadorAliado.Cementerio.CementerioMonstruos.cabeza;
            if (contador < 5)
            {
                jugadorAliado.CampoMonstruos.Insertar(aux1->getMonstruo());
                aux1->getMonstruo().setModo(false);
            }
        }
    }
    public unsafe class MuroDeDefensa : TrampasAtaque
    {
        public MuroDeDefensa()
        {
            setNombre("Muro de defensa");
            setDireccion(Properties.Resources.MuroDefensa);
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            // termina la battle phase
        }
    }
    public unsafe class RobarDestino : TrampasInvocacion
    {
        public RobarDestino()
        {
            setNombre("Agujero Negro");
            setDireccion(Properties.Resources.RobarDestino);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            Nodo* aux = jugadorAliado.Cementerio.CementerioMonstruos.cabeza;
            if (aux != null)
            {
                jugadorAliado.CampoMonstruos.Insertar(aux->getMonstruo());
                aux->getMonstruo().setModo(false);
            }
        }
    }
}


