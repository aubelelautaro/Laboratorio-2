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
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text))
            {
                dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, int.Parse(numericUpDownEdad.Value.ToString()), int.Parse(textBox1.Text) , int.Parse(numericUpDownExperiencia.Value.ToString()));
            }
            else
            {
                MessageBox.Show("Los campos de texto no deben estar vacios");
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if(!(dt is null))
            {
                if (dt.ValidadAptitud())
                {
                    MessageBox.Show("EL DT ES APTO");
                }
                else
                {
                    MessageBox.Show("EL DT NO ES APTO");
                }
            }
            else
            {
                MessageBox.Show("AUN NO SE HA CREADO EL DT FORMULARIO");
            }
           
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
