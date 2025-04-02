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
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return true;
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
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
        public override bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return (CartaInvocada.getAtaque()>=2000);
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
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
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return CartaInvocada.getAtaque() >= 1000;
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo , Monstruos CartaInvocada)
        {
            jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(CartaInvocada);
            jugadorEnemigo.CampoMonstruos.Eliminar(CartaInvocada);
        }
    }
    public unsafe class ArmaduraSakuretsu : TrampasAtaque
    {
        public ArmaduraSakuretsu()
        {
            setNombre("Armadura Sakuretsu");
            setDireccion(Properties.Resources.ArmaduraSakuretsu);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(CartaInvocada);
            jugadorEnemigo.CampoMonstruos.Eliminar(CartaInvocada);
        }
    }
    public unsafe class BalatroBalatrez : TrampasAtaque
    {
        public BalatroBalatrez()
        {
            setNombre("Balatro Balatrez");
            setDireccion(Properties.Resources.BalatroBalatrez);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            jugadorEnemigo.Vida -= CartaInvocada.getAtaque();
        }
    }
    public unsafe class CadenasDeSombra : TrampasAtaque
    {
        public CadenasDeSombra()
        {
            setNombre("Cadenas de Sombra");
            setDireccion(Properties.Resources.CadenasSombra);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            cartaAtacante.setAtaque(cartaAtacante.getAtaque() - 1000);
        }
    }
    public unsafe class CambioPreventivo : TrampasAtaque
    {
        public CambioPreventivo()
        {
            setNombre("Cambio Preventivo");
            setDireccion(Properties.Resources.CambioPreventivo);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
        }
    }
    public unsafe class CilindroMagico : TrampasAtaque
    {
        public CilindroMagico()
        {
            setNombre("Cilindro Magico");
            setDireccion(Properties.Resources.CilindroMagico);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            jugadorEnemigo.Vida -= cartaAtacante.getAtaque();
        }
    }
    public unsafe class EngatuzamientoLabioso : TrampasAtaque
    {
        public EngatuzamientoLabioso()
        {
            setNombre("Engatuzamiento Labioso");
            setDireccion(Properties.Resources.Engatuzamiento);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
        }
    }
    public unsafe class EspantapajarosDeHierro : TrampasAtaque
    {
        public EspantapajarosDeHierro()
        {
            setNombre("Espantapajaros de hierro");
            setDireccion(Properties.Resources.EspantaHierro);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
        }
    }
    public unsafe class EspejoDeFuerza : TrampasAtaque
    {
        public EspejoDeFuerza()
        {
            setNombre("Espejo de Fuerza");
            setDireccion(Properties.Resources.EspejoFuerza);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
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
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
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
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            jugadorAliado.RobarCarta();
        }
    }
    public unsafe class LlamarAlCondenado : TrampasInvocacion
    {
        public LlamarAlCondenado()
        {
            setNombre("LLamar al condenado");
            setDireccion(Properties.Resources.LlamarCondenado);
        }
        public override unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return true;
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
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
            if (aux1 == null)
            {
                MessageBox.Show("No hay monstruos en el cementerio");
            }
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
        public override bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        override public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
        }
    }
    public unsafe class RobarDestino : TrampasInvocacion
    {
        public RobarDestino()
        {
            setNombre("Agujero Negro");
            setDireccion(Properties.Resources.RobarDestino);
        }
        public override bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return true;
        }
        override public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            Nodo* aux = jugadorAliado.Cementerio.CementerioMonstruos.cabeza;
            if (aux != null)
            {
                jugadorAliado.CampoMonstruos.Insertar(aux->getMonstruo());
                jugadorAliado.Cementerio.CementerioMonstruos.Eliminar(aux->getMonstruo());
                aux->getMonstruo().setModo(false);
            }
        }
    }
}


