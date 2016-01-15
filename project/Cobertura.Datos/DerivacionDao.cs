using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobertura.Entidades;
using Comunes.Datos;
using System.Data;
using System.Data.SqlClient;
using SeguroIntegral.Entidades;
using Comunes.Entidades;
namespace Cobertura.Datos
{
    public class DerivacionDao
    {
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = Conexion.instancia();
        private static DerivacionDao _instancia;
        private DerivacionDao() { }
        public static DerivacionDao instancia()
        {
            if (_instancia == null) _instancia = new DerivacionDao();
            return _instancia;
        }
        private void cerrar()
        {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }
        public Derivacion ObtenerDerivacion(int id) {
            Derivacion objDerivacion = null;
            try
            {
                cmd = new SqlCommand("DerivacionListar");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion()) {
                    cmd.Parameters.Add("@IdDerivacion", id);
                    dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        objDerivacion = new Derivacion();
                        objDerivacion.idDerivacion = (int)dr["IdDerivacion"];
                        objDerivacion.objCie10=Cie10Dao.instancia().Obtener((int)dr["idCie10"]);                 
                    }
                }
            }
            catch (Exception)
            {   
                throw;
            }
            finally { this.cerrar(); }

            return objDerivacion;
        }
    }
}
