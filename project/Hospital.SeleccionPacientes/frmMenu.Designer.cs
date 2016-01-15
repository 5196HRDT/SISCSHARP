namespace Hospital.SeleccionPacientes
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
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbAtencion = new MetroFramework.Controls.MetroTabPage();
            this.tbReportes = new MetroFramework.Controls.MetroTabPage();
            this.mtHClinica = new MetroFramework.Controls.MetroTile();
            this.tbMenu.SuspendLayout();
            this.tbAtencion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbAtencion);
            this.tbMenu.Controls.Add(this.tbReportes);
            this.tbMenu.Location = new System.Drawing.Point(23, 63);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(658, 456);
            this.tbMenu.TabIndex = 0;
            this.tbMenu.UseSelectable = true;
            // 
            // tbAtencion
            // 
            this.tbAtencion.Controls.Add(this.mtHClinica);
            this.tbAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAtencion.HorizontalScrollbarBarColor = true;
            this.tbAtencion.HorizontalScrollbarHighlightOnWheel = false;
            this.tbAtencion.HorizontalScrollbarSize = 10;
            this.tbAtencion.Location = new System.Drawing.Point(4, 38);
            this.tbAtencion.Name = "tbAtencion";
            this.tbAtencion.Size = new System.Drawing.Size(650, 414);
            this.tbAtencion.TabIndex = 0;
            this.tbAtencion.Text = "Atención";
            this.tbAtencion.VerticalScrollbarBarColor = true;
            this.tbAtencion.VerticalScrollbarHighlightOnWheel = false;
            this.tbAtencion.VerticalScrollbarSize = 10;
            // 
            // tbReportes
            // 
            this.tbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReportes.HorizontalScrollbarBarColor = true;
            this.tbReportes.HorizontalScrollbarHighlightOnWheel = false;
            this.tbReportes.HorizontalScrollbarSize = 10;
            this.tbReportes.Location = new System.Drawing.Point(4, 38);
            this.tbReportes.Name = "tbReportes";
            this.tbReportes.Size = new System.Drawing.Size(650, 414);
            this.tbReportes.TabIndex = 1;
            this.tbReportes.Text = "Reportes";
            this.tbReportes.VerticalScrollbarBarColor = true;
            this.tbReportes.VerticalScrollbarHighlightOnWheel = false;
            this.tbReportes.VerticalScrollbarSize = 10;
            // 
            // mtHClinica
            // 
            this.mtHClinica.ActiveControl = null;
            this.mtHClinica.Location = new System.Drawing.Point(3, 3);
            this.mtHClinica.Name = "mtHClinica";
            this.mtHClinica.Size = new System.Drawing.Size(153, 125);
            this.mtHClinica.TabIndex = 2;
            this.mtHClinica.Text = "Historia Clínica";
            this.mtHClinica.UseSelectable = true;
            this.mtHClinica.Click += new System.EventHandler(this.mtHClinica_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 531);
            this.Controls.Add(this.tbMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.tbMenu.ResumeLayout(false);
            this.tbAtencion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbMenu;
        private MetroFramework.Controls.MetroTabPage tbAtencion;
        private MetroFramework.Controls.MetroTile mtHClinica;
        private MetroFramework.Controls.MetroTabPage tbReportes;
    }
}