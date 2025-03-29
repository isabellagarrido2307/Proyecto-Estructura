using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class AlaEscudo : Monstruos
    {
        public AlaEscudo()
        {
            setNombre("Ala Escudo");
            setDireccion(Properties.Resources.AlaEscudo);
            setAtaque(100);
            setDefensa(1000);
            setVidas(2);
            setModo(true);
            if (getModo())
            {
                setSalud(100);
            }
            else
            {
                setSalud(1000);
            }
            setTurnosDeEstado(0);
        }
    }
    public class AlejandroLapiz : Monstruos
    {
        public AlejandroLapiz()
        {
            setNombre("Alejandro Roba Lapices");
            setDireccion(Properties.Resources.AlejandroLapiz);
            setAtaque(1000);
            setDefensa(1000);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(1000);
            }
            else
            {
                setSalud(1000);
            }
            setTurnosDeEstado(0);
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            setAtaque(getAtaque() / 2);
        }
    }
    public unsafe class Alfonsina : Monstruos
    {
        public Alfonsina()
        {
            setNombre("Alfonsina Peluche");
            setDireccion(Properties.Resources.Alfonsina);
            setAtaque(1000);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(1000);
            }
            else
            {
                setSalud(1200);
            }
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            ListaMonstruos* aux = CampoAliado;
            while (aux->cabeza != null)
            {
                if (aux->cabeza->getMonstruo().getNombre() == "Aymara Reina Peluche")
                {
                    this.setAtaque(2000);
                    this.setDefensa(2200);
                    return;
                }
                aux->cabeza = aux->cabeza->getSiguiente();
            }
        }
    }
    public class AndresAbsoluto : Monstruos
    {
        public AndresAbsoluto()
        {
            setNombre("Andres el Absoluto");
            setDireccion(Properties.Resources.AndresAbsoluto);
            setAtaque(0);
            setDefensa(0);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(0);
            }
            else
            {
                setSalud(0);
            }

        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(0);
                aux->getMonstruo().setDefensa(0);
                aux = aux->getSiguiente();
            }
        }

    }
    public class AngelIntegral : Monstruos
    {
        public AngelIntegral()
        {
            setNombre("Angel Hombre Integral");
            setDireccion(Properties.Resources.AngelIntegral);
            setAtaque(2000);
            setDefensa(2000);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            this.setAtaque(getAtaque() + 100);
        }
    }
    public class AymaraPeluche : Monstruos
    {
        public AymaraPeluche()
        {
            setNombre("Aymara Reina Peluche");
            setDireccion(Properties.Resources.AymaraPeluche);
            setAtaque(1700);
            setDefensa(1300);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            if (contador <= 6)
            {
                CampoAliado->Insertar(new Alfonsina());
            }
        }
    }
    public class CaballeroOscuro : Monstruos
    {
        public CaballeroOscuro()
        {
            setNombre("Caballero Oscuro");
            setDireccion(Properties.Resources.CaballeroOscuro);
            setAtaque(1800);
            setDefensa(1600);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {

        }
    }
    public unsafe class ChacinDomino : Monstruos
    {
        public ChacinDomino()
        {
            setNombre("Chacin Domino");
            setDireccion(Properties.Resources.ChacinDomino);
            setAtaque(1600);
            setDefensa(1400);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo)
        {
            ListaMonstruos* aux = CampoEnemigo;
            while (aux->cabeza != null)
            {
                if (aux->cabeza->getMonstruo().getAtaque() < this.getAtaque())
                {
                    CementerioEnemigo->Insertar(aux->cabeza->getMonstruo());
                    CampoEnemigo->Eliminar(aux->cabeza->getMonstruo());
                }
            }
        }
    }
    public unsafe class DragonFuego : Monstruos
    {
        public DragonFuego()
        {
            setNombre("Dragon de Fuego");
            setDireccion(Properties.Resources.DragonFuego);
            setAtaque(2500);
            setDefensa(2000);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            if (CartaAtacar->getDefensa() < 1500)
            {
                CampoEnemigo->Eliminar(*CartaAtacar);
            }
        }
    }
    public unsafe class FamiliaUnida : Monstruos
    {
        public FamiliaUnida()
        {
            setNombre("Familia Ingeniera Unida");
            setDireccion(Properties.Resources.FamiliaUnida);
            setAtaque(99999);
            setDefensa(99999);
            setVidas(1);
            setModo(true);
            setSalud(99999);
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(9999);
                aux->getMonstruo().setDefensa(9999);
                aux = aux->getSiguiente();
            }
        }
    }
    public unsafe class GabrielConductor : Monstruos
    {
        public GabrielConductor()
        {
            setNombre("Gabriel Experto Conductor");
            setDireccion(Properties.Resources.GabrielExperto);
            setAtaque(1500);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            setAtaque(getAtaque() + 100);
        }
    }
    public unsafe class GinoPeloCotufa : Monstruos
    {
        public GinoPeloCotufa()
        {
            setNombre("Gino Pelo e Cotufa");
            setDireccion(Properties.Resources.GinoPeloCotufa);
            setAtaque(1700);
            setDefensa(1300);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            setAtaque(getAtaque() + contador * 100);
        }
    }
    public unsafe class GuerreroRelampago : Monstruos
    {
        public GuerreroRelampago()
        {
            setNombre("Guerrero Relampago");
            setDireccion(Properties.Resources.GuerreroRelampago);
            setAtaque(1900);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(aux->getMonstruo().getAtaque() + 100);
                aux = aux->getSiguiente();
            }
        }
    }
    public unsafe class Imitador : Monstruos
    {
        public Imitador()
        {
            setNombre("Imitador");
            setDireccion(Properties.Resources.Imitador);
            setAtaque(0);
            setDefensa(0);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            int defensa = 0;
            int ataque = 0;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < ataque)
                {
                    ataque = aux->getMonstruo().getAtaque();
                }
                if (aux->getMonstruo().getDefensa() < defensa)
                {
                    defensa = aux->getMonstruo().getDefensa();
                }
                aux = aux->getSiguiente();
            }
            setDefensa(defensa);
            setAtaque(ataque);
        }
    }
    public unsafe class Isabella : Monstruos
    {
        public Isabella()
        {
            setNombre("Isabella Fan Gatuna");
            setDireccion(Properties.Resources.IsabellaGatos);
            setAtaque(1300);
            setDefensa(1600);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(getAtaque() - 400);
                aux->getMonstruo().setDefensa(getDefensa() - 400);
                aux = aux->getSiguiente();
            }
        }
    }
    public unsafe class Kuriboh : Monstruos
    {
        public Kuriboh(bool _modo)
        {
            setNombre("Kuriboh");
            setDireccion(Properties.Resources.Kuriboh);
            setAtaque(500);
            setDefensa(500);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            ListaMonstruos* aux = CampoAliado;
            while (aux->cabeza != null)
            {
                aux->cabeza->getMonstruo().setDefensa(getDefensa() + 200);

            }
        }
    }

    public unsafe class KuribohAlado : Monstruos
    {
        public KuribohAlado(bool _modo)
        {
            setNombre("Kuriboh Alado");
            setDireccion(Properties.Resources.KuribohAlado);
            setAtaque(500);
            setDefensa(500);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            ListaMonstruos* aux = CampoAliado;
            while (aux->cabeza != null)
            {
                aux->cabeza->getMonstruo().setDefensa(getDefensa() + 200);

            }
        }
    }
    public unsafe class LadronFantasma : Monstruos
    {
        public LadronFantasma(bool _modo)
        {
            setNombre("Ladron Fantasma");
            setDireccion(Properties.Resources.LadronFantasma);
            setAtaque(1600);
            setDefensa(1400);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {

        }
    }

    public unsafe class MagoSombrio : Monstruos
    {
        public MagoSombrio(bool _modo)
        {
            setNombre("Mago Sombrio");
            setDireccion(Properties.Resources.MagoSombrio);
            setAtaque(1700);
            setDefensa(1300);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {

        }
    }

    public unsafe class MiguelMondaquera : Monstruos
    {
        public MiguelMondaquera(bool _modo)
        {
            setNombre("Miguel Mondaquera");
            setDireccion(Properties.Resources.MiguelMondaquera);
            setAtaque(1600);
            setDefensa(1700);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {

        }
    }

    public unsafe class PollueloSonico : Monstruos
    {
        public PollueloSonico(bool _modo)
        {
            setNombre("Polluelo Sonico");
            setDireccion(Properties.Resources.PollueloSonico);
            setAtaque(900);
            setDefensa(900);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            if (CartaAtacar->getAtaque() > 1900)
            {
                CartaAtacar->setVidas(0);
            }
        }
    }

    public unsafe class RataBlindada : Monstruos
    {
        public RataBlindada(bool _modo)
        {
            setNombre("Rata Blindada");
            setDireccion(Properties.Resources.RataBlindada);
            setAtaque(500);
            setDefensa(2000);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            setDefensa(getDefensa() - 500);
        }
    }

    public unsafe class RoedorMalicioso : Monstruos
    {
        public RoedorMalicioso(bool _modo)
        {
            setNombre("Roedor Malicioso");
            setDireccion(Properties.Resources.RoedorMalicioso);
            setAtaque(1400);
            setDefensa(1200);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {

        }
    }

    public unsafe class RompeEscudos : Monstruos
    {
        public RompeEscudos(bool _modo)
        {
            setNombre("Rompe escudos");
            setDireccion(Properties.Resources.RompeEscudos);
            setAtaque(1000);
            setDefensa(800);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            if (CartaAtacar->getModo() == false)
            {
                setAtaque(getAtaque() * 2);
            }

        }
    }
    public unsafe class SebastianGacha : Monstruos
    {
        public SebastianGacha(bool _modo)
        {
            setNombre("Sebas el señor del gacha");
            setDireccion(Properties.Resources.SebastianGacha);
            setAtaque(1200);
            setDefensa(1300);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            Random random = new Random();
            int gacha = random.Next(1, 2);

            if (gacha == 1)
            {
                setAtaque(getAtaque() * 2);
            }
        }
    }
    public unsafe class SergioEmbaucador : Monstruos
    {
        public SergioEmbaucador(bool _modo)
        {
            setNombre("Sergio el Embaucador");
            setDireccion(Properties.Resources.SergioEmbaucador);
            setAtaque(1500);
            setDefensa(1500);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            if (CartaAtacar->getAtaque() < CartaAtacar->getDefensa())
            {
                CartaAtacar->setModo(true);
            }
            else
            {
                CartaAtacar->setModo(false);
            }
        }
    }
    public unsafe class SliferCielo : Monstruos
    {
        public SliferCielo(bool _modo)
        {
            setNombre("Slifer señor del cielo");
            setDireccion(Properties.Resources.SliferCielo);
            setAtaque(0);
            setDefensa(0);
            setModo(true);
            setSalud(0);
            setTurnosDeEstado(0);
            setVidas(1);
        }
        public void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            ListaMonstruos* aux = CampoAliado;
            Nodo* aux1 = CampoAliado->cabeza;
            int contador = 0;
            while (aux1 != null)
            {
                contador++;
                aux1 = aux1->getSiguiente();
            }
            setAtaque(contador * 1000);
            setDefensa(contador * 1000);
        }
    }
}
