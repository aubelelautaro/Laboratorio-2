namespace Clase_04.WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEntero = new System.Windows.Forms.Label();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Location = new System.Drawing.Point(113, 70);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(38, 13);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(250, 70);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(278, 20);
            this.txtEntero.TabIndex = 1;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(113, 113);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 2;
            this.lblCadena.Text = "Cadena";
            this.lblCadena.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(250, 110);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(278, 20);
            this.txtCadena.TabIndex = 3;
            this.txtCadena.TextChanged += new System.EventHandler(this.txtCadena_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(113, 159);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(250, 152);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(278, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(119, 250);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(409, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(119, 289);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(409, 95);
            this.lstLista.TabIndex = 7;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 396);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.lblEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstLista;
    }
}

