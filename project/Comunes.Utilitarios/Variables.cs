using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Comunes.Utilitarios
{
    public class Variables
    {
        private static Variables _instancia;
        private Variables() { }
        public static Variables instancia() {
            if (_instancia == null) _instancia = new Variables();
            return _instancia;
        }
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string usuario { get; set; }

        public string mensaje { get; set; }

        public void InhabilitarControles(Panel Panel, bool v)
        {
            foreach (Control c in Panel.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = v;
                }
            }
            
        }
            /*
         Public Sub LimpiarTab(ByVal F As TabPage)
        Dim X, y As New Object
        For Each X In F.Controls
            If TypeOf X Is TextBox Then X.Text = ""
            If TypeOf X Is Label Then If X.borderstyle = 1 Then X.text = ""
            If TypeOf X Is MaskedTextBox Then X.Text = ""
            If TypeOf X Is CheckBox Then X.CHECKED = False


        Next
    End Sub
             * */
    }
}

