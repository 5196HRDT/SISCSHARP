using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SeguroIntegral.Dominio;
using Cobertura.Entidades;
namespace SeguroIntegral.Escritorio
{
    public partial class frmConsultaCobertura : MetroForm
    {
        public frmConsultaCobertura()
        {
            InitializeComponent();
        }

        private void frmConsultaCobertura_Load(object sender, EventArgs e)
        {

        }

        private void dtpFinal_KeyDown(object sender, KeyEventArgs e)
        {
            List<Ampliaciones> lst;
            if (e.KeyCode == Keys.Enter) {
                lst = GestorSeguroIntegral.instancia().EstadoCuenta(dtpInicio.Value.Date, dtpFinal.Value.Date);             
            }
        }

 
       

      
    }
}
