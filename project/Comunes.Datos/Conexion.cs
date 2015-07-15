using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Comunes.Datos
{
    public class Conexion
    {
        private static Conexion _instancia;
        private static SqlConnection con;        
        private Conexion() { }
        public  static Conexion instancia() {
            if (_instancia == null)
                _instancia = new Conexion();
            return _instancia;
        }
        public  SqlConnection obtenerConexion() {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection();
                }
                con.ConnectionString = "Server=ServidorSQL;database=dbCaja;UID=sa; password=hrdt2003; Connection Timeout=30";
                //con.ConnectionString = "Server=.;database=dbCaja;integrated security=true";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return con;
        }

        
    }
}
