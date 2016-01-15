namespace SeguroIntegral.Escritorio
{
    partial class frmDerivacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDerivacion));
            this.dgvDerivaciones = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPaciente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtHistoria = new MetroFramework.Controls.MetroTextBox();
            this.gbDerivacion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.dtpFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtCie = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtEspecialidad = new MetroFramework.Controls.MetroTextBox();
            this.txtEESS = new MetroFramework.Controls.MetroTextBox();
            this.txtdcie = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.mtFiltro = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivaciones)).BeginInit();
            this.gbDerivacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDerivaciones
            // 
            this.dgvDerivaciones.AllowUserToResizeRows = false;
            this.dgvDerivaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDerivaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDerivaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDerivaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDerivaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDerivaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDerivaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDerivaciones.EnableHeadersVisualStyles = false;
            this.dgvDerivaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDerivaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDerivaciones.Location = new System.Drawing.Point(24, 107);
            this.dgvDerivaciones.Name = "dgvDerivaciones";
            this.dgvDerivaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDerivaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDerivaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDerivaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDerivaciones.Size = new System.Drawing.Size(508, 305);
            this.dgvDerivaciones.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(24, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "N° Historia Clínica";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Lines = new string[0];
            this.txtPaciente.Location = new System.Drawing.Point(159, 71);
            this.txtPaciente.MaxLength = 32767;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.PasswordChar = '\0';
            this.txtPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaciente.SelectedText = "";
            this.txtPaciente.Size = new System.Drawing.Size(170, 23);
            this.txtPaciente.TabIndex = 3;
            this.txtPaciente.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(11, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "N° Historia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(11, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Especialidad";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(11, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Diagnóstico";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(11, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Centro Salud ";
            // 
            // txtHistoria
            // 
            this.txtHistoria.Lines = new string[0];
            this.txtHistoria.Location = new System.Drawing.Point(117, 35);
            this.txtHistoria.MaxLength = 32767;
            this.txtHistoria.Name = "txtHistoria";
            this.txtHistoria.PasswordChar = '\0';
            this.txtHistoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHistoria.SelectedText = "";
            this.txtHistoria.Size = new System.Drawing.Size(118, 23);
            this.txtHistoria.TabIndex = 4;
            this.txtHistoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHistoria.UseSelectable = true;
            // 
            // gbDerivacion
            // 
            this.gbDerivacion.Controls.Add(this.btnCancelar);
            this.gbDerivacion.Controls.Add(this.btnGuardar);
            this.gbDerivacion.Controls.Add(this.dtpFecha);
            this.gbDerivacion.Controls.Add(this.metroLabel6);
            this.gbDerivacion.Controls.Add(this.txtCie);
            this.gbDerivacion.Controls.Add(this.metroTextBox1);
            this.gbDerivacion.Controls.Add(this.txtEspecialidad);
            this.gbDerivacion.Controls.Add(this.txtEESS);
            this.gbDerivacion.Controls.Add(this.txtdcie);
            this.gbDerivacion.Controls.Add(this.txtHistoria);
            this.gbDerivacion.Controls.Add(this.metroLabel1);
            this.gbDerivacion.Controls.Add(this.metroLabel7);
            this.gbDerivacion.Controls.Add(this.metroLabel3);
            this.gbDerivacion.Controls.Add(this.metroLabel5);
            this.gbDerivacion.Controls.Add(this.metroLabel4);
            this.gbDerivacion.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDerivacion.Location = new System.Drawing.Point(538, 54);
            this.gbDerivacion.Name = "gbDerivacion";
            this.gbDerivacion.Size = new System.Drawing.Size(511, 358);
            this.gbDerivacion.TabIndex = 5;
            this.gbDerivacion.TabStop = false;
            this.gbDerivacion.Text = "DERIVACION";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(378, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGuardar.Location = new System.Drawing.Point(11, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&GRABAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseSelectable = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(312, 29);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 29);
            this.dtpFecha.TabIndex = 6;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(259, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Fecha";
            // 
            // txtCie
            // 
            this.txtCie.Lines = new string[0];
            this.txtCie.Location = new System.Drawing.Point(117, 75);
            this.txtCie.MaxLength = 32767;
            this.txtCie.Name = "txtCie";
            this.txtCie.PasswordChar = '\0';
            this.txtCie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCie.SelectedText = "";
            this.txtCie.Size = new System.Drawing.Size(62, 23);
            this.txtCie.TabIndex = 4;
            this.txtCie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCie.UseSelectable = true;
            this.txtCie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCie_KeyDown);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(117, 190);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(380, 84);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Lines = new string[0];
            this.txtEspecialidad.Location = new System.Drawing.Point(117, 152);
            this.txtEspecialidad.MaxLength = 32767;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.PasswordChar = '\0';
            this.txtEspecialidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEspecialidad.SelectedText = "";
            this.txtEspecialidad.Size = new System.Drawing.Size(380, 23);
            this.txtEspecialidad.TabIndex = 4;
            this.txtEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEspecialidad.UseSelectable = true;
            // 
            // txtEESS
            // 
            this.txtEESS.Lines = new string[0];
            this.txtEESS.Location = new System.Drawing.Point(117, 114);
            this.txtEESS.MaxLength = 32767;
            this.txtEESS.Name = "txtEESS";
            this.txtEESS.PasswordChar = '\0';
            this.txtEESS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEESS.SelectedText = "";
            this.txtEESS.Size = new System.Drawing.Size(380, 23);
            this.txtEESS.TabIndex = 4;
            this.txtEESS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEESS.UseSelectable = true;
            // 
            // txtdcie
            // 
            this.txtdcie.Lines = new string[0];
            this.txtdcie.Location = new System.Drawing.Point(185, 75);
            this.txtdcie.MaxLength = 32767;
            this.txtdcie.Name = "txtdcie";
            this.txtdcie.PasswordChar = '\0';
            this.txtdcie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdcie.SelectedText = "";
            this.txtdcie.Size = new System.Drawing.Size(312, 23);
            this.txtdcie.TabIndex = 4;
            this.txtdcie.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(11, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Observaciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources._new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevo.Location = new System.Drawing.Point(335, 63);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 31);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.close;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(443, 63);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseSelectable = true;
            // 
            // mtFiltro
            // 
            this.mtFiltro.AllowUserToResizeRows = false;
            this.mtFiltro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtFiltro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtFiltro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mtFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtFiltro.DefaultCellStyle = dataGridViewCellStyle5;
            this.mtFiltro.EnableHeadersVisualStyles = false;
            this.mtFiltro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtFiltro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtFiltro.Location = new System.Drawing.Point(538, 446);
            this.mtFiltro.Name = "mtFiltro";
            this.mtFiltro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtFiltro.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mtFiltro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtFiltro.Size = new System.Drawing.Size(491, 150);
            this.mtFiltro.TabIndex = 7;
            // 
            // frmDerivacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.GitHub_Mark;
            this.BackImagePadding = new System.Windows.Forms.Padding(350, 15, 0, 0);
            this.BackMaxSize = 45;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1067, 456);
            this.Controls.Add(this.mtFiltro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.dgvDerivaciones);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gbDerivacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDerivacion";
            this.Text = "DERIVACION  PACIENTE EE.SS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivaciones)).EndInit();
            this.gbDerivacion.ResumeLayout(false);
            this.gbDerivacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvDerivaciones;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPaciente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtHistoria;
        private System.Windows.Forms.GroupBox gbDerivacion;
        private MetroFramework.Controls.MetroTextBox txtdcie;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtCie;
        private MetroFramework.Controls.MetroDateTime dtpFecha;
        private MetroFramework.Controls.MetroTextBox txtEspecialidad;
        private MetroFramework.Controls.MetroTextBox txtEESS;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroGrid mtFiltro;

    }
}