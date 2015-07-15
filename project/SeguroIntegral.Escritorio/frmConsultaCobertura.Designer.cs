namespace SeguroIntegral.Escritorio
{
    partial class frmConsultaCobertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCobertura));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtpFinal = new MetroFramework.Controls.MetroDateTime();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(500, 69);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(147, 47);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Imprimir";
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(33, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Fecha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(274, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "al";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(86, 79);
            this.dtpInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(159, 29);
            this.dtpInicio.TabIndex = 3;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(301, 79);
            this.dtpFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(159, 29);
            this.dtpFinal.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(33, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(911, 333);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmConsultaCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.Dollar128;
            this.BackImagePadding = new System.Windows.Forms.Padding(400, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(967, 511);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCobertura";
            this.Text = "CONSULTA - COBERTURA Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpInicio;
        private MetroFramework.Controls.MetroDateTime dtpFinal;
        private System.Windows.Forms.ListView listView1;
    }
}