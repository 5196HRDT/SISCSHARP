using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comunes.Datos;
using Comunes.Entidades;
namespace Comunes.Dominio
{
    public class GestorComun
    {

        private static GestorComun _instancia;
        private GestorComun() { }
        public static GestorComun instancia()
        {
            if (_instancia == null) _instancia = new GestorComun();
            return _instancia;
        }
        public Persona obtenerPersona(decimal nroHistoria)
        {
            try
            {
                return PersonaDao.instancia().obtenerPersona(nroHistoria);
            }
            catch (Exception e)
            {   
                throw e;
            }            
        }
        public Usuario validadUsuario(string iniciales, string clave)
        {
            try
            {
                return UsuarioDao.instancia().validar(iniciales, clave);

            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
        public List<Cie10> BuscarCie10(string parameto, int operacion) {
            try
            {
                return Cie10Dao.instancia().Buscar(parameto, operacion);
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

    }
}
