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
        }
    }
}
