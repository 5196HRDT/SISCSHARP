using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Entidades
{
    public class Paciente : Persona
    {
        public string nroHistoria { get; set; }
        public Triaje objTriaje { get; set; }
        
    }
}
