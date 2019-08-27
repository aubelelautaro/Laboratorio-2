using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO: \n\n\n");

            int diasVividos = 0;
            Console.Write("INGRESE DIA: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("INGRESE MES: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("INGRESE ANIO: ");
            int anio = int.Parse(Console.ReadLine());

           

            int diaActual = DateTime.Now.Day;
            int mesActual = DateTime.Now.Month;
            int anioActual = DateTime.Now.Year;

            
            int flag = 0;

            if (anio == anioActual && mes == mesActual && dia == diaActual)
            {
                diasVividos = 0;
            }
            else
            {
                if(anio != anioActual)
                {
                    while(anio < anioActual)
                    {
                        diasVividos += 365;
                        anio++;
                    }
                }

                if(mes != mesActual)
                {
                    if(mes > mesActual)
                    {
                        diasVividos -= 365;
                        flag = 1;
                    }
                    
                        while (mes < mesActual)
                        {

                         if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            diasVividos += 31;
                        }
                        else
                        {
                            diasVividos += 30;
                        }
                            
                            mes++;
                        }
                    
                }
              
                if(dia != diaActual)
                {
                    if(dia > diaActual || flag == 1)
                    {
                        diasVividos -= 365;

                    }

                    while (dia < diaActual)
                        {
                            diasVividos++;
                            dia++;
                        }
                    
                }
             
                
            }
            


            Console.WriteLine("HOY ES: "+DateTime.Now.ToString());
            Console.WriteLine("USTED HA VIVIDO {0} DIAS", diasVividos);

            Console.ReadKey();
        }
    }
}
