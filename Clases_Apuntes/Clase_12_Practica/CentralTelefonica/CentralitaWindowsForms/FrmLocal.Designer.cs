namespace CentralitaWindowsForms
{
    partial class FrmLocal
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
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 265);
            //this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(128, 265);
            //this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(12, 194);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(188, 20);
            this.txtCosto.TabIndex = 8;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(12, 178);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = "Costo:";
            // 
            // FrmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 300);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Name = "FrmLocal";
            this.Text = "FrmLocal";
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNumeroOrigen, 0);
            this.Controls.SetChildIndex(this.txtNumeroDestino, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
    }
}