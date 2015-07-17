using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SeguroIntegral.Entidades;
using Comunes.Datos;
namespace SeguroIntegral.Datos
{

    public class FormatoDao
    {
        
        private static FormatoDao _instancia;
        private FormatoDao() { }
        public static FormatoDao instancia() {
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
        public Formato ObtenerFormato(string lote, string numero) {
            Formato objFormato = null;
            try
            {
                cmd = new SqlCommand("sp_FormatoSisListarNro");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                cmd.Parameters.AddWithValue("@numero", numero);
                dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.numero = dr["Formato"].ToString();
                    objFormato.objPaciete = new Comunes.Entidades.Persona();
                    objFormato.objPaciete.nroHistoria = dr["Historia"].ToString();
                    objFormato.objPaciete.nombres = dr["Paciente"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objFormato;
        }
        public List<Formato> ListarFormato(string lote, string numero) {
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
                Formato objFormato ;
                while (dr.Read()) {
                    objFormato = new Formato();
                    objFormato.idFormato = (int)dr["idSis"];
                    objFormato.numero = dr["Formato"].ToString();
                    objFormato.objPaciete = new Comunes.Entidades.Persona();
                    objFormato.objPaciete.nombres = dr["Paciente"].ToString();
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

    }
}
