using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        #region Atributos
        private int aniosExperiencia;
        #endregion

        #region Propiedades
        public int AniosExperiencia
        {
            get
            {
                return this.aniosExperiencia;
            }

            set
            {
                this.aniosExperiencia = value;
            }
        }
        #endregion

        #region Constructores
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int aniosExperiencia)
            :base(nombre, apellido, edad, dni)
        {
            this.aniosExperiencia = aniosExperiencia;
        }
        #endregion

        #region Metodos
        public override bool ValidadAptitud()
        {
            return this.aniosExperiencia >= 2 && this.Edad < 65 ? true : false;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DIRECTOR TECNICO");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Anios De Experiencia: {0}\n", this.aniosExperiencia);
            sb.AppendLine("*****************************");
            return sb.ToString();
        }
        #endregion
    }
}
