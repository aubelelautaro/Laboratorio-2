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

    public partial class FrmAlumnoCalificado : FrmAlumno
    {

        private AlumnoCalificado alumnoCalificado;
        private Alumno alumno;

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
            base.txtNombre.Enabled = false;
            base.txtLegajo.Enabled = false;
            base.txtApellido.Enabled = false;
            base.cmbTipoDeExamen.Enabled = false;
        }
        public FrmAlumnoCalificado(Alumno a) : this()
        {
            this.alumno = a;
            base.txtNombre.Text = a.Apellido;
            base.txtLegajo.Text = a.Legajo.ToString();
            base.txtApellido.Text = a.Apellido;
            
        }


        protected override void BtnAceptar_Click(object sender, EventArgs e)
        {
            int nota;

            if(int.TryParse(this.txtNota.Text,out nota))
            {
                this.alumnoCalificado = new AlumnoCalificado(this.alumno, nota);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        protected override void BtnCancelar_Click(object sender, EventArgs e)
        {
            base.BtnCancelar_Click(sender, e);
        }
    }
        
}
