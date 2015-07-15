using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Comunes.Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Comunes.Datos
{
    public class Cie10Dao
    {
        private static Cie10Dao _instancia;
        private Cie10Dao() { }
        public static Cie10Dao instancia()
        {
            if (_instancia == null)
                _instancia = new Cie10Dao();
            return _instancia;
        }
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        public List<Cie10> buscar(string parametro, int operacion )
        {
            List<Cie10> lstCie10 = null;
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "CIE10_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Conexion.instancia().obtenerConexion();
                cmd.Parameters.AddWithValue("@Valor", parametro);
                cmd.Parameters.AddWithValue("@Oper", operacion);
                dr = cmd.ExecuteReader();
                Cie10 objCie10 = null;
                while (dr.Read()) {
                    objCie10 = new Cie10();
                    objCie10.idCie10 = (int)dr["idCie10"];
                    objCie10.codigo = dr["codigo"].ToString();
                    objCie10.descripcion = dr["descripcion"].ToString();
                    objCie10.clase1 = dr["clase1"].ToString();
                    objCie10.clase2 = dr["clase2"].ToString();
                    objCie10.edadMinima = (int)dr["MinEdad"];
                    objCie10.edadMaxima=(int)dr["MaxEdad"];
                    lstCie10.Add(objCie10);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally {
                this.cerrar();
            }
            return lstCie10;
        }
        private void cerrar() {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }

    }
}
