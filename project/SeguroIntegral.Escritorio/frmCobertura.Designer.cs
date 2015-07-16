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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFormato = new MetroFramework.Controls.MetroTextBox();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.lvAmpliaciones = new System.Windows.Forms.ListView();
            this.idCobertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idSis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Formato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnosticos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblMRestante = new System.Windows.Forms.Label();
            this.lblMCobertura = new System.Windows.Forms.Label();
            this.lblMAmpliaciones = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMOxigeno = new System.Windows.Forms.Label();
            this.lblMProcedimiento = new System.Windows.Forms.Label();
            this.lblMFormato = new System.Windows.Forms.Label();
            this.lblMMedicamento = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnGrabar = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dptFechaAp = new MetroFramework.Controls.MetroDateTime();
            this.dtpFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.txtNSolicitud = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Formato ";
            // 
            // txtFormato
            // 
            this.txtFormato.Lines = new string[0];
            this.txtFormato.Location = new System.Drawing.Point(154, 86);
            this.txtFormato.MaxLength = 32767;
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.PasswordChar = '\0';
            this.txtFormato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFormato.SelectedText = "";
            this.txtFormato.Size = new System.Drawing.Size(222, 23);
            this.txtFormato.TabIndex = 1;
            this.txtFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFormato.UseSelectable = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImprimir.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.print1;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnImprimir.Location = new System.Drawing.Point(154, 129);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 32);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(382, 86);
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
            this.metroLabel3.Location = new System.Drawing.Point(554, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(23, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Al";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(435, 83);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(114, 29);
            this.metroDateTime1.TabIndex = 4;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(585, 83);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(114, 29);
            this.metroDateTime2.TabIndex = 4;
            // 
            // lvAmpliaciones
            // 
            this.lvAmpliaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvAmpliaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCobertura,
            this.idSis,
            this.Formato,
            this.Paciente,
            this.Fecha,
            this.Monto,
            this.Diagnosticos,
            this.Activo});
            this.lvAmpliaciones.Location = new System.Drawing.Point(20, 183);
            this.lvAmpliaciones.Name = "lvAmpliaciones";
            this.lvAmpliaciones.Size = new System.Drawing.Size(679, 436);
            this.lvAmpliaciones.TabIndex = 5;
            this.lvAmpliaciones.UseCompatibleStateImageBehavior = false;
            this.lvAmpliaciones.View = System.Windows.Forms.View.Details;
            // 
            // idCobertura
            // 
            this.idCobertura.Text = "ID";
            this.idCobertura.Width = 10;
            // 
            // idSis
            // 
            this.idSis.Text = "idF";
            this.idSis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idSis.Width = 11;
            // 
            // Formato
            // 
            this.Formato.Text = "Formato";
            this.Formato.Width = 86;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 91;
            // 
            // Monto
            // 
            this.Monto.Text = "Monto";
            this.Monto.Width = 76;
            // 
            // Diagnosticos
            // 
            this.Diagnosticos.Text = "Diagnosticos";
            this.Diagnosticos.Width = 156;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblMRestante);
            this.metroPanel1.Controls.Add(this.lblMCobertura);
            this.metroPanel1.Controls.Add(this.lblMAmpliaciones);
            this.metroPanel1.Controls.Add(this.lblTotal);
            this.metroPanel1.Controls.Add(this.lblMOxigeno);
            this.metroPanel1.Controls.Add(this.lblMProcedimiento);
            this.metroPanel1.Controls.Add(this.lblMFormato);
            this.metroPanel1.Controls.Add(this.lblMMedicamento);
            this.metroPanel1.Controls.Add(this.lblComentario);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.btnGrabar);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel18);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.dptFechaAp);
            this.metroPanel1.Controls.Add(this.dtpFecha);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.txtMonto);
            this.metroPanel1.Controls.Add(this.txtNSolicitud);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(739, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(481, 543);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblMRestante
            // 
            this.lblMRestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRestante.Location = new System.Drawing.Point(369, 372);
            this.lblMRestante.Name = "lblMRestante";
            this.lblMRestante.Size = new System.Drawing.Size(84, 29);
            this.lblMRestante.TabIndex = 11;
            this.lblMRestante.Text = "label1";
            this.lblMRestante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMCobertura
            // 
            this.lblMCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCobertura.Location = new System.Drawing.Point(369, 335);
            this.lblMCobertura.Name = "lblMCobertura";
            this.lblMCobertura.Size = new System.Drawing.Size(84, 29);
            this.lblMCobertura.TabIndex = 11;
            this.lblMCobertura.Text = "label1";
            this.lblMCobertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMAmpliaciones
            // 
            this.lblMAmpliaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMAmpliaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAmpliaciones.Location = new System.Drawing.Point(369, 297);
            this.lblMAmpliaciones.Name = "lblMAmpliaciones";
            this.lblMAmpliaciones.Size = new System.Drawing.Size(84, 29);
            this.lblMAmpliaciones.TabIndex = 11;
            this.lblMAmpliaciones.Text = "label1";
            this.lblMAmpliaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(160, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 29);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label1";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMOxigeno
            // 
            this.lblMOxigeno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMOxigeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOxigeno.Location = new System.Drawing.Point(160, 335);
            this.lblMOxigeno.Name = "lblMOxigeno";
            this.lblMOxigeno.Size = new System.Drawing.Size(84, 29);
            this.lblMOxigeno.TabIndex = 11;
            this.lblMOxigeno.Text = "label1";
            this.lblMOxigeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMProcedimiento
            // 
            this.lblMProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMProcedimiento.Location = new System.Drawing.Point(160, 297);
            this.lblMProcedimiento.Name = "lblMProcedimiento";
            this.lblMProcedimiento.Size = new System.Drawing.Size(84, 29);
            this.lblMProcedimiento.TabIndex = 11;
            this.lblMProcedimiento.Text = "label1";
            this.lblMProcedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMFormato
            // 
            this.lblMFormato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMFormato.Location = new System.Drawing.Point(369, 254);
            this.lblMFormato.Name = "lblMFormato";
            this.lblMFormato.Size = new System.Drawing.Size(84, 29);
            this.lblMFormato.TabIndex = 11;
            this.lblMFormato.Text = "label1";
            this.lblMFormato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMMedicamento
            // 
            this.lblMMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMMedicamento.Location = new System.Drawing.Point(160, 254);
            this.lblMMedicamento.Name = "lblMMedicamento";
            this.lblMMedicamento.Size = new System.Drawing.Size(84, 29);
            this.lblMMedicamento.TabIndex = 11;
            this.lblMMedicamento.Text = "label1";
            this.lblMMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComentario
            // 
            this.lblComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(14, 434);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(439, 96);
            this.lblComentario.TabIndex = 11;
            this.lblComentario.Text = "label1";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton2.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.close;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(334, 182);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 32);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "SALIR";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton2.UseSelectable = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGrabar.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources.save;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrabar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGrabar.Location = new System.Drawing.Point(16, 182);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(115, 32);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "GUARDAR";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(250, 372);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(88, 19);
            this.metroLabel17.TabIndex = 10;
            this.metroLabel17.Text = "Restante S/.";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(250, 341);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(114, 19);
            this.metroLabel16.TabIndex = 10;
            this.metroLabel16.Text = "T. Cobertura S/.";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(250, 303);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(121, 19);
            this.metroLabel15.TabIndex = 10;
            this.metroLabel15.Text = "Ampliaciones S/.";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(250, 260);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(113, 19);
            this.metroLabel14.TabIndex = 10;
            this.metroLabel14.Text = "Monto F.U.A S/.";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(16, 406);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(88, 19);
            this.metroLabel18.TabIndex = 10;
            this.metroLabel18.Text = "Comentario";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(16, 372);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(64, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "Total S/.";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(16, 341);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(103, 19);
            this.metroLabel12.TabIndex = 10;
            this.metroLabel12.Text = "T. Oxigeno S/.";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(14, 303);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(145, 19);
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "T. Procedimiento S/.";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(16, 260);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(138, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "T. Medicamento S/.";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(16, 129);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Diagnosticos";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(16, 89);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Monto";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(250, 89);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Aprobada";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dptFechaAp
            // 
            this.dptFechaAp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFechaAp.Location = new System.Drawing.Point(333, 82);
            this.dptFechaAp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dptFechaAp.Name = "dptFechaAp";
            this.dptFechaAp.Size = new System.Drawing.Size(115, 29);
            this.dptFechaAp.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(334, 47);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(115, 29);
            this.dtpFecha.TabIndex = 9;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(116, 129);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(332, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(114, 88);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(130, 23);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.UseSelectable = true;
            // 
            // txtNSolicitud
            // 
            this.txtNSolicitud.Lines = new string[0];
            this.txtNSolicitud.Location = new System.Drawing.Point(114, 53);
            this.txtNSolicitud.MaxLength = 32767;
            this.txtNSolicitud.Name = "txtNSolicitud";
            this.txtNSolicitud.PasswordChar = '\0';
            this.txtNSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNSolicitud.SelectedText = "";
            this.txtNSolicitud.Size = new System.Drawing.Size(130, 23);
            this.txtNSolicitud.TabIndex = 8;
            this.txtNSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNSolicitud.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(250, 53);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Fecha";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(16, 53);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Nª ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(16, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(176, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Solicitud de Ampliacion: ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevo.BackgroundImage = global::SeguroIntegral.Escritorio.Properties.Resources._new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNuevo.Location = new System.Drawing.Point(20, 129);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 32);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseSelectable = true;
            // 
            // Activo
            // 
            this.Activo.Text = "Anulado";
            this.Activo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Paciente
            // 
            this.Paciente.Text = "Paciente";
            this.Paciente.Width = 170;
            // 
            // frmCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.document;
            this.BackImagePadding = new System.Windows.Forms.Padding(350, 15, 0, 0);
            this.BackMaxSize = 45;
            this.ClientSize = new System.Drawing.Size(1243, 645);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lvAmpliaciones);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCobertura";
            this.Text = "AMPLIACIONES COBERTURA";
            this.Load += new System.EventHandler(this.frmCobertura_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFormato;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.ListView lvAmpliaciones;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dptFechaAp;
        private MetroFramework.Controls.MetroDateTime dtpFecha;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private MetroFramework.Controls.MetroTextBox txtNSolicitud;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnGrabar;
        private System.Windows.Forms.ColumnHeader idCobertura;
        private System.Windows.Forms.ColumnHeader idSis;
        private System.Windows.Forms.ColumnHeader Formato;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Monto;
        private System.Windows.Forms.ColumnHeader Diagnosticos;
        private System.Windows.Forms.Label lblMRestante;
        private System.Windows.Forms.Label lblMCobertura;
        private System.Windows.Forms.Label lblMAmpliaciones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMOxigeno;
        private System.Windows.Forms.Label lblMProcedimiento;
        private System.Windows.Forms.Label lblMFormato;
        private System.Windows.Forms.Label lblMMedicamento;
        private System.Windows.Forms.Label lblComentario;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.ColumnHeader Activo;
        private System.Windows.Forms.ColumnHeader Paciente;


    }
}