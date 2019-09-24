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

namespace WindowsForms
{
    public partial class FrmAlumnoCalificado : Form
    {
        Alumno alumno;
        AlumnoCalificado alumnoCalificado;

        public AlumnoCalificado AlumnoCalificado
        {
            get
            {
                return this.alumnoCalificado;
            }
        }
       

        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoDeExamen.Enabled = false;
            this.txtNota.Focus();
        }

        public FrmAlumnoCalificado(Alumno a):this()
        {
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.txtNombre.Text = a.Nombre;
            this.alumno = a;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int nota;
            if(int.TryParse(this.txtNota.Text, out nota))
            {
                if(nota >= 0 && nota <= 10)
                {
                    alumnoCalificado = new AlumnoCalificado(this.alumno, nota);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La nota debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult= DialogResult.Cancel;
            this.Close();

        }
    }
}
