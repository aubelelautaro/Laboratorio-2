namespace VistaForm
{
    partial class FrmVista
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
            this.gpbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.cboDivision = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.cboDivisionCurso = new System.Windows.Forms.ComboBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosAlumnos
            // 
            this.gpbDatosAlumnos.Controls.Add(this.cboDivision);
            this.gpbDatosAlumnos.Controls.Add(this.nudAnio);
            this.gpbDatosAlumnos.Controls.Add(this.txtDocumento);
            this.gpbDatosAlumnos.Controls.Add(this.txtApellido);
            this.gpbDatosAlumnos.Controls.Add(this.txtNombre);
            this.gpbDatosAlumnos.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumnos.Controls.Add(this.label11);
            this.gpbDatosAlumnos.Controls.Add(this.label10);
            this.gpbDatosAlumnos.Controls.Add(this.label9);
            this.gpbDatosAlumnos.Controls.Add(this.label8);
            this.gpbDatosAlumnos.Controls.Add(this.label7);
            this.gpbDatosAlumnos.Location = new System.Drawing.Point(399, 12);
            this.gpbDatosAlumnos.Name = "gpbDatosAlumnos";
            this.gpbDatosAlumnos.Size = new System.Drawing.Size(389, 297);
            this.gpbDatosAlumnos.TabIndex = 1;
            this.gpbDatosAlumnos.TabStop = false;
            this.gpbDatosAlumnos.Text = "Datos Alumno";
            // 
            // cboDivision
            // 
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.Location = new System.Drawing.Point(75, 145);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.Size = new System.Drawing.Size(142, 21);
            this.cboDivision.TabIndex = 10;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(75, 119);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(142, 20);
            this.nudAnio.TabIndex = 9;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(75, 89);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(264, 20);
            this.txtDocumento.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(75, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(264, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(235, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 48);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Division";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Anio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Legajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anio";
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.dateTimePicker1);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrearCurso);
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.cboDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDatosCurso.Controls.Add(this.label6);
            this.gpbDatosCurso.Controls.Add(this.label5);
            this.gpbDatosCurso.Controls.Add(this.label4);
            this.gpbDatosCurso.Controls.Add(this.label3);
            this.gpbDatosCurso.Controls.Add(this.label2);
            this.gpbDatosCurso.Controls.Add(this.label1);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(381, 297);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(185, 237);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 48);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(10, 237);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(110, 48);
            this.btnCrearCurso.TabIndex = 12;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.BtnCrearCurso_Click);
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(123, 151);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(220, 20);
            this.txtDocumentoProfe.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(123, 120);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(220, 20);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(123, 93);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(220, 20);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // cboDivisionCurso
            // 
            this.cboDivisionCurso.FormattingEnabled = true;
            this.cboDivisionCurso.Location = new System.Drawing.Point(123, 63);
            this.cboDivisionCurso.Name = "cboDivisionCurso";
            this.cboDivisionCurso.Size = new System.Drawing.Size(220, 21);
            this.cboDivisionCurso.TabIndex = 7;
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(123, 28);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(220, 20);
            this.nudAnioCurso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 315);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(776, 219);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // FrmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDatosAlumnos);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "FrmVista";
            this.Text = "Form1";
            this.gpbDatosAlumnos.ResumeLayout(false);
            this.gpbDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosAlumnos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.ComboBox cboDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDivision;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

