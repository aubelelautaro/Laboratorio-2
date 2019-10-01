using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37.Entidades
{
    
        public abstract class Llamada
        {
            #region Atributos
            protected float _duracion;
            protected string _nroDestino;
            protected string _nroOrigen;
            #endregion


            #region Propiedades

            public abstract float CostoLlamada
            {
                get;
            }

            public float Duracion
            {
                get
                {
                    return this._duracion;
                }
            }

            public string NroDestino
            {
                get
                {
                    return this._nroDestino;
                }
            }

            public string NroOrigen
            {
                get
                {
                    return this._nroOrigen;
                }
            }

            #endregion

            #region Constructor
            public Llamada(string origen, string destino, float duracion)
            {
                this._nroOrigen = origen;
                this._nroDestino = destino;
                this._duracion = duracion;
            }
            #endregion

            #region Metodos

            protected virtual string Mostrar()
            {
                StringBuilder sb = new StringBuilder();

                if (!Object.ReferenceEquals(this, null))
                {
                    sb.Append($"Duracion: {this._duracion}, Nro de Origen: {this._nroOrigen}, Nro de Destino: {this._nroDestino},");
                }
                else
                {
                    sb.AppendLine("Llamada inexistente");
                }

                return sb.ToString();
            }

            public int OrdenarPorDuracion(Llamada uno, Llamada dos)
            {
                int retorno = 0;

                if (uno._duracion > dos._duracion)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = -1;
                }

                return retorno;
            }

            #endregion

            #region Sobrecarga de Operadores

            public static bool operator ==(Llamada uno, Llamada dos)
            {
                bool retorno = false;

                if (!Object.ReferenceEquals(uno, null) && !Object.ReferenceEquals(dos, null))
                {
                    if (uno.Equals(dos))
                    {
                        if (string.Compare(uno._nroOrigen, dos._nroOrigen) == 0
                             && string.Compare(uno._nroDestino, dos._nroDestino) == 0)
                        {
                            retorno = true;
                        }
                    }
                }

                return retorno;
            }

            public static bool operator !=(Llamada uno, Llamada dos)
            {
                return !(uno == dos);
            }
            #endregion
        }
    
}
