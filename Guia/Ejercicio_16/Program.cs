using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno alumnoUno = new Alumno("Gilberto", "Calderon", 124032);
            Alumno alumnoDos = new Alumno("Juan", "Perez", 11024);
            Alumno alumnoTres = new Alumno("Pedro", "Perez", 10234);

            alumnoUno.Estudiar(2, 4);
            alumnoDos.Estudiar(10, 10);
            alumnoTres.Estudiar(10, 2);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());

            Console.ReadKey();
        }
    }
}
