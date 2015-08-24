using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobertura.Entidades;
using Cobertura.Datos;
using SeguroIntegral.Datos;
using SeguroIntegral.Entidades;

namespace SeguroIntegral.Dominio
{
    public struct Monto
    {
        public decimal Med;
        public decimal Pro;
    }

    public class GestorSeguroIntegral
    {
        private static GestorSeguroIntegral _instancia;
        private GestorSeguroIntegral() { }

        public static GestorSeguroIntegral instancia()
        {
            if (_instancia == null) _instancia = new GestorSeguroIntegral();
            return _instancia;
        }

        public List<Formato> ListarFormato(string lote, string numero)
        {
            try
            {
                return FormatoDao.instancia().ListarFormato(lote, numero);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        protected FormatoDao objLF = FormatoDao.instancia();
      

        public List<Formato> EstadoCuenta(DateTime FechaI, DateTime FechaF)
        {
            try
            {

                List<Formato> lstCuentas = objLF.ConsumoFormatos(FechaI, FechaF);
                List<Formato> lstOxigeno = objLF.ConsumoOxigeno(FechaI, FechaF);
                if (lstOxigeno.Count > 0)
                {
                    foreach (Formato item in lstOxigeno)
                    {
                        lstCuentas.RemoveAll(p => p.idFormato == item.idFormato);
                    }
                    List<Formato> lsRetorno = lstOxigeno.Union(lstCuentas).ToList();
                    return lsRetorno;
                }
                else return lstCuentas;
                //return lsRetorno.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Formato> EstadoCuenta(string nroHistoria)
        {
            try
            {
                List<Formato> lstCuentas = objLF.ConsumoFormatos(nroHistoria);
                List<Formato> lstOxigeno = objLF.ConsumoOxigeno(nroHistoria);
                if (lstOxigeno.Count > 0) { 
                    foreach (Formato item in lstOxigeno)
                    {
                        lstCuentas.RemoveAll(p => p.idFormato == item.idFormato);
                    }
                    List<Formato> lsRetorno = lstOxigeno.Union(lstCuentas).ToList();
                    return lsRetorno;
                }                
                else return lstCuentas;            
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        

        public Formato ObtenerFormato(int idFormato)
        {
            try
            {
                Formato objFormato = FormatoDao.instancia().ObtenerFormato(idFormato);
              
                return FormatoDao.instancia().ConsumoOxigeno(objFormato);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Formato ObtenerFormato(string lote, string numero)
        {
            try
            {
                
                return FormatoDao.instancia().ObtenerFormato(lote, numero);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GuardarAmpliacion(Ampliaciones objAmpliacion)
        {
            if (objAmpliacion.idAmpliacion == 0)
            {
                if (objAmpliacion.objFormato.idFormato == 0 && (objAmpliacion.fechaSolicitud > objAmpliacion.fechaAprobada)) return 0;
                return AmpliacionDao.instancia().Ingresar(objAmpliacion);
            }
            else
            {
                return AmpliacionDao.instancia().Modificar(objAmpliacion); ;
            }
        }

        public int EliminarAmpliacion(int idCobertura) {
            try
            {
                return AmpliacionDao.instancia().Eliminar(idCobertura);
            }
            catch (Exception e )
            {
                
                throw e;
            }
        }
        public Ampliaciones ObternerAmpliacion(int id)
        {
            try
            {
                return AmpliacionDao.instancia().ObtenerAmpliacion(id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Ampliaciones> ListarAmpliacion(string lote, string numero)
        {
            try
            {
                return AmpliacionDao.instancia().ListarAmpliaciones(lote, numero);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public List<Ampliaciones> ListarAmpliaciones(DateTime FechaI, DateTime FechaF)
        {
            try
            {
                return AmpliacionDao.instancia().ListarAmpliaciones(FechaI, FechaF);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
