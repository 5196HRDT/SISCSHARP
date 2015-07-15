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
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public char activo { get; set; }
        public string ubigeo { get; set; }
        public DateTime fechaRegistro { get; set; }
        //public TipoDocumento objTipoDocumento { get; set; }
    }
}
