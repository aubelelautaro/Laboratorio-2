using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;
        
        public string this[int i]
        {
            get
            {
                if (i > -1)
                    return this.paginas[i];
                else
                    return "";
            }

            set
            {
                if (i > this.paginas.Count)
                     this.paginas.Add(value);
                    
            }
        }
    }
}
