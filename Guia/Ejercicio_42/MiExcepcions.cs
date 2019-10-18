using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiExcepcions:Exception
    {
        public MiExcepcions(string msj, Exception e) : base(msj, e)
        {

        }
    }
}
