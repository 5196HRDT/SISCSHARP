using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comunes.Utilitarios
{
    public class Variables
    {
        private static Variables _instancia;
        private Variables() { }
        public static Variables instancia() {
            if (_instancia == null) _instancia = new Variables();
            return _instancia;
        }
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string usuario { get; set; }

        public string mensaje { get; set; }

    }
}
