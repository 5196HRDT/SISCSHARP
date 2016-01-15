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
        private SqlCommand cmd;
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
                
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return con;
        }
        // EN PRUEBA
        public int EjecutaSp(string procedimiento, string[] Parametros, object obj) { 
            int retorno=0;
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = procedimiento;
                foreach (string p in Parametros) { 
                    
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
            return retorno;
        }
        
    }
}
