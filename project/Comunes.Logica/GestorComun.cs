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
        public Paciente obtenerPaciente(decimal nroHistoria)
        {
            try
            {
                return PacienteDao.instancia().obtenerPersona(nroHistoria);
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
            
                return UsuarioDao.instancia().validar(iniciales,clave);
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

    }
}
