using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobertura.Datos;
using Cobertura.Entidades;

namespace Cobertura.Dominio
{
    public class GestorCobertura
    {
        private static GestorCobertura _instancia;
        
        private GestorCobertura()  { }
        public static GestorCobertura instancia() {
            if (_instancia == null) _instancia = new GestorCobertura();
            return _instancia;
        }

       

    }
}
