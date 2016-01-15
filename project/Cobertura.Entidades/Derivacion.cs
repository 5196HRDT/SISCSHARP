using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comunes.Entidades;
namespace Cobertura.Entidades
{
    public class Derivacion
    {
        public int idDerivacion { get; set; }
        public Persona objPaciente { get; set; }
        public Cie10 objCie10 { get; set; }
        public Especialidad objEspecialidad { get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }

    }
}
