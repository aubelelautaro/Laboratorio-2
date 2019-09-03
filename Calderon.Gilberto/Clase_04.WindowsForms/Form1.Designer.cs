namespace Clase_04.WindowsForms
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Location = new System.Drawing.Point(112, 28);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(38, 13);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(250, 28);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(278, 20);
            this.txtEntero.TabIndex = 1;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(112, 58);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 2;
            this.lblCadena.Text = "Cadena";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(250, 58);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(278, 20);
            this.txtCadena.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(113, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(250, 84);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(278, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(116, 121);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(412, 23);
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
            this.lstLista.Location = new System.Drawing.Point(116, 150);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(412, 82);
            this.lstLista.TabIndex = 7;

            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(432, 249);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(116, 249);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(96, 23);
            this.btnRojo.TabIndex = 9;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.BtnRojo_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(166, 290);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(96, 23);
            this.btnAzul.TabIndex = 10;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.BtnAzul_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(231, 249);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(96, 23);
            this.btnNegro.TabIndex = 11;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 335);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnLimpiar);
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnNegro;
    }
}

