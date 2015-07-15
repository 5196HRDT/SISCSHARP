using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comunes.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Comunes.Datos
{
    public class UsuarioDao
    {
        private static UsuarioDao _instancia;
        private UsuarioDao() { }
      
        public static UsuarioDao instancia()
        {
            if (_instancia == null) _instancia = new UsuarioDao();
            return _instancia;
        }

        protected SqlCommand cmd;
        protected SqlDataReader dr;
        
        
        public Usuario validar(string iniciales, string clave)
        {
            Usuario objUsuario=null;
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandText = "UsuarioValidarpa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inciales", iniciales);
                cmd.Parameters.AddWithValue("@clave", clave);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.inciales = dr["iniciales"].ToString();
                    objUsuario.nombres = dr["nombres"].ToString();
                }
            }
            catch (Exception e)
            {
                 throw e;
            }
            finally {
                this.cerrar();
            }

            return objUsuario;
        }
        private void cerrar()
        {
            dr.Close();
            cmd.Dispose();
            cmd.Connection.Close();
        }
        
    }
}
