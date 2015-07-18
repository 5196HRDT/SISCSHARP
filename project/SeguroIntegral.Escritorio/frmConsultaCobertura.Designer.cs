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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtpFinal = new MetroFramework.Controls.MetroDateTime();
            this.lvAmpliaciones = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPaciente = new MetroFramework.Controls.MetroTextBox();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dtpFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFinal_KeyDown);
            // 
            // lvAmpliaciones
            // 
            this.lvAmpliaciones.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAmpliaciones.AllowColumnReorder = true;
            this.lvAmpliaciones.AllowDrop = true;
            this.lvAmpliaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAmpliaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAmpliaciones.GridLines = true;
            this.lvAmpliaciones.Location = new System.Drawing.Point(33, 145);
            this.lvAmpliaciones.Name = "lvAmpliaciones";
            this.lvAmpliaciones.Size = new System.Drawing.Size(911, 343);
            this.lvAmpliaciones.TabIndex = 4;
            this.lvAmpliaciones.UseCompatibleStateImageBehavior = false;
            this.lvAmpliaciones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 139;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(477, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Lines = new string[0];
            this.txtPaciente.Location = new System.Drawing.Point(549, 81);
            this.txtPaciente.MaxLength = 32767;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PasswordChar = '\0';
            this.txtPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaciente.SelectedText = "";
            this.txtPaciente.Size = new System.Drawing.Size(274, 23);
            this.txtPaciente.TabIndex = 5;
            this.txtPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaciente.UseSelectable = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(843, 81);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 314);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmConsultaCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.Dollar128;
            this.BackImagePadding = new System.Windows.Forms.Padding(400, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(967, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lvAmpliaciones);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCobertura";
            this.Text = "CONSULTA - COBERTURA Persona";
            this.Load += new System.EventHandler(this.frmConsultaCobertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpInicio;
        private MetroFramework.Controls.MetroDateTime dtpFinal;
        private System.Windows.Forms.ListView lvAmpliaciones;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPaciente;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}