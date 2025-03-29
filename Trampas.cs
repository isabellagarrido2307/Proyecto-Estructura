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
        private string direccion { get; set; }

        public unsafe TrampasAtaque()
        {

        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDireccion(string _direccion)
        {
            direccion = _direccion;
        }

        public unsafe void efectoBatalla(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {

        }
    }

    public class TrampasInvocacion
    {
        private string nombre { get; set; }
        private string direccion { get; set; }


        public unsafe TrampasInvocacion()
        {

        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDireccion(string _direccion)
        {
            direccion = _direccion;
        }

        public unsafe void efectoInvocacion(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioEnemigo, ListaMonstruos* CementerioAliado)
        {

        }
    }
}