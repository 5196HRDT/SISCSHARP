using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string inciales { get; set; }
        public string nombres { get; set; }
        public string clave { get; set; }
        public string nivel { get; set; }
        public char activo { get; set; }
        public char inicial { get; set; }

    }
}
