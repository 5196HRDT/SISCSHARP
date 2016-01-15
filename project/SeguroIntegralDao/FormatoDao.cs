using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SeguroIntegral.Entidades;
using Comunes.Datos;
using Comunes.Entidades;
namespace SeguroIntegral.Datos
{

    public class FormatoDao
    {
        private static FormatoDao _instancia;
        private FormatoDao() { }
        public static FormatoDao instancia()
        {
            if (_instancia == null) _instancia = new FormatoDao();
            return _instancia;
        }
        SqlDataReader dr;
        SqlCommand cmd;
        private void cerrar()
        {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }
        public Formato ObtenerFormato(int idFormato)
        {
            Formato objFormato = null;
            try
            {
                cmd = new SqlCommand("sp_FormartoListar");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idformato", idFormato);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.hei = dr["hei"].ToString();
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.Monto = new LineaFormato();
                    objFormato.Monto.Medicamento = (decimal)dr["TMedicamento"];
                    objFormato.Monto.Procedimiento = (decimal)dr["TProcedimiento"];
                    objFormato.Monto.TCobertura = (decimal)dr["TCobertura"];
                    
                    objFormato.Monto.Oxigeno = (decimal)dr["Oxigeno"];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objFormato;
        }


        public Formato ObtenerFormato(string lote, string numero)
        {
            Formato objFormato = null;
            try
            {
                cmd = new SqlCommand("sp_FormatoSisListarNro");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                cmd.Parameters.AddWithValue("@numero", numero);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.hei = dr["hei"].ToString();
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.nombres = dr["Paciente"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objFormato;
        }
        public List<Formato> ListarFormato(string lote, string numero)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_FormatoSisListarNro");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                cmd.Parameters.AddWithValue("@numero", numero);
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.hei = dr["hei"].ToString();
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.nombres = dr["Paciente"].ToString();
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public List<Formato> ConsumoOxigeno(DateTime FechaI, DateTime FechaF)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_ObtenerOxigenoFecha");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.Parameters.AddWithValue("@fechaI", FechaI);
                cmd.Parameters.AddWithValue("@fechaF", FechaF);
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato = null;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objTipoAseguramiento = new TipoAseguramiento();
                    objFormato.objTipoAseguramiento.descripcion = dr["Situacion"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.Monto = new LineaFormato();
                    objFormato.Monto.Total = (decimal)dr["MontoFua"];
                    objFormato.Monto.Oxigeno = (decimal)dr["Oxigeno"];
                    objFormato.Monto.TCobertura = (decimal)dr["Cobertura"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public List<Formato> ConsumoOxigeno(string nroHistoria)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_ObtenerOxigenoHistoria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.Parameters.AddWithValue("@Historia", nroHistoria);                
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato = null;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objTipoAseguramiento = new TipoAseguramiento();
                    objFormato.objTipoAseguramiento.descripcion = dr["Situacion"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.Monto = new LineaFormato();
                    objFormato.Monto.Total = (decimal)dr["MontoFua"];
                    objFormato.Monto.Oxigeno = (decimal)dr["Oxigeno"];
                    objFormato.Monto.TCobertura = (decimal)dr["Cobertura"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public Formato ConsumoOxigeno(Formato objFormato) {
            //Formato objFormato = null;
            try
            {
                cmd = new SqlCommand("sp_ObtenerOxigenoFormato");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.Parameters.AddWithValue("@idSis", objFormato.idFormato);
                dr = cmd.ExecuteReader();  
                if (dr.Read())
                {                    
                    objFormato.Monto.Oxigeno = (decimal)dr["Oxigeno"];                
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objFormato;
        }


        public List<Formato> ConsumoFormatos(DateTime FechaI, DateTime FechaF)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_EstadoCuenta");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandTimeout = 60;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaI", FechaI);
                cmd.Parameters.AddWithValue("@fechaF", FechaF);
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato = null;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objTipoAseguramiento = new TipoAseguramiento();
                    objFormato.objTipoAseguramiento.descripcion = dr["Situacion"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.Monto = new LineaFormato();
                    objFormato.Monto.Total = (decimal)dr["MontoFua"];
                    objFormato.Monto.Oxigeno = 0;
                    objFormato.Monto.TCobertura = (decimal)dr["Cobertura"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public List<Formato> ConsumoFormatos(string nroHistoria)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_EstadoCuentaPaciente");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandTimeout = 60;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@historia", nroHistoria);               
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato = null;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.lote = dr["lote"].ToString();
                    objFormato.numero = dr["numero"].ToString();
                    objFormato.objTipoAseguramiento = new TipoAseguramiento();
                    objFormato.objTipoAseguramiento.descripcion = dr["Situacion"].ToString();
                    objFormato.objPaciente = new Comunes.Entidades.Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.Monto = new LineaFormato();
                    objFormato.Monto.Total = (decimal)dr["MontoFua"];
                    objFormato.Monto.Oxigeno = 0;
                    objFormato.Monto.TCobertura = (decimal)dr["Cobertura"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public List<Formato> ConsumoMedicamentos(DateTime FechaI, DateTime FechaF)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_ConsumoMedicamentosSis");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaInicio", FechaI);
                cmd.Parameters.AddWithValue("@fechaFin", FechaF);
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idsis"];
                    objFormato.lote = dr["Lote"].ToString();
                    objFormato.numero = dr["Numero"].ToString();
                    objFormato.objPaciente = new Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.FechaEmision = (DateTime)dr["FechaAtencion"];
                    objFormato.Monto.Medicamento = (decimal)dr["Medicamentos"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }

        public List<Formato> ConsumoProcedimiento(DateTime FechaI, DateTime FechaF)
        {
            List<Formato> lstFormatos = null;
            try
            {
                cmd = new SqlCommand("sp_ConsumoProcedimientosSis");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaInicio", FechaI);
                cmd.Parameters.AddWithValue("@fechaFin", FechaF);
                dr = cmd.ExecuteReader();
                lstFormatos = new List<Formato>();
                Formato objFormato;
                while (dr.Read())
                {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idsis"];
                    objFormato.lote = dr["LOTE"].ToString();
                    objFormato.numero = dr["Numero"].ToString();
                    objFormato.objPaciente = new Persona();
                    objFormato.objPaciente.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciente.aPaterno = dr["APaterno"].ToString();
                    objFormato.objPaciente.aMaterno = dr["AMaterno"].ToString();
                    objFormato.objPaciente.nombres = dr["Nombres"].ToString();
                    objFormato.FechaEmision = (DateTime)dr["FechaAtencion"];
                    objFormato.Monto.Procedimiento = (decimal)dr["Procedimiento"];
                    lstFormatos.Add(objFormato);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { this.cerrar(); }
            return lstFormatos;
        }




    }
}
