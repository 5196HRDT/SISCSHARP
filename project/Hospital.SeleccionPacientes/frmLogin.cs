using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using Comunes.Dominio;
using Comunes.Entidades;
using Comunes.Utilitarios;
namespace Hospital.SeleccionPacientes
{
    public partial class frmLogin : MetroForm
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = GestorComun.instancia().validadUsuario(txtUser.Text, txtPass.Text);
            if (objUsuario != null)
            {
                if (objUsuario.nivel != "CUPOS") { 
                    MetroMessageBox.Show(this,"NO CORRESPONDE AL SERVICIO");
                }
            }
            else MetroMessageBox.Show(this,"VALIDO");
        }
    }
}
