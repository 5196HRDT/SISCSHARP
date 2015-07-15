using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Comunes.Datos
{
    public class PacienteDao
    {
        private static PacienteDao _instancia;
        private PacienteDao() { }
        public static  PacienteDao instancia()
        {
            if (_instancia == null) _instancia = new PacienteDao();
            return _instancia;
        }
        protected Paciente objPaciente;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        public Paciente obtenerPersona(decimal historia)
        {
            objPaciente = null;
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandText = "PacienteObtener";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@historia",historia);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objPaciente = new Paciente();
                    objPaciente.persona = (decimal)dr["idHistoria"];
                    objPaciente.nroHistoria = dr["HClinica"].ToString();
                    objPaciente.aPaterno = dr["aPaterno"].ToString();
                    objPaciente.aMaterno = dr["aMaterno"].ToString();
                    objPaciente.nombres = dr["nombres"].ToString();
                    objPaciente.sexo = dr["sexo"].ToString();
                    objPaciente.fechaNacimiento = (DateTime)dr["fnacimiento"];
                    objPaciente.ubigeo = dr["ubigeo"].ToString();
                    objPaciente.departamento = dr["departamento"].ToString();
                    objPaciente.provincia = dr["provincia"].ToString();
                    objPaciente.distrito = dr["distrito"].ToString();
                   // objPaciente.activo = (char)dr["activo"];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                cmd.Connection.Dispose();
                dr.Dispose();
            }
            return objPaciente;
        }

    }
}
