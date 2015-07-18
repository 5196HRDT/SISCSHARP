namespace SeguroIntegral.Escritorio
{
    partial class TaskWindowControl
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMessage.Location = new System.Drawing.Point(24, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(118, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "metroLabel1";
            // 
            // TaskWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Name = "TaskWindowControl";
            this.Size = new System.Drawing.Size(329, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private MetroFramework.Controls.MetroLabel lblMessage;

    }
}
