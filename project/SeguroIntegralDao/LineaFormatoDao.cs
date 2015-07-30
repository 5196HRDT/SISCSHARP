using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeguroIntegral.Entidades;
using System.Data;
using System.Data.SqlClient;
using Comunes.Datos;

namespace SeguroIntegral.Datos
{
    public class LineaFormatoDao
    {
        private static LineaFormatoDao _instancia;
        private LineaFormatoDao() { }
        public static LineaFormatoDao instancia() {
            if (_instancia == null) _instancia = new LineaFormatoDao();
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
        public LineaFormato EstadoCuentaPaciente(int idsis)
        {
            LineaFormato objLinea = null;
            try
            {
                cmd = new SqlCommand("sp_EstadoCuenta");
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idsis", idsis);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objLinea = new LineaFormato();
                    objLinea.Medicamento = (decimal)dr["Med"];
                    objLinea.Procedimiento = (decimal)dr["Pro"];
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally { this.cerrar(); }
            return objLinea;
        }

    }
}
