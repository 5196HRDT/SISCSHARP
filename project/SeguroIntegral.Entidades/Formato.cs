using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comunes.Entidades;
namespace SeguroIntegral.Entidades
{
    public class Formato 
    {

        public int idFormato { get; set; }
        public string hei { get; set; }
        public string lote { get; set; }
        public string numero { get; set; }
        public string disaHEI { get; set; }
        public TipoAfiliacion objTipoAfiliacion { get; set; }
        public  TipoAseguramiento objTipoAseguramiento { get; set; }
        public CentroSalud objCentroSalud { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public Persona objPaciete { get; set; }
        
    }
}
