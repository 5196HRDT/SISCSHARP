﻿using System;
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

namespace SeguroIntegral.Escritorio
{
    public partial class frmCobertura : MetroForm
    {
        public frmCobertura()
        {
            InitializeComponent();
        }
        private List<Ampliaciones> lst;
        private ListViewItem Fila;
        private void frmCobertura_Load(object sender, EventArgs e)
        {

            lst = GestorSeguroIntegral.instancia().ListarAmpliacion("");
            for (int i = 0; i < lst.Count; i++)
            {
                Fila = new ListViewItem();
                Fila = lvAmpliaciones.Items.Add(lst[i].idAmpliacion.ToString());
                Fila.SubItems.Add(lst[i].objFormato.idFormato.ToString());
                Fila.SubItems.Add(lst[i].objFormato.numero);
                Fila.SubItems.Add(lst[i].objPersona.nombres);
                Fila.SubItems.Add(lst[i].fechaSolicitud.ToShortDateString());
                Fila.SubItems.Add(lst[i].monto.ToString("#.00"));
                Fila.SubItems.Add(lst[i].observacion);
                Fila.SubItems.Add(lst[i].activo.ToString());
             }
            


            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroTaskWindow.ShowTaskWindow(new Form(),"Titulo", new TaskWindowControl(), 10);
        }

      
    }
}
