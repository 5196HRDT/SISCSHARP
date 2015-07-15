using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comunes.Utilitarios
{
    public class Singleton
    {
        private static Singleton _instancia;
        public Singleton() { }
        public static Singleton instancia() { 
            if (_instancia ==null) _instancia = new Singleton();
            return _instancia;
        }
    }
}
