namespace pryMamondezLP_SP1
{
    partial class frmCultivos
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
            this.mskNumeroCultivo = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumeroCultivo = new System.Windows.Forms.Label();
            this.txtNumeroCultivo = new System.Windows.Forms.TextBox();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskNumeroCultivo
            // 
            this.mskNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mskNumeroCultivo.Location = new System.Drawing.Point(100, 67);
            this.mskNumeroCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.mskNumeroCultivo.Mask = "99999";
            this.mskNumeroCultivo.Name = "mskNumeroCultivo";
            this.mskNumeroCultivo.Size = new System.Drawing.Size(76, 20);
            this.mskNumeroCultivo.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAceptar.Location = new System.Drawing.Point(119, 106);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(57, 26);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumeroCultivo
            // 
            this.lblNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNumeroCultivo.Location = new System.Drawing.Point(11, 67);
            this.lblNumeroCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroCultivo.Name = "lblNumeroCultivo";
            this.lblNumeroCultivo.Size = new System.Drawing.Size(75, 32);
            this.lblNumeroCultivo.TabIndex = 13;
            this.lblNumeroCultivo.Text = "Numero Identificador\r\n";
            // 
            // txtNumeroCultivo
            // 
            this.txtNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNumeroCultivo.Location = new System.Drawing.Point(100, 67);
            this.txtNumeroCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroCultivo.Name = "txtNumeroCultivo";
            this.txtNumeroCultivo.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroCultivo.TabIndex = 12;
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNombreCultivo.Location = new System.Drawing.Point(11, 24);
            this.lblNombreCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(75, 32);
            this.lblNombreCultivo.TabIndex = 11;
            this.lblNombreCultivo.Text = "Nombre del cultivo";
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNombreCultivo.Location = new System.Drawing.Point(100, 24);
            this.txtNombreCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCultivo.MaxLength = 5;
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(76, 20);
            this.txtNombreCultivo.TabIndex = 10;
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 166);
            this.Controls.Add(this.mskNumeroCultivo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroCultivo);
            this.Controls.Add(this.txtNumeroCultivo);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.txtNombreCultivo);
            this.Name = "frmCultivos";
            this.Text = "frmCultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNumeroCultivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumeroCultivo;
        private System.Windows.Forms.TextBox txtNumeroCultivo;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.TextBox txtNombreCultivo;
    }
}