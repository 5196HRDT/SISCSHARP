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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCobertura));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtpFinal = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPaciente = new MetroFramework.Controls.MetroTextBox();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.gvLista = new MetroFramework.Controls.MetroGrid();
            this.cboAnio = new MetroFramework.Controls.MetroComboBox();
            this.cboMes = new MetroFramework.Controls.MetroComboBox();
            this.chkAnio = new MetroFramework.Controls.MetroCheckBox();
            this.chkMes = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvLista)).BeginInit();
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
            this.metroLabel2.Location = new System.Drawing.Point(273, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hasta";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(86, 79);
            this.dtpInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(159, 29);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(326, 79);
            this.dtpFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(159, 29);
            this.dtpFinal.TabIndex = 2;
            this.dtpFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFinal_KeyDown);
            this.dtpFinal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpFinal_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(525, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Lines = new string[0];
            this.txtPaciente.Location = new System.Drawing.Point(597, 90);
            this.txtPaciente.MaxLength = 32767;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PasswordChar = '\0';
            this.txtPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaciente.SelectedText = "";
            this.txtPaciente.Size = new System.Drawing.Size(274, 23);
            this.txtPaciente.TabIndex = 3;
            this.txtPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaciente.UseSelectable = true;
            this.txtPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaciente_KeyDown);
            this.txtPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaciente_KeyUp);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImprimir.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.print1;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnImprimir.Location = new System.Drawing.Point(917, 90);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 32);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseSelectable = true;
            // 
            // gvLista
            // 
            this.gvLista.AllowUserToAddRows = false;
            this.gvLista.AllowUserToDeleteRows = false;
            this.gvLista.AllowUserToOrderColumns = true;
            this.gvLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvLista.EnableHeadersVisualStyles = false;
            this.gvLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvLista.Location = new System.Drawing.Point(33, 155);
            this.gvLista.MultiSelect = false;
            this.gvLista.Name = "gvLista";
            this.gvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gvLista.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLista.Size = new System.Drawing.Size(1034, 435);
            this.gvLista.Style = MetroFramework.MetroColorStyle.Silver;
            this.gvLista.TabIndex = 19;
            // 
            // cboAnio
            // 
            this.cboAnio.Enabled = false;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.ItemHeight = 23;
            this.cboAnio.Location = new System.Drawing.Point(86, 114);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(159, 29);
            this.cboAnio.TabIndex = 20;
            this.cboAnio.UseSelectable = true;
            this.cboAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAnio_KeyDown);
            this.cboAnio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboAnio_KeyUp);
            // 
            // cboMes
            // 
            this.cboMes.Enabled = false;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.ItemHeight = 23;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboMes.Location = new System.Drawing.Point(326, 112);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(159, 29);
            this.cboMes.TabIndex = 20;
            this.cboMes.UseSelectable = true;
            this.cboMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMes_KeyDown);
            this.cboMes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMes_KeyUp);
            // 
            // chkAnio
            // 
            this.chkAnio.AutoSize = true;
            this.chkAnio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnio.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAnio.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkAnio.Location = new System.Drawing.Point(23, 116);
            this.chkAnio.Name = "chkAnio";
            this.chkAnio.Size = new System.Drawing.Size(52, 19);
            this.chkAnio.TabIndex = 21;
            this.chkAnio.Text = "Año";
            this.chkAnio.UseSelectable = true;
            this.chkAnio.CheckedChanged += new System.EventHandler(this.chkAnio_CheckedChanged);
            // 
            // chkMes
            // 
            this.chkMes.AutoSize = true;
            this.chkMes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMes.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkMes.Location = new System.Drawing.Point(268, 116);
            this.chkMes.Name = "chkMes";
            this.chkMes.Size = new System.Drawing.Size(52, 19);
            this.chkMes.TabIndex = 21;
            this.chkMes.Text = "Mes";
            this.chkMes.UseSelectable = true;
            this.chkMes.CheckedChanged += new System.EventHandler(this.chkMes_CheckedChanged);
            // 
            // frmConsultaCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.Dollar128;
            this.BackImagePadding = new System.Windows.Forms.Padding(400, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1100, 613);
            this.Controls.Add(this.chkMes);
            this.Controls.Add(this.chkAnio);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.gvLista);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCobertura";
            this.Text = "CONSULTA - COBERTURA Persona";
            this.Load += new System.EventHandler(this.frmConsultaCobertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpInicio;
        private MetroFramework.Controls.MetroDateTime dtpFinal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPaciente;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private MetroFramework.Controls.MetroGrid gvLista;
        private MetroFramework.Controls.MetroComboBox cboAnio;
        private MetroFramework.Controls.MetroComboBox cboMes;
        private MetroFramework.Controls.MetroCheckBox chkAnio;
        private MetroFramework.Controls.MetroCheckBox chkMes;
    }
}