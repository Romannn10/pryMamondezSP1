namespace pryMamondezLP_SP1
{
    partial class frmProduccion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarLocalidad = new System.Windows.Forms.Label();
            this.lblProduccionToneladas = new System.Windows.Forms.Label();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(123, 114);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 22);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Location = new System.Drawing.Point(22, 53);
            this.lblTipoCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(39, 13);
            this.lblTipoCultivo.TabIndex = 12;
            this.lblTipoCultivo.Text = "Cultivo";
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(89, 53);
            this.lstCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(92, 21);
            this.lstCultivo.TabIndex = 11;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(89, 22);
            this.lstLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(92, 21);
            this.lstLocalidad.TabIndex = 10;
            // 
            // lblSeleccionarLocalidad
            // 
            this.lblSeleccionarLocalidad.AutoSize = true;
            this.lblSeleccionarLocalidad.Location = new System.Drawing.Point(22, 22);
            this.lblSeleccionarLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarLocalidad.Name = "lblSeleccionarLocalidad";
            this.lblSeleccionarLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblSeleccionarLocalidad.TabIndex = 9;
            this.lblSeleccionarLocalidad.Text = "Localidad";
            // 
            // lblProduccionToneladas
            // 
            this.lblProduccionToneladas.AutoSize = true;
            this.lblProduccionToneladas.Location = new System.Drawing.Point(22, 83);
            this.lblProduccionToneladas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduccionToneladas.Name = "lblProduccionToneladas";
            this.lblProduccionToneladas.Size = new System.Drawing.Size(57, 13);
            this.lblProduccionToneladas.TabIndex = 8;
            this.lblProduccionToneladas.Text = "Toneladas";
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(89, 83);
            this.txtToneladas.Margin = new System.Windows.Forms.Padding(2);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(92, 20);
            this.txtToneladas.TabIndex = 7;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 163);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipoCultivo);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblSeleccionarLocalidad);
            this.Controls.Add(this.lblProduccionToneladas);
            this.Controls.Add(this.txtToneladas);
            this.Name = "frmProduccion";
            this.Text = "frmProduccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Label lblSeleccionarLocalidad;
        private System.Windows.Forms.Label lblProduccionToneladas;
        private System.Windows.Forms.TextBox txtToneladas;
    }
}