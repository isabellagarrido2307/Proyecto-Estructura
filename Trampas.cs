using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{ 
    public class TrampasAtaque
    {
        private string nombre { get; set; }
        private Image direccion { get; set; }

        public unsafe TrampasAtaque()
        {

        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDireccion(Image _direccion)
        {
            direccion = _direccion;
        }
        public Image getDireccion()
        {
            return direccion;
        }
        virtual public unsafe bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
            return true;
        }
        virtual public unsafe void efectoBatalla(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos cartaAtacante)
        {
    
        }
    }

    public class TrampasInvocacion
    {
        private string nombre { get; set; }
        private Image direccion { get; set; }


        public unsafe TrampasInvocacion()
        {

        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDireccion(Image _direccion)
        {
            direccion = _direccion;
        }
        public Image getDireccion()
        {
            return direccion;
        }
        virtual public bool condicional(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {
            return false;
        }
        virtual public unsafe void efectoInvocacion(Jugador jugadorAliado, Jugador jugadorEnemigo, Monstruos CartaInvocada)
        {

        }
    }
}