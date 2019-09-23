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
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }

        public FrmAlumno()
        {
            InitializeComponent();
            this.cmbTipoDeExamen.DataSource = Enum.GetValues(typeof(Alumno.ETipoExamen));
            this.cmbTipoDeExamen.SelectedItem = Alumno.ETipoExamen.Final;
            this.cmbTipoDeExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int legajo;
            if(!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text) 
                && int.TryParse(this.txtLegajo.Text, out legajo))
            {
                alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, legajo, (Alumno.ETipoExamen)this.cmbTipoDeExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El formato ingresado no es correcto", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
