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
        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            ListaMonstruos* aux = CampoEnemigo;
            while (aux->cabeza != null)
            {
                CementerioEnemigo->Insertar(aux->cabeza->getMonstruo());
                CampoEnemigo->Eliminar(aux->cabeza->getMonstruo());
            }
            ListaMonstruos* aux1 = CampoAliado;
            while (aux->cabeza != null)
            {
                CementerioAliado->Insertar(aux1->cabeza->getMonstruo());
                CampoAliado->Eliminar(aux1->cabeza->getMonstruo());
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
        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // validacion, si invoca, se hace en el main
            ListaMonstruos* aux = CampoEnemigo;
            while (aux->cabeza != null)
            {
                if (aux->cabeza->getMonstruo().getAtaque() < 2000)
                {
                    CementerioEnemigo->Insertar(aux->cabeza->getMonstruo());
                    CampoEnemigo->Eliminar(aux->cabeza->getMonstruo());
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
        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // validacion, si invoca, se hace en el main
            Nodo* aux = CampoEnemigo->cabeza;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < 1000)
                {
                    CementerioEnemigo->Insertar(aux->getMonstruo());
                    CampoEnemigo->Eliminar(aux->getMonstruo());
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            //se hace en el main
        }
    }
    public unsafe class BalatroBalatrez : TrampasAtaque
    {
        public BalatroBalatrez()
        {
            setNombre("Balatro Balatrez");
            setDireccion(Properties.Resources.BalatroBalatrez);
        }
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // clase jugador y main necesarias
        }
    }
    public unsafe class CadenasDeSombra : TrampasAtaque
    {
        public CadenasDeSombra()
        {
            setNombre("Cadenas de Sombra");
            setDireccion(Properties.Resources.CadenasSombra);
        }
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // metodo de fase ataque necesaria
        }
    }
    public unsafe class CambioPreventivo : TrampasAtaque
    {
        public CambioPreventivo()
        {
            setNombre("Cambio Preventivo");
            setDireccion(Properties.Resources.CambioPreventivo);
        }
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // metodo de fase ataque necesaria
        }
    }
    public unsafe class CilindroMagico : TrampasAtaque
    {
        public CilindroMagico()
        {
            setNombre("Cilindro Magico");
            setDireccion(Properties.Resources.CilindroMagico);
        }
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // clase jugador y main necesarias
        }
    }
    public unsafe class EngatuzamientoLabioso : TrampasAtaque
    {
        public EngatuzamientoLabioso()
        {
            setNombre("Engatuzamiento Labioso");
            setDireccion(Properties.Resources.Engatuzamiento);
        }
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // si ataca, entonces:
            ListaMonstruos* aux = CampoEnemigo;
            while (aux->cabeza != null)
            {
                CementerioEnemigo->Insertar(aux->cabeza->getMonstruo());
                CampoEnemigo->Eliminar(aux->cabeza->getMonstruo());
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // si te atacan, entonces:
            Nodo* aux = CampoAliado->cabeza;
            if (aux == null)
            {
                Nodo* aux1 = CampoEnemigo->cabeza;
                if (aux1 != null)
                {
                    CampoAliado->Insertar(aux1->getMonstruo());
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // requiere metodo robar carta
        }
    }
    public unsafe class LlamarAlCondenado : TrampasInvocacion
    {
        public LlamarAlCondenado()
        {
            setNombre("LLamar al condenado");
            setDireccion(Properties.Resources.LlamarCondenado);
        }
        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // si te atacan, entonces:
            Nodo* aux = CampoAliado->cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            Nodo* aux1 = CementerioAliado->cabeza;
            if (contador < 5)
            {
                CampoAliado->Insertar(aux1->getMonstruo());
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
        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            // termina battle phase
        }
    }
    public unsafe class RobarDestino : TrampasInvocacion
    {
        public RobarDestino()
        {
            setNombre("Agujero Negro");
            setDireccion(Properties.Resources.RobarDestino);
        }
        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {
            Nodo* aux = CementerioAliado->cabeza;
            if (aux != null)
            {
                CampoAliado->Insertar(aux->getMonstruo());
                aux->getMonstruo().setModo(false);
            }
        }
    }
}


