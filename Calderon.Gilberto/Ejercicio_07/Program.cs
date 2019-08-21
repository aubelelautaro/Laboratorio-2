using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO: \n\n\n");

            int diasVividos = 0;
            Console.Write("INGRESE DIA: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("INGRESE MES: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("INGRESE ANIO: ");
            int anio = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(anio, mes, dia);
            int auxDia = dia;
            int auxMes = mes;
            int auxAnio = anio;
            

            for(; anio < DateTime.Now.Year; anio++)
            {
                if(fecha == DateTime.Now)
                {
                    break;
                }

                if(anio != DateTime.Now.Year)
                {
                    if(anio % 4 == 0)
                    {
                        diasVividos += 366;
                    }
                    else
                    {
                        diasVividos += 365;
                    }
                }

                if(mes != DateTime.Now.Month)
                {
                    if(anio % 4 == 0)
                    {
                        diasVividos += 29;
                    }
                    else if(anio == 1 || anio == 3 || anio == 5 || anio == 7 || anio == 8 || anio == 10 || anio == 12)
                    {
                        diasVividos += 30;
                    }
                    else
                    {
                        diasVividos += 31;
                    }
                }

                
            }


            Console.WriteLine("HOY ES: "+DateTime.Now.ToString());
            Console.WriteLine("USTED HA VIVIDO {0} DIAS", diasVividos);

            Console.ReadKey();
        }
    }
}
