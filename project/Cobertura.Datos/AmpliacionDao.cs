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
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = Conexion.instancia();
        private static AmpliacionDao _instancia;
        private AmpliacionDao() { }
        public static AmpliacionDao instancia() {
            if (_instancia==null)_instancia = new AmpliacionDao();
            return _instancia;
        }
        private void cerrar()
        {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }
        public Ampliaciones ObtenerAmpliacion(int id)
        {
            Ampliaciones objAmpliacion = null;
            try
            {
                cmd = new SqlCommand("sp_CoberturaListar");
                cmd.Connection = cn.obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCobertura", id);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objAmpliacion = new Ampliaciones();
                    objAmpliacion.idAmpliacion = (int)dr["IdCobertura"];
                    objAmpliacion.codigo = dr["codigo"].ToString();
                    objAmpliacion.fechaSolicitud = (DateTime)dr["FechaSolicitud"];
                    objAmpliacion.fechaAprobada = (DateTime)dr["FechaAprobada"];
                    objAmpliacion.monto = (decimal)dr["MontoAutorizado"];
                    objAmpliacion.observacion = dr["Diagnosticos"].ToString();                   
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objAmpliacion;
        }
        public List<Ampliaciones> ListarAmpliaciones(string lote, string numero) {
            List<Ampliaciones> lstAmpliaciones = null;
            try
            {
                cmd = new SqlCommand("sp_CoberturaListarNro");
                cmd.Connection = cn.obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                cmd.Parameters.AddWithValue("@numero", numero);
                dr = cmd.ExecuteReader();
                Ampliaciones objAmpliacion=null;
                lstAmpliaciones = new List<Ampliaciones>();
                while (dr.Read()) { 
                    objAmpliacion= new Ampliaciones();
                    objAmpliacion.idAmpliacion = (int)dr["IdCobertura"];
                    objAmpliacion.codigo = dr["codigo"].ToString();
                    objAmpliacion.objFormato = new SeguroIntegral.Entidades.Formato();
                    objAmpliacion.objFormato.idFormato = (int)dr["idSis"];                    
                    objAmpliacion.objFormato.numero =  dr["lote"].ToString() + '-'+ dr["numero"].ToString();
                    objAmpliacion.objPersona = new Persona();
                    objAmpliacion.objPersona.nombres = dr["Paciente"].ToString();
                    objAmpliacion.fechaSolicitud = (DateTime) dr["FechaSolicitud"];
                    objAmpliacion.fechaAprobada = (DateTime)dr["FechaAprobada"];
                    objAmpliacion.monto = (decimal)dr["MontoAutorizado"];
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
        public List<Ampliaciones> ListarAmpliaciones(DateTime FechaI, DateTime FechaF)
        {
            List<Ampliaciones> lstAmpliaciones = null;
            try
            {
                cmd = new SqlCommand("sp_CoberturaListarFecha");
                cmd.Connection = cn.obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaI", FechaI);
                cmd.Parameters.AddWithValue("@fechaF", FechaF);
                dr = cmd.ExecuteReader();
                Ampliaciones objAmpliacion = null;
                lstAmpliaciones = new List<Ampliaciones>();
                while (dr.Read())
                {
                    objAmpliacion = new Ampliaciones();
                    objAmpliacion.idAmpliacion = (int)dr["IdCobertura"];
                    objAmpliacion.codigo = dr["codigo"].ToString();
                    objAmpliacion.objFormato = new SeguroIntegral.Entidades.Formato();
                    objAmpliacion.objFormato.idFormato = (int)dr["idSis"];
                    objAmpliacion.objFormato.numero = dr["lote"].ToString() + '-' + dr["numero"].ToString();
                    objAmpliacion.objPersona = new Persona();
                    objAmpliacion.objPersona.nombres = dr["Paciente"].ToString();
                    objAmpliacion.fechaSolicitud = (DateTime)dr["FechaSolicitud"];
                    objAmpliacion.fechaAprobada = (DateTime)dr["FechaAprobada"];
                    objAmpliacion.monto = (decimal)dr["MontoAutorizado"];
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

        public List<Ampliaciones> EstadoCuentaPaciente(DateTime FechaI, DateTime FechaF) {
            List<Ampliaciones> lstAmpliaciones = null;
            try
            {
                cmd = new SqlCommand("sp_AltoCostoFill");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaInicio", FechaI);
                cmd.Parameters.AddWithValue("@fechaFin", FechaF);
                dr = cmd.ExecuteReader();
                lstAmpliaciones = new List<Ampliaciones>();
                Ampliaciones objAmpiacion;
                while (dr.Read()) {
                    objAmpiacion = new Ampliaciones();
                    objAmpiacion.objFormato = new Formato();
                    objAmpiacion.objFormato.numero = dr["Formato"].ToString();
                    objAmpiacion.objFormato.hei = dr["Afiliado"].ToString();
                    objAmpiacion.objFormato.montoMedicamento = (decimal)dr["montoFua"];
                    objAmpiacion.objPersona = new Persona();
                    objAmpiacion.objPersona.nroHistoria = dr["Historia"].ToString();
                    objAmpiacion.objPersona.nombres = dr["Paciente"].ToString();                   
                    lstAmpliaciones.Add(objAmpiacion);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally { this.cerrar(); }
            return lstAmpliaciones;
        }

        public int Ingresar(Ampliaciones objAmplicacion) {
            int retorno = 0;
            try
            {
                cmd = new SqlCommand("sp_CoberturaIngresar");
                cmd.Connection = cn.obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSis", objAmplicacion.objFormato.idFormato);
                cmd.Parameters.AddWithValue("@codigo", objAmplicacion.codigo);
                cmd.Parameters.AddWithValue("@fechaSolicitud", objAmplicacion.fechaSolicitud);
                cmd.Parameters.AddWithValue("@fechaAprobado", objAmplicacion.fechaAprobada);
                cmd.Parameters.AddWithValue("@monto", objAmplicacion.monto);
                cmd.Parameters.AddWithValue("@Diagnosticos", objAmplicacion.observacion);
                retorno = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return retorno;
        }

        public int Modificar(Ampliaciones objAmplicacion)
        {
            int retorno = 0;
            try
            {
                cmd = new SqlCommand("sp_CoberturaModificar");
                cmd.Connection = cn.obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCobertura", objAmplicacion.idAmpliacion);
                cmd.Parameters.AddWithValue("@idSis", objAmplicacion.objFormato.idFormato);
                cmd.Parameters.AddWithValue("@codigo", objAmplicacion.codigo);
                cmd.Parameters.AddWithValue("@fechaSolicitud", objAmplicacion.fechaSolicitud);
                cmd.Parameters.AddWithValue("@fechaAprobado", objAmplicacion.fechaAprobada);
                cmd.Parameters.AddWithValue("@monto", objAmplicacion.monto);
                cmd.Parameters.AddWithValue("@Diagnosticos", objAmplicacion.observacion);
                retorno = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return retorno;
        }
        
    }
}
