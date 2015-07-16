using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Entidades
{
    public class Persona
    {
        public decimal persona { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string nombres { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }        
        public Ubigeo objUbigeoDocumento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string etnia { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool activo { get; set; }
        public string nroHistoria { get; set; }

       
      
    }
}
