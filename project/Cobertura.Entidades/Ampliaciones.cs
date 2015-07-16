using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeguroIntegral.Entidades;
using Comunes.Entidades;
namespace Cobertura.Entidades
{
    public class Ampliaciones
    {
        public int idAmpliacion { get; set; }
        public string codigo { get; set; }
        public Persona objPersona { get; set; }
        public Formato objFormato { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public DateTime fechaAprobada { get; set; }
        public decimal monto { get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }
    }
}
