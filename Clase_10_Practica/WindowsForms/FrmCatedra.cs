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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;

        public FrmCatedra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOrdenar.DataSource = Enum.GetValues(typeof(Catedra.ETipoOrdenamiento));
            this.cmbOrdenar.SelectedIndex = 0;
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.catedra = new Catedra();
            this.btnCalificar.Enabled = false;
            this.DialogResult = DialogResult.Yes;
            
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frm = new FrmAlumno();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK) {

                if(this.catedra + frm.Alumno)
                {
                    this.lstAlumnos.Items.Add(Alumno.Mostrar(frm.Alumno));
                    this.btnCalificar.Enabled = true;
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Error no se puede agregar el alumno");
                }
               
            }
        }

        private void ActualizarListadoAlumnos()
        {
            this.lstAlumnos.Items.Clear();
            foreach(Alumno a in this.catedra.Alumnos)
            {
                this.lstAlumnos.Items.Add(a);
            }
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlumnos.SelectedIndex;
            FrmAlumnoCalificado frm = new FrmAlumnoCalificado(this.catedra.Alumnos[indice]);
            frm.ShowDialog();
        }
    }
}
