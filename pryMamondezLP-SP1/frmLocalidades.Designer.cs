namespace pryMamondezLP_SP1
{
    partial class frmLocalidades
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
            this.mskNumeroLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumeroLocalidad = new System.Windows.Forms.Label();
            this.txtNumeroLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskNumeroLocalidad
            // 
            this.mskNumeroLocalidad.Location = new System.Drawing.Point(101, 77);
            this.mskNumeroLocalidad.Mask = "99999";
            this.mskNumeroLocalidad.Name = "mskNumeroLocalidad";
            this.mskNumeroLocalidad.Size = new System.Drawing.Size(76, 20);
            this.mskNumeroLocalidad.TabIndex = 14;
            this.mskNumeroLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNumeroLocalidad_MaskInputRejected);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(121, 128);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 26);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumeroLocalidad
            // 
            this.lblNumeroLocalidad.Location = new System.Drawing.Point(22, 69);
            this.lblNumeroLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroLocalidad.Name = "lblNumeroLocalidad";
            this.lblNumeroLocalidad.Size = new System.Drawing.Size(75, 40);
            this.lblNumeroLocalidad.TabIndex = 12;
            this.lblNumeroLocalidad.Text = "Numero identificador de la localidad";
            // 
            // txtNumeroLocalidad
            // 
            this.txtNumeroLocalidad.Location = new System.Drawing.Point(101, 77);
            this.txtNumeroLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroLocalidad.Name = "txtNumeroLocalidad";
            this.txtNumeroLocalidad.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroLocalidad.TabIndex = 11;
            this.txtNumeroLocalidad.TextChanged += new System.EventHandler(this.txtNumeroLocalidad_TextChanged);
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.Location = new System.Drawing.Point(22, 26);
            this.lblNombreLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(75, 29);
            this.lblNombreLocalidad.TabIndex = 10;
            this.lblNombreLocalidad.Text = "Nombre de la localidad";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(101, 26);
            this.txtNombreLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreLocalidad.MaxLength = 0;
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(76, 20);
            this.txtNombreLocalidad.TabIndex = 9;
            this.txtNombreLocalidad.TextChanged += new System.EventHandler(this.txtNombreLocalidad_TextChanged);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 185);
            this.Controls.Add(this.mskNumeroLocalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroLocalidad);
            this.Controls.Add(this.txtNumeroLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Name = "frmLocalidades";
            this.Text = "frmLocalidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNumeroLocalidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumeroLocalidad;
        private System.Windows.Forms.TextBox txtNumeroLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
    }
}