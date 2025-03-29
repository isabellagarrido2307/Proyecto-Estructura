using System;
using System.Collections.Generic;
using System.Linq;
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
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setAtaque(Monstruo->getAtaque()+700);
            Monstruo->setTurnosDeEstado(1);
        }
    }
    public unsafe class CambioFidelidad  : Hechizos
    {
        public CambioFidelidad()
        {
            setNombre("Cambio de Fidelidad");
            setDireccion(Properties.Resources.CambioFidel);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
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
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
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
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            *Vida = *Vida + 2000;
        }
    }
    public unsafe class EspadaDestino : Hechizos
    {
        public EspadaDestino()
        {
            setNombre("Espada del Destino");
            setDireccion(Properties.Resources.EspadaDestino);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setAtaque(Monstruo->getAtaque() + 1000);
            Monstruo->setTurnosDeEstado(1);
        }
    }
    public unsafe class EspadaEscudo : Hechizos
    {
        public EspadaEscudo()
        {
            setNombre("Espada por Escudo");
            setDireccion(Properties.Resources.EspadaEscudo);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setAtaque(Monstruo->getDefensa());
            Monstruo->setDefensa(Monstruo->getAtaque());
            Monstruo->setTurnosDeEstado(1);
        }
    }
    public unsafe class FuriaDragoniana : Hechizos
    {
        public FuriaDragoniana()
        {
            setNombre("Furia Dragoniana");
            setDireccion(Properties.Resources.FuriaDragoniana);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setAtaque(Monstruo->getAtaque() + 500);
            Monstruo->setDefensa(Monstruo->getDefensa() - 400);
            Monstruo->setTurnosDeEstado(1);
        }
    }
    public unsafe class MonstruoRenacido : Hechizos
    {
        public MonstruoRenacido()
        {
            setNombre("Monstruo Renacido");
            setDireccion(Properties.Resources.MonstruoRenacido);
        }
        public unsafe void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            if (*Vida+2000 >= 8000)
            {
                *Vida = 8000;
            }
            else
            {
                *Vida = *Vida + 2000;
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
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setModo(false);
        }
    }
    public unsafe class OllaCodicia : Hechizos
    {
        public OllaCodicia()
        {
            setNombre("Olla de la Codicia");
            setDireccion(Properties.Resources.OllaCodicia);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {

        }
    }
    public unsafe class PactoDemoniaco : Hechizos
    {
        public PactoDemoniaco()
        {
            setNombre("Pacto Demoníaco");
            setDireccion(Properties.Resources.PactoDemoniaco);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Monstruo->setAtaque(Monstruo->getAtaque() * 2);
            Monstruo->setDefensa(0);
            Monstruo->setTurnosDeEstado(1);
        }
    }
    public unsafe class ProvisionesEmergencia : Hechizos
    {
        public ProvisionesEmergencia()
        {
            setNombre("Provisiones de Emergencia");
            setDireccion(Properties.Resources.ProvisionesEmergencia);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            int contador = 0;
            Nodo* aux = Cementerio->cabeza;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            if (*Vida + contador * 300 >= 8000)
            {
                *Vida = 8000;
            }
            else
            {
                *Vida = *Vida + contador * 300;
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
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Cementerio->Insertar(*Monstruo);
            Campo->Eliminar(*Monstruo);
        }
    }
    public unsafe class RecargaMagica : Hechizos
    {
        public RecargaMagica()
        {
            setNombre("Recarga Mágica");
            setDireccion(Properties.Resources.RecargaMagica);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
        }
    }
    public unsafe class TormentaFlamas : Hechizos
    {
        public TormentaFlamas()
        {
            setNombre("Tormenta de Flamas");
            setDireccion(Properties.Resources.TormentaFlamas);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Vida -= 800;
        }
    }
    public unsafe class TormentaRelampagos : Hechizos
    {
        public TormentaRelampagos()
        {
            setNombre("Tormenta Relámpago");
            setDireccion(Properties.Resources.TormentaRelampago);
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            Nodo* aux = Campo->cabeza;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < 2000)
                {
                    Cementerio->Insertar(aux->getMonstruo());
                    Campo->Eliminar(aux->getMonstruo());
                }
                aux = aux->getSiguiente();
            }
        }
    }
}
