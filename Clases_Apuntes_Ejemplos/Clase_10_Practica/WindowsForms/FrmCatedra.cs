﻿using System;
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
            this.catedra = new Catedra();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach(Catedra.ETipoOrdenamiento value in Enum.GetValues(typeof(Catedra.ETipoOrdenamiento)))
            {
                this.cmbOrdenar.Items.Add(value);
            }
            this.cmbOrdenar.SelectedIndex = 0;
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    //this.lstAlumnos.Items.Add(Alumno.Mostrar(frm.Alumno));
                    this.ActualizarListadoAlumnos();
                    this.btnCalificar.Enabled = true;
                    
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
                this.lstAlumnos.Items.Add(Alumno.Mostrar(a));
            }
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlumnos.SelectedIndex;
           

            if (indice >= 0)
            {
                Alumno alumno = this.catedra.Alumnos[indice];
                FrmAlumnoCalificado frm = new FrmAlumnoCalificado(alumno);
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    if (frm.AlumnoCalificado.Nota > 5)
                    {
                        if (this.catedra - this.catedra.Alumnos[indice])
                        {
                            this.ActualizarListadoAlumnos();
                            this.lstAlumnosCalificados.Items.Add(alumno.ToString());
                        }
                        //this.lstAlumnos.Items.RemoveAt(indice);
                        //this.lstAlumnosCalificados.Items.Add(AlumnoCalificado.Mostrar(frm.AlumnoCalificado));
                    }
                }
            }
        }

        private void CmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                switch (this.cmbOrdenar.SelectedIndex)
                {
                    case 0:
                        this.catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                        break;

                    case 1:
                        this.catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                        break;

                    case 2:
                        this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                        break;

                    case 3:
                        this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                        break;

                    default:
                        break;
                }

                this.ActualizarListadoAlumnos();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlumnos.SelectedIndex;

            if (indice >= 0)
            {
                FrmAlumno frm = new FrmAlumno(this.catedra.Alumnos[indice]);
                frm.ShowDialog();
                
                if(frm.DialogResult == DialogResult.OK)
                {
                    if (this.catedra - this.catedra.Alumnos[indice])
                    {
                        if(this.catedra + frm.Alumno)
                        {
                            this.ActualizarListadoAlumnos();
                            MessageBox.Show("Se ha hecho la modificacion correctamente");
                        }
                    }         
                }
            }
         }
           
            
    }
    
}
