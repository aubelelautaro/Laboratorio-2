using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmVista : Form
    {

        private Curso curso;
        private Profesor profesor;

        public FrmVista()
        {
            InitializeComponent();
            this.nudAnio.Minimum = 1;
            this.nudAnio.Maximum = 4;
            this.nudAnioCurso.Minimum = 1;
            this.nudAnioCurso.Maximum = 4;
            this.cboDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            this.cboDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));

        }

        private void BtnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            this.profesor = new Profesor(this.txtNombreProfe.Text, this.txtApellidoProfe.Text, this.txtDocumentoProfe.Text, this.dateTimePicker1.Value);

            if (Enum.TryParse<Divisiones>(cboDivisionCurso.SelectedValue.ToString(), out division))
            {
                 this.curso = new Curso((short)nudAnioCurso.Value, division, profesor);
                 this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El formato no es correcto");
            }
        
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (!(curso is null))
            {
                this.rtbDatos.Text = (string)curso;
            }
            else
            {
                MessageBox.Show("No se ha creado un curso aun");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(!(curso is null))
            {
                this.curso += new Alumno(this.txtNombre.Text, this.txtApellido.Text, this.txtDocumento.Text, (short)this.nudAnio.Value, (Divisiones)this.cboDivision.SelectedItem);
                this.rtbDatos.Text = (string)this.curso;
            }
            else
            {
                MessageBox.Show("No se pudo agregar al curso");
            }
        }
    }
}
