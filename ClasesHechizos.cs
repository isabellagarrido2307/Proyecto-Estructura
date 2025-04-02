using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ArremetidaImprudente : Hechizos 
    {
        public ArremetidaImprudente()
        {
            setNombre("Arremetida Imprudente");
            setDireccion(Properties.Resources.ArremetidaFuriosa);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.CampoMonstruos.cabeza == null)
            {
                return;
            }
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setAtaque(jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getAtaque() + 700);
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setTurnosDeEstado(1);
        }
    }
    public unsafe class CambioFidelidad  : Hechizos
    {
        public CambioFidelidad()
        {
            setNombre("Cambio de Fidelidad");
            setDireccion(Properties.Resources.CambioFidel);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            
        }
    }
    public unsafe class ControlMental : Hechizos
    {
        public ControlMental()
        {
            setNombre("Control Mental");
            setDireccion(Properties.Resources.ControlMental);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {

        }
    }
    public unsafe class CuracionSuperma : Hechizos
    {
        public CuracionSuperma()
        {
            setNombre("Curacion Suprema");
            setDireccion(Properties.Resources.CuracionSuprema);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            jugadorAliado.Vida = jugadorAliado.Vida + 2000;
        }
    }
    public unsafe class EspadaDestino : Hechizos
    {
        public EspadaDestino()
        {
            setNombre("Espada del Destino");
            setDireccion(Properties.Resources.EspadaDestino);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.CampoMonstruos.cabeza == null)
            {
                return;
            }
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().
            setAtaque(jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getAtaque() + 1000);
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setTurnosDeEstado(1);
        }
    }
    public unsafe class EspadaEscudo : Hechizos
    {
        public EspadaEscudo()
        {
            setNombre("Espada por Escudo");
            setDireccion(Properties.Resources.EspadaEscudo);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.CampoMonstruos.cabeza == null)
            {
                return;
            }
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().
            setAtaque(jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getDefensa());
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().
            setDefensa(jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getAtaque());
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setTurnosDeEstado(1);
        }
    }
    public unsafe class FuriaDragoniana : Hechizos //esta mal
    {
        public FuriaDragoniana()
        {
            setNombre("Furia Dragoniana");
            setDireccion(Properties.Resources.FuriaDragoniana);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            int contador = 0;
            Nodo* aux = jugadorAliado.Cementerio.CementerioMonstruos.cabeza; 
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            if (jugadorAliado.Vida - contador * 200 >= 0)
            {
                jugadorAliado.Vida = 0;
            }
            else
            {
                jugadorAliado.Vida = jugadorAliado.Vida - contador * 200;
            }
        }
    }
    public unsafe class MonstruoRenacido : Hechizos
    {
        public MonstruoRenacido()
        {
            setNombre("Monstruo Renacido");
            setDireccion(Properties.Resources.MonstruoRenacido);
        }
        override public unsafe void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.Vida + 2000 >= 8000)
            {
                jugadorAliado.Vida = 8000;
            }
            else
            {
                jugadorAliado.Vida = jugadorAliado.Vida + 2000;
            }
        }
    }
    public unsafe class NegarDefensa : Hechizos
    {
        public NegarDefensa()
        {
            setNombre("Negar Defensa");
            setDireccion(Properties.Resources.NegarDefensa);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.CampoMonstruos.cabeza == null)
            {
                return;
            }
            if (jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getModo() == false)
            {
                jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setModo(true);
            }
            else
            {
                jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setModo(false);
            }
        }
    }
    public unsafe class OllaCodicia : Hechizos
    {
        public OllaCodicia()
        {
            setNombre("Olla de la Codicia");
            setDireccion(Properties.Resources.OllaCodicia);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            jugadorAliado.RobarCarta();
            jugadorAliado.RobarCarta();
        }
    }
    public unsafe class PactoDemoniaco : Hechizos
    {
        public PactoDemoniaco()
        {
            setNombre("Pacto Demoníaco");
            setDireccion(Properties.Resources.PactoDemoniaco);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            if (jugadorAliado.CampoMonstruos.cabeza == null)
            {
                return;
            }
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().
            setAtaque(jugadorAliado.CampoMonstruos.cabeza->getMonstruo().getAtaque()*2);
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setDefensa(0);
            jugadorAliado.CampoMonstruos.cabeza->getMonstruo().setTurnosDeEstado(1);
        }
    }
    public unsafe class ProvisionesEmergencia : Hechizos
    {
        public ProvisionesEmergencia()
        {
            setNombre("Provisiones de Emergencia");
            setDireccion(Properties.Resources.ProvisionesEmergencia);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            int contador = 0;
            Nodo* aux = jugadorAliado.Cementerio.CementerioMonstruos.cabeza; //a segun
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            if (jugadorAliado.Vida + contador * 300 >= 8000)
            {
                jugadorAliado.Vida = 8000;
            }
            else
            {
                jugadorAliado.Vida = jugadorAliado.Vida + contador * 300;
            }
        }
    }
    public unsafe class Raigeki : Hechizos
    {
        public Raigeki()
        {
            setNombre("Raigeki");
            setDireccion(Properties.Resources.Raigeki);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(jugadorAliado.CampoMonstruos.cabeza->getMonstruo());
            jugadorEnemigo.CampoMonstruos.Eliminar(jugadorAliado.CampoMonstruos.cabeza->getMonstruo());
        }
    }
    public unsafe class RecargaMagica : Hechizos
    {
        public RecargaMagica()
        {
            setNombre("Recarga Mágica");
            setDireccion(Properties.Resources.RecargaMagica);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            jugadorAliado.RobarCarta();
            jugadorAliado.RobarCarta();
        }
    }
    public unsafe class TormentaFlamas : Hechizos
    {
        public TormentaFlamas()
        {
            setNombre("Tormenta de Flamas");
            setDireccion(Properties.Resources.TormentaFlamas);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            jugadorEnemigo.Vida -= 800;
        }
    }
    public unsafe class TormentaRelampagos : Hechizos
    {
        public TormentaRelampagos()
        {
            setNombre("Tormenta Relámpago");
            setDireccion(Properties.Resources.TormentaRelampago);
        }
        override public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {
            Nodo* aux = jugadorAliado.CampoMonstruos.cabeza;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < 2000)
                {
                    jugadorEnemigo.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                    jugadorEnemigo.CampoMonstruos.Eliminar(aux->getMonstruo());
                }
                aux = aux->getSiguiente();
            }
        }
    }
}
