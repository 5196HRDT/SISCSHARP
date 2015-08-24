using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data;
using System.Collections.Generic;
using SeguroIntegral.Dominio;
using SeguroIntegral.Entidades;
using Cobertura.Entidades;
using Comunes.Utilitarios;
namespace SeguroIntegral.Escritorio{
    public partial class frmCobertura : MetroForm{   
        private List<Ampliaciones> lst;
        private Formato objFormato;
        private ListViewItem Fila;
        private GestorSeguroIntegral GestorSeguro = GestorSeguroIntegral.instancia();
        private int id, idformato;
        private Ampliaciones objAmpliacion;        
        public frmCobertura(){
            InitializeComponent();
        }       
        private void frmCobertura_Load(object sender, EventArgs e){
            lvAmpliaciones.Columns[0].Width = 0;
            lvAmpliaciones.Columns[1].Width = 0;
            pSolicitud.Enabled = false;
            btnGrabar.Enabled = false;                    
        }
        private void LlenarLista(){
            lvAmpliaciones.Items.Clear();
            for (int i = 0; i < lst.Count; i++){
                Fila = new ListViewItem();
                Fila = lvAmpliaciones.Items.Add(lst[i].idAmpliacion.ToString());
                Fila.SubItems.Add(lst[i].objFormato.idFormato.ToString());
                Fila.SubItems.Add(lst[i].objFormato.numero);
                Fila.SubItems.Add(lst[i].objPersona.nombres);
                Fila.SubItems.Add(lst[i].fechaSolicitud.ToShortDateString());
                Fila.SubItems.Add(lst[i].monto.ToString("#.00"));
                Fila.SubItems.Add(lst[i].observacion);
            }
        }

        private void infoFormato(){
            decimal   mformato, cobertura, total;
            
            objFormato = GestorSeguro.ObtenerFormato(idformato);
            if (objFormato != null){
                mformato = 7700;
                lblMFormato.Text = mformato.ToString("#.00");
                lblSolicitud.Text = string.Empty;
                cobertura = objFormato.Monto.TCobertura + mformato;
                total= objFormato.Monto.Medicamento + objFormato.Monto.Procedimiento + objFormato.Monto.Oxigeno;
                lblSolicitud.Text = string.Concat("Ampliacion "," - ",objFormato.objPaciente.aPaterno, " ",
                                    objFormato.objPaciente.aMaterno, " ", objFormato.objPaciente.nombres);
                txtLoteFormato.Text = objFormato.lote;
                txtNFormato.Text = objFormato.numero;
                lblMMedicamento.Text = objFormato.Monto.Medicamento.ToString("#.00");
                lblMProcedimiento.Text = objFormato.Monto.Procedimiento.ToString("#.00");
                objFormato = GestorSeguro.ObtenerFormato(idformato);

                lblMOxigeno.Text = objFormato.Monto.Oxigeno.ToString("#.00");
                lblMAmpliaciones.Text = objFormato.Monto.TCobertura.ToString("#.00");
                lblMCobertura.Text = cobertura.ToString("#.00");
                lblTotal.Text = total.ToString("#.00");
                lblMRestante.Text = (cobertura - total).ToString("#.00");
                decimal restante=decimal.Parse(lblMRestante.Text);
                if (restante > 5000){
                    lblComentario.Text = "TODO ESTA BIEN, NO REQUIERE AMPLIACION";
                    lblComentario.BackColor=Color.Green;
                }
                if (restante < 5000 && restante >= 2000){
                    lblComentario.Text = "EN OBSERVACION, PUEDE REQUERIR AMPLIACION";
                    lblComentario.BackColor = Color.Orange;
                }
                if (restante < 2000){
                    lblComentario.Text = "ALERTA, REQUIERE AMPLIACION URGENTE, DE LO CONTRARIO SE INHABILITARA FORMATO POR SISTEMAS";
                    lblComentario.BackColor = Color.Red;
                    lblComentario.ForeColor = Color.White;
                }
            }
        }

        private void txtNFormato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objFormato = GestorSeguro.ObtenerFormato(txtLoteFormato.Text.Trim(), txtNFormato.Text.Trim());
                if (objFormato != null) { 
                    idformato = objFormato.idFormato;
                    
                    lblSolicitud.Text = string.Concat(lblSolicitud.Text, objFormato.objPaciente.nombres);
                    this.infoFormato();
                }
            }
        }
        private void Limpiar() {
            txtNSolicitud.Clear();
            lblComentario.BackColor = Color.White;
            dptFechaAp.Value = DateTime.Now;
            dptFechaS.Value = DateTime.Now;
            txtNSolicitud.Clear();
            txtMonto.Clear();
          //  txtLoteFormato.Clear();
           // txtNFormato.Clear();
            txtDiagnosticos.Clear();
            lblComentario.Text = "";
            lblMAmpliaciones.Text = "";
            lblMMedicamento.Text = "";
            lblMProcedimiento.Text = "";
            lblMOxigeno.Text = "";
            lblTotal.Text = "";
            lblMCobertura.Text = "";
            lblMRestante.Text = "";
            lblSolicitud.Text = "Ampliacion: ";
            id = 0;
            idformato = 0;
            btnGrabar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.pSolicitud.Enabled = false;
           
            btnGrabar.Enabled = false;
            this.Limpiar();
            this.txtFormato.Select();
            Variables.instancia().InhabilitarControles(pSolicitud, false);
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtFormato_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter){
                lst= GestorSeguro.ListarAmpliacion(txtNLote.Text, txtFormato.Text);
                this.LlenarLista();
            }
        }

        
        private void lvAmpliaciones_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter){                
                if (lvAmpliaciones.SelectedIndices.Count > 0) {
                    id = int.Parse(lvAmpliaciones.SelectedItems[0].SubItems[0].Text);
                    idformato = int.Parse(lvAmpliaciones.SelectedItems[0].SubItems[1].Text);
                    objAmpliacion = GestorSeguro.ObternerAmpliacion(id);
                    if(objAmpliacion!=null){
                        txtNSolicitud.Text = objAmpliacion.codigo;
                        dptFechaS.Value = objAmpliacion.fechaSolicitud;
                        dptFechaAp.Value = objAmpliacion.fechaAprobada;
                        txtMonto.Text = objAmpliacion.monto.ToString("#.00");
                        txtDiagnosticos.Text = objAmpliacion.observacion;
                        this.infoFormato();
                        pSolicitud.Enabled = true;
                        pSolicitud.Visible = true;
                        btnGrabar.Enabled = true;
                    }                    
                }   
            }
            if (e.KeyCode == Keys.Delete) {
                if (lvAmpliaciones.SelectedIndices.Count > 0)
                {
                    DialogResult r = MetroMessageBox.Show(this, "DESEA ELIMINAR AMPLIACION", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        id = int.Parse(lvAmpliaciones.SelectedItems[0].SubItems[0].Text);
                        GestorSeguro.EliminarAmpliacion(id);
                        lst = GestorSeguro.ListarAmpliacion("", "");
                        this.LlenarLista();
                    }
                    
                    
                    
                }   
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e){
            this.txtLoteFormato.Text = txtNLote.Text;
            this.txtNFormato.Text = txtFormato.Text;
            Limpiar();
            pSolicitud.Enabled = true;
            btnGrabar.Enabled = true;
            Variables.instancia().InhabilitarControles(pSolicitud, true);      
            txtNSolicitud.Select();
        }

        private void btnGrabar_Click(object sender, EventArgs e){
            objAmpliacion = new Ampliaciones();
            objAmpliacion.idAmpliacion = id;
            objAmpliacion.objFormato = new Entidades.Formato();
            objAmpliacion.objFormato.idFormato = idformato;
            objAmpliacion.codigo = txtNSolicitud.Text;
            objAmpliacion.fechaSolicitud = dptFechaS.Value.Date;
            objAmpliacion.fechaAprobada = dptFechaAp.Value.Date;
            objAmpliacion.monto = decimal.Parse(txtMonto.Text);
            objAmpliacion.observacion= txtDiagnosticos.Text;
            if (GestorSeguro.GuardarAmpliacion(objAmpliacion) > 0) {
                MetroMessageBox.Show(this, "\n \n SE GUARDO CORRECTAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Limpiar();
                this.pSolicitud.Enabled = false;
                lst = GestorSeguro.ListarAmpliacion(txtNLote.Text, txtFormato.Text);
                this.LlenarLista();
            }
            else MetroMessageBox.Show(this, "\n \n OCURRIO UN ERROR", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void dtpFechaF_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter){
                lst = GestorSeguro.ListarAmpliaciones(dtpFechaI.Value.Date, dtpFechaF.Value.Date);
                this.LlenarLista();
            }
        }

      
    }
}
