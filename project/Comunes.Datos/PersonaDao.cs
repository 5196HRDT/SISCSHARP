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
    public class PersonaDao
    {
        private static PersonaDao _instancia;
        private PersonaDao() { }
        public static  PersonaDao instancia()
        {
            if (_instancia == null) _instancia = new PersonaDao();
            return _instancia;
        }
        protected Persona objPersona;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        public Persona obtenerPersona(decimal historia)
        {
            objPersona = null;
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.CommandText = "PersonaObtener";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@historia",historia);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objPersona = new Persona();
                    objPersona.persona = (decimal)dr["idHistoria"];
                    objPersona.nroHistoria = dr["HClinica"].ToString();
                    objPersona.aPaterno = dr["aPaterno"].ToString();
                    objPersona.aMaterno = dr["aMaterno"].ToString();
                    objPersona.nombres = dr["nombres"].ToString();
                    objPersona.sexo = dr["sexo"].ToString();
                    objPersona.fechaNacimiento = (DateTime)dr["fnacimiento"];
                    
                   // objPersona.activo = (char)dr["activo"];
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
            return objPersona;
        }

    }
}
