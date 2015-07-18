using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comunes.Utilitarios;

namespace SeguroIntegral.Escritorio
{
    public partial class TaskWindowControl : UserControl
    {
        
        public TaskWindowControl()
        {
            InitializeComponent();
            lblMessage.Text = Variables.instancia().mensaje;
            
            
        }
    }
}
