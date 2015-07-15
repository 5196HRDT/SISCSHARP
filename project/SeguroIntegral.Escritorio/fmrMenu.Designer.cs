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
            this.tbPaciente = new MetroFramework.Controls.MetroTabPage();
            this.mtAmpliacion = new MetroFramework.Controls.MetroTile();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbConsultas = new System.Windows.Forms.TabPage();
            this.mtAltoCosto = new MetroFramework.Controls.MetroTile();
            this.tbPaciente.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.tbConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPaciente
            // 
            this.tbPaciente.Controls.Add(this.mtAmpliacion);
            this.tbPaciente.HorizontalScrollbarBarColor = true;
            this.tbPaciente.HorizontalScrollbarHighlightOnWheel = false;
            this.tbPaciente.HorizontalScrollbarSize = 10;
            this.tbPaciente.Location = new System.Drawing.Point(4, 44);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Padding = new System.Windows.Forms.Padding(35);
            this.tbPaciente.Size = new System.Drawing.Size(872, 380);
            this.tbPaciente.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbPaciente.TabIndex = 1;
            this.tbPaciente.Text = "Paciente";
            this.tbPaciente.VerticalScrollbarBarColor = true;
            this.tbPaciente.VerticalScrollbarHighlightOnWheel = false;
            this.tbPaciente.VerticalScrollbarSize = 10;
            this.tbPaciente.Visible = false;
            // 
            // mtAmpliacion
            // 
            this.mtAmpliacion.ActiveControl = null;
            this.mtAmpliacion.AutoSize = true;
            this.mtAmpliacion.Location = new System.Drawing.Point(20, 38);
            this.mtAmpliacion.Name = "mtAmpliacion";
            this.mtAmpliacion.Size = new System.Drawing.Size(217, 167);
            this.mtAmpliacion.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAmpliacion.TabIndex = 2;
            this.mtAmpliacion.Text = "&Ampliación Cobertura";
            this.mtAmpliacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAmpliacion.TileImage = global::SeguroIntegral.Escritorio.Properties.Resources.Edit;
            this.mtAmpliacion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAmpliacion.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAmpliacion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAmpliacion.UseSelectable = true;
            this.mtAmpliacion.UseStyleColors = true;
            this.mtAmpliacion.UseTileImage = true;
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbPaciente);
            this.tbMenu.Controls.Add(this.tbConsultas);
            this.tbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbMenu.Location = new System.Drawing.Point(20, 60);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 1;
            this.tbMenu.Size = new System.Drawing.Size(880, 428);
            this.tbMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.UseSelectable = true;
            // 
            // tbConsultas
            // 
            this.tbConsultas.Controls.Add(this.mtAltoCosto);
            this.tbConsultas.Location = new System.Drawing.Point(4, 44);
            this.tbConsultas.Name = "tbConsultas";
            this.tbConsultas.Padding = new System.Windows.Forms.Padding(35);
            this.tbConsultas.Size = new System.Drawing.Size(872, 380);
            this.tbConsultas.TabIndex = 2;
            this.tbConsultas.Text = "Consultas";
            // 
            // mtAltoCosto
            // 
            this.mtAltoCosto.ActiveControl = null;
            this.mtAltoCosto.Location = new System.Drawing.Point(20, 38);
            this.mtAltoCosto.Name = "mtAltoCosto";
            this.mtAltoCosto.Size = new System.Drawing.Size(217, 167);
            this.mtAltoCosto.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtAltoCosto.TabIndex = 0;
            this.mtAltoCosto.Text = "Paciente Alto Costo";
            this.mtAltoCosto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAltoCosto.TileImage = global::SeguroIntegral.Escritorio.Properties.Resources.Dollar128;
            this.mtAltoCosto.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAltoCosto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAltoCosto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAltoCosto.UseSelectable = true;
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
            this.ClientSize = new System.Drawing.Size(920, 508);
            this.Controls.Add(this.tbMenu);
            this.Name = "frmMenu";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "SISTEMA SEGURO INTEGRAL DE SALUD";
            this.tbPaciente.ResumeLayout(false);
            this.tbPaciente.PerformLayout();
            this.tbMenu.ResumeLayout(false);
            this.tbConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tbPaciente;
        private MetroFramework.Controls.MetroTabControl tbMenu;
        private System.Windows.Forms.TabPage tbConsultas;
        private MetroFramework.Controls.MetroTile mtAmpliacion;
        private MetroFramework.Controls.MetroTile mtAltoCosto;

    }
}