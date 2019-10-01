using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31.Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;


        public static int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual++;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        private PuestoAtencion()
        {
           
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(1000);
            return true;
        }
        
    }
}
