using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sepelio.Entidades;
using System.Data;
using System.Data.SqlClient;
using Comunes.Datos;
namespace Sepelio.Datos
{
    public class FunerariaDao
    {
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion cn = Conexion.instancia();
        private static FunerariaDao _instancia;
        private FunerariaDao() { }
        public static FunerariaDao instancia()
        {
            if (_instancia == null) _instancia = new FunerariaDao();
            return _instancia;
        }

        private void cerrar()
        {
            cmd.Connection.Close();
            dr.Close();
            cmd.Dispose();
        }
        public Funeraria obtener(int id)
        {
            Funeraria objFuneraria = null;
            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", id);
                    cmd.Parameters.AddWithValue("@nombre", "");
                    cmd.Parameters.AddWithValue("@telefono", "");
                    cmd.Parameters.AddWithValue("@ruc", "");
                    cmd.Parameters.AddWithValue("@activo", true);
                    cmd.Parameters.AddWithValue("@op", 4);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        objFuneraria = new Funeraria();
                        objFuneraria.idFuneraria = (int)dr["IDFUNERARIA"];
                        objFuneraria.nombre = dr["NOMBRE"].ToString();
                        objFuneraria.telefono = dr["TELEFONO"].ToString();
                        objFuneraria.activo = (bool)dr["ACTIVO"];
                        objFuneraria.ruc = dr["RUC"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return objFuneraria;
        }

        public List<Funeraria> listar()
        {
            List<Funeraria> lstFuneraria = null;
            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", 0);
                    cmd.Parameters.AddWithValue("@nombre", "");
                    cmd.Parameters.AddWithValue("@telefono", "");
                    cmd.Parameters.AddWithValue("@ruc", "");
                    cmd.Parameters.AddWithValue("@activo", true);
                    cmd.Parameters.AddWithValue("@op", 4);
                    Funeraria objFuneraria = null;
                    dr = cmd.ExecuteReader();
                    lstFuneraria = new List<Funeraria>();
                    while (dr.Read())
                    {
                        objFuneraria = new Funeraria();
                        objFuneraria.idFuneraria = (int)dr["IDFUNERARIA"];
                        objFuneraria.nombre = dr["NOMBRE"].ToString();
                        objFuneraria.telefono = dr["TELEFONO"].ToString();
                        objFuneraria.activo = (bool)dr["ACTIVO"];
                        objFuneraria.ruc = dr["RUC"].ToString();
                        lstFuneraria.Add(objFuneraria);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFuneraria;
        }

        public List<Funeraria> listar(string parametro)
        {
            List<Funeraria> lstFuneraria = null;
            bool flag; long x;
            flag = long.TryParse(parametro, out x);

            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", 0);
                    cmd.Parameters.AddWithValue("@telefono", "");
                    if (flag == true)
                    {
                        cmd.Parameters.AddWithValue("@nombre", "");
                        cmd.Parameters.AddWithValue("@ruc", parametro);
                        cmd.Parameters.AddWithValue("@activo", true);
                        cmd.Parameters.AddWithValue("@op", 5);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@nombre", parametro);
                        cmd.Parameters.AddWithValue("@ruc", "");
                        cmd.Parameters.AddWithValue("@activo", true);
                        cmd.Parameters.AddWithValue("@op", 6);
                    }
                    Funeraria objFuneraria = null;
                    dr = cmd.ExecuteReader();
                    lstFuneraria = new List<Funeraria>();
                    while (dr.Read())
                    {
                        objFuneraria = new Funeraria();
                        objFuneraria.idFuneraria = (int)dr["IDFUNERARIA"];
                        objFuneraria.nombre = dr["NOMBRE"].ToString();
                        objFuneraria.telefono = dr["TELEFONO"].ToString();
                        objFuneraria.activo = (bool)dr["ACTIVO"];
                        objFuneraria.ruc = dr["RUC"].ToString();
                        lstFuneraria.Add(objFuneraria);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.cerrar(); }
            return lstFuneraria;
        }

        public int Ingresar(Funeraria objFuneraria)
        {
            int retorno = 0;
            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", objFuneraria.idFuneraria);
                    cmd.Parameters.AddWithValue("@nombre", objFuneraria.nombre);
                    cmd.Parameters.AddWithValue("@telefono", objFuneraria.telefono);
                    cmd.Parameters.AddWithValue("@ruc", objFuneraria.ruc);
                    cmd.Parameters.AddWithValue("@activo", true);
                    cmd.Parameters.AddWithValue("@op", 1);
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return retorno;
        }

        public int Modificar(Funeraria objFuneraria)
        {
            int retorno = 0;
            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", objFuneraria.idFuneraria);
                    cmd.Parameters.AddWithValue("@nombre", objFuneraria.nombre);
                    cmd.Parameters.AddWithValue("@telefono", objFuneraria.telefono);
                    cmd.Parameters.AddWithValue("@ruc", objFuneraria.ruc);
                    cmd.Parameters.AddWithValue("@activo", true);
                    cmd.Parameters.AddWithValue("@op", 2);
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return retorno;
        }

        public int Eliminar(bool activo, int id)
        {
            int retorno = 0;
            try
            {
                cmd = new SqlCommand("FunerariaMantenedor");
                cmd.CommandType = CommandType.StoredProcedure;
                using (cmd.Connection = cn.obtenerConexion())
                {
                    cmd.Parameters.AddWithValue("@idfuneraria", id);
                    cmd.Parameters.AddWithValue("@nombre", "");
                    cmd.Parameters.AddWithValue("@telefono", "");
                    cmd.Parameters.AddWithValue("@ruc", "");
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@op", 3);
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }
    }
}
