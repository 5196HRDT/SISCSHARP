﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;

using Comunes.Dominio;
using Comunes.Utilitarios;
using Comunes.Entidades;

namespace SeguroIntegral.Escritorio
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       
        private void Acceder() {
            if (txtUsuario.Text.Trim() != "" || txtClave.Text.Trim() != "") return;
            Usuario objUsuario = GestorComun.instancia().validadUsuario(txtUsuario.Text, txtClave.Text);
            if(objUsuario != null){
                Variables.instancia().codigo = objUsuario.idUsuario;
                Variables.instancia().usuario = objUsuario.inciales;
                Variables.instancia().nombres= objUsuario.nombres;
                //MetroTaskWindow.ShowTaskWindow(new Control, "SubControl in TaskWindow", new TaskWindowControl(), 10);
                txtClave.Text = "";
                frmMenu Menu = new frmMenu();           
                Menu.ShowDialog();
                Menu.Dispose();
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtClave.Select();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.Acceder();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           // this.Acceder();
            TaskWindowControl ob = new TaskWindowControl();
            
            Variables.instancia().mensaje = "HOLAAA";
            MetroTaskWindow.ShowTaskWindow("HOLA", ob, 10);

            //MetroTaskWindow.ShowTaskWindow(ob, "BIEVENIDO", ob, 10);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            txtUsuario.Select();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.Text = txtUsuario.Text.ToUpper();
        }


    }
}
