namespace SeguroIntegral.Escritorio
{
    partial class frmCobertura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFormato = new MetroFramework.Controls.MetroTextBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.gvConsumo = new MetroFramework.Controls.MetroGrid();
            this.idCobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvFormatos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.idFormato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aseguramiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormatos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Formato ";
            // 
            // txtFormato
            // 
            this.txtFormato.Lines = new string[0];
            this.txtFormato.Location = new System.Drawing.Point(99, 79);
            this.txtFormato.MaxLength = 32767;
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.PasswordChar = '\0';
            this.txtFormato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFormato.SelectedText = "";
            this.txtFormato.Size = new System.Drawing.Size(241, 23);
            this.txtFormato.TabIndex = 1;
            this.txtFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFormato.UseSelectable = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(355, 79);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "BUSCAR";
            this.btnNuevo.UseSelectable = true;
            // 
            // gvConsumo
            // 
            this.gvConsumo.AllowUserToAddRows = false;
            this.gvConsumo.AllowUserToDeleteRows = false;
            this.gvConsumo.AllowUserToResizeRows = false;
            this.gvConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvConsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvConsumo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvConsumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvConsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCobertura,
            this.Codigo,
            this.Fecha,
            this.Aprobado,
            this.Monto,
            this.Observacion,
            this.Activo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvConsumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvConsumo.EnableHeadersVisualStyles = false;
            this.gvConsumo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvConsumo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvConsumo.Location = new System.Drawing.Point(23, 343);
            this.gvConsumo.Name = "gvConsumo";
            this.gvConsumo.ReadOnly = true;
            this.gvConsumo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvConsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvConsumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvConsumo.Size = new System.Drawing.Size(497, 141);
            this.gvConsumo.Style = MetroFramework.MetroColorStyle.Silver;
            this.gvConsumo.TabIndex = 3;
            // 
            // idCobertura
            // 
            this.idCobertura.HeaderText = "idCobertura";
            this.idCobertura.Name = "idCobertura";
            this.idCobertura.ReadOnly = true;
            this.idCobertura.Visible = false;
            this.idCobertura.Width = 92;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 68;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 60;
            // 
            // Aprobado
            // 
            this.Aprobado.HeaderText = "Aprobado";
            this.Aprobado.Name = "Aprobado";
            this.Aprobado.ReadOnly = true;
            this.Aprobado.Width = 82;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 65;
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 94;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 42;
            // 
            // gvFormatos
            // 
            this.gvFormatos.AllowUserToAddRows = false;
            this.gvFormatos.AllowUserToDeleteRows = false;
            this.gvFormatos.AllowUserToResizeRows = false;
            this.gvFormatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvFormatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvFormatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvFormatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFormatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFormatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFormatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvFormatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvFormatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFormato,
            this.Formato,
            this.Paciente,
            this.Especialidad,
            this.Aseguramiento});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFormatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvFormatos.EnableHeadersVisualStyles = false;
            this.gvFormatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvFormatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvFormatos.Location = new System.Drawing.Point(23, 166);
            this.gvFormatos.Name = "gvFormatos";
            this.gvFormatos.ReadOnly = true;
            this.gvFormatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFormatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvFormatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvFormatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFormatos.Size = new System.Drawing.Size(497, 141);
            this.gvFormatos.Style = MetroFramework.MetroColorStyle.Silver;
            this.gvFormatos.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Fecha";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(195, 119);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(23, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Al";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(76, 116);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(114, 29);
            this.metroDateTime1.TabIndex = 4;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(226, 116);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(114, 29);
            this.metroDateTime2.TabIndex = 4;
            // 
            // idFormato
            // 
            this.idFormato.DataPropertyName = "idFormato";
            this.idFormato.HeaderText = "idFormato";
            this.idFormato.Name = "idFormato";
            this.idFormato.ReadOnly = true;
            this.idFormato.Visible = false;
            this.idFormato.Width = 83;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "numero";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            this.Formato.Width = 73;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "objPaciete.nombres";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 73;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 94;
            // 
            // Aseguramiento
            // 
            this.Aseguramiento.HeaderText = "Aseguramiento";
            this.Aseguramiento.Name = "Aseguramiento";
            this.Aseguramiento.ReadOnly = true;
            this.Aseguramiento.Width = 108;
            // 
            // frmCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.Edit;
            this.BackImagePadding = new System.Windows.Forms.Padding(350, 15, 0, 0);
            this.BackMaxSize = 45;
            this.ClientSize = new System.Drawing.Size(791, 524);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.gvFormatos);
            this.Controls.Add(this.gvConsumo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCobertura";
            this.Text = "MONTO COBERTURA Persona";
            this.Load += new System.EventHandler(this.frmCobertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFormato;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroGrid gvConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private MetroFramework.Controls.MetroGrid gvFormatos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aseguramiento;


    }
}