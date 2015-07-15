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
        public List<Formato> ListarFormatos(string lote, string numero) {
            try
            {
                return FormatoDao.instancia().ListarFormato(lote,numero);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Ampliaciones> ListarAmpliacion(string formato)
        {
            try
            {
                return AmpliacionDao.instancia().ListarAmpliaciones(formato);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
