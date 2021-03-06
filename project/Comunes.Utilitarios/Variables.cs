﻿using System;
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
        // SIngleton
        private Variables() { }
        public static Variables instancia() {
            if (_instancia == null) _instancia = new Variables();
            return _instancia;
        }

        // Variables Globales
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string usuario { get; set; }
        public string mensaje { get; set; }
      
        // Metodos y Funciones Globales

        // Fechas Años Lista
        public List<string> anios =  new List<string>();

        public List<string> Anios()
        {
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 12; i--)
            {
                anios.Add( i.ToString());
            }
            return anios;
        }
        
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
      
    }
}

