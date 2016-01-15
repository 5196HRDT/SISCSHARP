using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SeguroIntegral.Dominio;
using SeguroIntegral.Entidades;
using Cobertura.Entidades;
using Comunes.Utilitarios;
using Comunes.Dominio;
namespace SeguroIntegral.Escritorio
{
    public partial class frmDerivacion : MetroForm
    {
        int pulsado=0;
        GestorSeguroIntegral GestorSI = GestorSeguroIntegral.instancia();
        GestorComun GestorCm = GestorComun.instancia();
        public frmDerivacion()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtCie_KeyDown(object sender, KeyEventArgs e)
        {
            pulsado++;
            if (pulsado == 1 && txtCie.Text.Length > 0 && e.KeyCode == Keys.Enter) {
                mtFiltro.Left = metroLabel4.Left;
                mtFiltro.Top = metroLabel4.Top + metroLabel4.Height;
                mtFiltro.DataSource = GestorCm.BuscarCie10(txtCie.Text.Trim(), 2);
                pulsado = 0;
            }
            
            
        }

       

    
    }
}
