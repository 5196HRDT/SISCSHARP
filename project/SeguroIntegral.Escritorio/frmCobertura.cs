using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;

namespace SeguroIntegral.Escritorio
{
    public partial class frmCobertura : MetroForm
    {
        public frmCobertura()
        {
            InitializeComponent();
        }

        private void frmCobertura_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroTaskWindow.ShowTaskWindow(new Form(),"Titulo", new TaskWindowControl(), 10);
        }
    }
}
