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
    public class GestorSeguroIntegral
    {
        private static GestorSeguroIntegral _instancia;
        private GestorSeguroIntegral() { }
        public static GestorSeguroIntegral instancia() {
            if (_instancia == null) _instancia = new GestorSeguroIntegral();
            return _instancia;
        }
        public List<Formato>ListarFormato(string lote, string numero) {
            try
            {
                return FormatoDao.instancia().ListarFormato(lote,numero);
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
                return FormatoDao.instancia().ObtenerFormato(idFormato);
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
                if (objAmpliacion.objFormato.idFormato == 0 && (objAmpliacion.fechaSolicitud> objAmpliacion.fechaSolicitud)) return 0;
                return AmpliacionDao.instancia().Ingresar(objAmpliacion);
            }
            else {
                return AmpliacionDao.instancia().Modificar(objAmpliacion); ;
            }
        } 

        public Ampliaciones ObternerAmpliacion(int id) {
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
                return AmpliacionDao.instancia().ListarAmpliaciones(lote,numero);
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
