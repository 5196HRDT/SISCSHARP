using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework;
using System.Data;

namespace SeguroIntegral.Escritorio
{
    public partial class frmMenu : MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mtAltoCosto_Click(object sender, EventArgs e)
        {
            frmConsultaCobertura Cobertura = new frmConsultaCobertura();
            Cobertura.Show();
        }

        private void mtAmpliacion_Click(object sender, EventArgs e)
        {
            frmCobertura Ampliacaion = new frmCobertura();
            Ampliacaion.Show();
        }
    }
}
