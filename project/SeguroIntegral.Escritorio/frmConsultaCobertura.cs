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
using SeguroIntegral.Entidades;
using Cobertura.Entidades;
using Comunes.Utilitarios;
namespace SeguroIntegral.Escritorio
{
    public partial class frmConsultaCobertura : MetroForm
    {
        public frmConsultaCobertura()
        {
            InitializeComponent();
        }
        private List<Formato> list;
        private int pulsado = 0;
        private DateTime FechaI, FechaF;
        private void CargarGrid()
        {
            list = GestorSeguroIntegral.instancia().EstadoCuenta(FechaI, FechaF);
            gvLista.DataSource = list.Select(item => new
            {
                LOTE = item.lote,
                NUMERO = item.numero,
                AFILIACION = item.objTipoAseguramiento.descripcion,
                NROHISTORIA = item.objPaciente.nroHistoria,
                PACIENTE = string.Concat(item.objPaciente.aPaterno," ",item.objPaciente.aMaterno,"  ", item.objPaciente.nombres),
                TOTAL = item.Monto.Total.ToString("#,00"),
                OXIGENO = item.Monto.Oxigeno.ToString("#,00"),
                COBERTURA = (item.Monto.TCobertura + 7700).ToString("#,00"),
                DIFERNCIA = ((item.Monto.TCobertura + 7700) - (item.Monto.Oxigeno + item.Monto.Total)).ToString("#.00")
            }).ToList();
        }
        private void frmConsultaCobertura_Load(object sender, EventArgs e)
        {
            gvLista.Font = new Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point);
            gvLista.AllowUserToAddRows = false;
            cboAnio.DataSource = Variables.instancia().Anios();
            cboMes.SelectedIndex = 0;
           
        }
        private void dtpFinal_KeyDown(object sender, KeyEventArgs e)
        {
            pulsado++;
            if (e.KeyCode == Keys.Enter && pulsado == 1)
            {
                FechaI = dtpInicio.Value.Date;
                FechaF = dtpFinal.Value.Date;
                if ((FechaF - FechaI).Days > 90) {
                    MetroMessageBox.Show(this, "FECHA SUPERA EL LIMITE DE 90 DIAS", "MENSAJE DE INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else this.CargarGrid();
            }

        }
        private void chkAnio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnio.Checked == true)
            {
                cboAnio.Enabled = true;
                dtpInicio.Enabled = false;
                dtpFinal.Enabled = false;
            }
            else if (chkAnio.Checked == false && chkMes.Checked == false)
            {
                cboAnio.Enabled = false;
                dtpInicio.Enabled = true;
                dtpFinal.Enabled = true;
            }
            else
            {
                cboAnio.Enabled = false;
            }

        }
        private void chkMes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMes.Checked == true)
            {
                cboMes.Enabled = true;
                dtpInicio.Enabled = false;
                dtpFinal.Enabled = false;
            }
            else if (chkAnio.Checked == false && chkMes.Checked == false)
            {
                cboMes.Enabled = false;
                dtpInicio.Enabled = true;
                dtpFinal.Enabled = true;
            }
            else
            {
                cboMes.Enabled = false;
            }

        }
        private void cboAnio_KeyDown(object sender, KeyEventArgs e)
        {
            pulsado++;
            if (e.KeyCode == Keys.Enter && pulsado == 1)
            {
                FechaI = DateTime.Now;
                switch (chkMes.Checked)
                {
                    case true:
                        FechaI = DateTime.Parse(string.Concat("01/0", (cboMes.SelectedIndex + 1).ToString(), "/", cboAnio.SelectedItem));
                        FechaF = FechaI.AddDays(-1);
                        FechaF = FechaF.AddMonths(1);

                        break;
                    case false:
                        FechaI = DateTime.Parse(string.Concat("01/0", (cboMes.SelectedIndex + 1).ToString(), "/", cboAnio.SelectedItem));
                        FechaF = FechaI.AddYears(1);
                        FechaF = FechaF.AddDays(-1);

                        break;

                }
                this.CargarGrid();
            }
        }
        private void cboMes_KeyDown(object sender, KeyEventArgs e)
        {
            pulsado++;
            if (e.KeyCode == Keys.Enter && pulsado == 1)
            {
                FechaI = DateTime.Now;
                switch (chkAnio.Checked)
                {
                    case true:
                        FechaI = DateTime.Parse(string.Concat("01/0", (cboMes.SelectedIndex + 1).ToString(), "/", cboAnio.SelectedItem));
                        FechaF = FechaI.AddDays(-1);
                        FechaF = FechaF.AddMonths(1);

                        break;
                    case false:
                        FechaI = DateTime.Parse(string.Concat("01/0", (cboMes.SelectedIndex + 1).ToString(), "/", DateTime.Now.Year));
                        FechaF = FechaI.AddDays(-1);
                        FechaF = FechaF.AddMonths(1);

                        break;

                }
                this.CargarGrid();
            }

        }
        private void txtPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            pulsado++;
            if (e.KeyCode == Keys.Enter && pulsado == 1) {
                list = GestorSeguroIntegral.instancia().EstadoCuenta(txtPaciente.Text);
                gvLista.DataSource = list.Select(item => new
                {
                    LOTE = item.lote,
                    NUMERO = item.numero,
                    AFILIACION = item.objTipoAseguramiento.descripcion,
                    NROHISTORIA = item.objPaciente.nroHistoria,
                    PACIENTE = string.Concat(item.objPaciente.aPaterno, " ", item.objPaciente.aMaterno, "  ", item.objPaciente.nombres),
                    TOTAL = item.Monto.Total.ToString("#,00"),
                    OXIGENO = item.Monto.Oxigeno.ToString("#,00"),
                    COBERTURA = (item.Monto.TCobertura + 7700).ToString("#,00"),
                    DIFERNCIA = ((item.Monto.TCobertura + 7700) - (item.Monto.Oxigeno + item.Monto.Total)).ToString("#.00")
                }).ToList();
            }
        }
        private void txtPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            pulsado = 0;
        }
        private void dtpFinal_KeyUp(object sender, KeyEventArgs e)
        {
            pulsado = 0;
        }
        private void cboAnio_KeyUp(object sender, KeyEventArgs e)
        {
            pulsado = 0;
        }
        private void cboMes_KeyUp(object sender, KeyEventArgs e)
        {
            pulsado = 0;
        }
    }
}
