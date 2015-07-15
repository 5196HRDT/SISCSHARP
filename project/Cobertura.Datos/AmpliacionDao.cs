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
    public class AmpliacionDao
    {
        private static AmpliacionDao _instancia;
        private AmpliacionDao() { }
        public static AmpliacionDao instancia() {
            if (_instancia==null)_instancia = new AmpliacionDao();
            return _instancia;
        }
        SqlCommand cmd;
        SqlDataReader dr;
        private void cerrar()
        {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }
        public List<Ampliaciones> ListarAmpliaciones(string Formato) {
            List<Ampliaciones> lstAmpliaciones = null;
            try
            {
                cmd = new SqlCommand("sp_CoberturaListar");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFormato", Formato);
                dr = cmd.ExecuteReader();
                Ampliaciones objAmpliacion=null;
                lstAmpliaciones = new List<Ampliaciones>();
                while (dr.Read()) { 
                    objAmpliacion= new Ampliaciones();
                    objAmpliacion.idAmpliacion = (int)dr["IdCobertura"];
                    objAmpliacion.codigo = dr["codigo"].ToString();
                    objAmpliacion.fechaSolicitud = (DateTime) dr["FechaSolicitud"];
                    objAmpliacion.fechaAprobada = (DateTime)dr["FechaAprobada"];
                    objAmpliacion.monto = (Double)dr["MontoAutorizado"];
                    objAmpliacion.observacion = dr["Diagnosticos"].ToString();
                    lstAmpliaciones.Add(objAmpliacion);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstAmpliaciones;

        }
    }
}
