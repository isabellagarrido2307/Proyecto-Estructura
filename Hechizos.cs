using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Hechizos
    {
        private string nombre;
        private Image direccion;
        public Hechizos()
        {
            nombre = "";
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
        virtual public void activarEfecto(Jugador jugadorAliado, Jugador jugadorEnemigo)
        {

        }
    }
}
