namespace SeguroIntegral.Escritorio
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPersona = new MetroFramework.Controls.MetroTabPage();
            this.mtAmpliacion = new MetroFramework.Controls.MetroTile();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbConsultas = new System.Windows.Forms.TabPage();
            this.mtAltoCosto = new MetroFramework.Controls.MetroTile();
            this.tbPersona.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.tbConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPersona
            // 
            this.tbPersona.Controls.Add(this.mtAmpliacion);
            this.tbPersona.HorizontalScrollbarBarColor = true;
            this.tbPersona.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPersona.HorizontalScrollbarSize = 10;
            this.tbPersona.Location = new System.Drawing.Point(4, 44);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Padding = new System.Windows.Forms.Padding(35);
            this.tbPersona.Size = new System.Drawing.Size(976, 572);
            this.tbPersona.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbPersona.TabIndex = 1;
            this.tbPersona.Text = "Paciente";
            this.tbPersona.VerticalScrollbarBarColor = true;
            this.tbPersona.VerticalScrollbarHighlightOnWheel = false;
            this.tbPersona.VerticalScrollbarSize = 10;
            this.tbPersona.Visible = false;
            // 
            // mtAmpliacion
            // 
            this.mtAmpliacion.ActiveControl = null;
            this.mtAmpliacion.AutoSize = true;
            this.mtAmpliacion.Location = new System.Drawing.Point(20, 38);
            this.mtAmpliacion.Name = "mtAmpliacion";
            this.mtAmpliacion.Size = new System.Drawing.Size(216, 172);
            this.mtAmpliacion.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAmpliacion.TabIndex = 2;
            this.mtAmpliacion.Text = "&Ampliación Cobertura";
            this.mtAmpliacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAmpliacion.TileImage = global::SeguroIntegral.Escritorio.Properties.Resources.document;
            this.mtAmpliacion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAmpliacion.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAmpliacion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAmpliacion.UseSelectable = true;
            this.mtAmpliacion.UseStyleColors = true;
            this.mtAmpliacion.UseTileImage = true;
            this.mtAmpliacion.Click += new System.EventHandler(this.mtAmpliacion_Click);
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbPersona);
            this.tbMenu.Controls.Add(this.tbConsultas);
            this.tbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbMenu.Location = new System.Drawing.Point(20, 60);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 1;
            this.tbMenu.Size = new System.Drawing.Size(984, 620);
            this.tbMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.UseSelectable = true;
            // 
            // tbConsultas
            // 
            this.tbConsultas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbConsultas.Controls.Add(this.mtAltoCosto);
            this.tbConsultas.Location = new System.Drawing.Point(4, 44);
            this.tbConsultas.Name = "tbConsultas";
            this.tbConsultas.Padding = new System.Windows.Forms.Padding(35);
            this.tbConsultas.Size = new System.Drawing.Size(976, 572);
            this.tbConsultas.TabIndex = 2;
            this.tbConsultas.Text = "Consultas";
            // 
            // mtAltoCosto
            // 
            this.mtAltoCosto.ActiveControl = null;
            this.mtAltoCosto.Location = new System.Drawing.Point(20, 38);
            this.mtAltoCosto.Name = "mtAltoCosto";
            this.mtAltoCosto.Size = new System.Drawing.Size(216, 173);
            this.mtAltoCosto.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAltoCosto.TabIndex = 0;
            this.mtAltoCosto.Text = "Persona Alto Costo";
            this.mtAltoCosto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAltoCosto.TileImage = global::SeguroIntegral.Escritorio.Properties.Resources.money;
            this.mtAltoCosto.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAltoCosto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAltoCosto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAltoCosto.UseSelectable = true;
            this.mtAltoCosto.UseStyleColors = true;
            this.mtAltoCosto.UseTileImage = true;
            this.mtAltoCosto.Click += new System.EventHandler(this.mtAltoCosto_Click);
            // 
            // frmMenu
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.GitHub_Mark;
            this.BackImagePadding = new System.Windows.Forms.Padding(450, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.tbMenu);
            this.Name = "frmMenu";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "SISTEMA SEGURO INTEGRAL DE SALUD";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tbPersona.ResumeLayout(false);
            this.tbPersona.PerformLayout();
            this.tbMenu.ResumeLayout(false);
            this.tbConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tbPersona;
        private MetroFramework.Controls.MetroTabControl tbMenu;
        private System.Windows.Forms.TabPage tbConsultas;
        private MetroFramework.Controls.MetroTile mtAmpliacion;
        private MetroFramework.Controls.MetroTile mtAltoCosto;

    }
}