using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");
            Local local = new Local("00123112", 30, "12123123", 2.65f);
            Local local2= new Local("23213122", 45f, "123142424", 1.99f);
            Provincial provincial = new Provincial("12314124123", Franja.Franja_1, 21f, "112343123");
            Provincial provincial2 = new Provincial(Franja.Franja_3, provincial); 

            centralita += local;
            centralita += provincial;
            centralita += local2;
            centralita += provincial2;
            
            Console.Write(centralita.ToString());

            
            

            Console.ReadLine();
        }
    }
}
