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
            //this.mtAltoCosto.Visible = false;
        }

        private void mtAltoCosto_Click(object sender, EventArgs e)
        {
            new frmConsultaCobertura().Show();
            /*frmConsultaCobertura Cobertura = new frmConsultaCobertura();
            Cobertura.ShowDialog();
            Cobertura.Dispose();
            */
        }

        private void mtAmpliacion_Click(object sender, EventArgs e)
        {
            //frmCobertura Ampliacaion;//= new frmCobertura();
            new frmCobertura().Show();

           // Ampliacaion.Dispose();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void mtDerivacion_Click(object sender, EventArgs e)
        {
            new frmDerivacion().Show();
        }
    }
}
