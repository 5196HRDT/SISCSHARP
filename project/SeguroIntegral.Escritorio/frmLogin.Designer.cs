namespace SeguroIntegral.Escritorio
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblPass = new MetroFramework.Controls.MetroLabel();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(144, 68);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(137, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(23, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPass.Location = new System.Drawing.Point(23, 113);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(103, 19);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "CONTRASEÑA";
            this.lblPass.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtClave
            // 
            this.txtClave.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClave.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtClave.Lines = new string[0];
            this.txtClave.Location = new System.Drawing.Point(144, 111);
            this.txtClave.MaxLength = 32767;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '●';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.Size = new System.Drawing.Size(137, 23);
            this.txtClave.TabIndex = 2;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.UseSelectable = true;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.Location = new System.Drawing.Point(302, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 64);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "&ACCEDER";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SeguroIntegral.Escritorio.Properties.Resources.GitHub_Mark;
            this.BackImagePadding = new System.Windows.Forms.Padding(330, 15, 0, 0);
            this.BackMaxSize = 45;
            this.ClientSize = new System.Drawing.Size(422, 163);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "SEGURO INTEGRAL DE SALUD";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblPass;
        private MetroFramework.Controls.MetroTextBox txtClave;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}