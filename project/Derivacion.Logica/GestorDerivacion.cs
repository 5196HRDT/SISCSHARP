using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Datos;
using Comunes.Entidades;

namespace Derivacion.Dominio
{
    public class GestorDerivacion
    {
        private static GestorDerivacion _instancia;
        private GestorDerivacion() { }
        public static  GestorDerivacion instancia() {
            if (_instancia == null) _instancia = new GestorDerivacion();
            return _instancia;
        }
     

       
    }
}
