using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comunes.Entidades
{
    public class CentroSalud
    {
        public int idCentroSalud { get; set; }
        public string nombres { get; set; }
        public string categoria { get; set; }
        public Ubigeo objUbigeo { get; set; }

    }
}
