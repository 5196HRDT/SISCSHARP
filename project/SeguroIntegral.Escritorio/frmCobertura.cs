using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Collections.Generic;
using SeguroIntegral.Dominio;
using SeguroIntegral.Entidades;


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
            
            List<Formato> lst = GestorSeguroIntegral.instancia().ListarFormatos("", "");
            
            gvFormatos.AutoGenerateColumns = false;
            gvFormatos.DataSource = lst;
            

            gvFormatos.Font = new Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point);
            gvConsumo.Font = new Font("Segoe UI",9.0F, FontStyle.Bold, GraphicsUnit.Point);
            


            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroTaskWindow.ShowTaskWindow(new Form(),"Titulo", new TaskWindowControl(), 10);
        }
    }
}
