using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Sistema de conversión de mondeda-----");
            Console.WriteLine("Ingrese el monto en soles: ");
            double soles=double.Parse(Console.ReadLine());

            Console.WriteLine("*****Menú de opciones*****");
            Console.WriteLine("1.Dolares");
            Console.WriteLine("2.Euros");
            Console.WriteLine("--------------------------");

            Console.WriteLine("\nIngrese una opción");
            int opc=int.Parse(Console.ReadLine());
            switch (opc) 
            {
                case 0:
                    double dolares;
                    dolares = soles / 3.75;
                    Console.WriteLine("Dolares: "+Math.Round(dolares));
                break;

                case 1:
                    double euro;
                    euro = soles / 3.75;
                    Console.WriteLine("Euros: "+Math.Round(euro,1));
                break;
                default: Console.WriteLine("\nOpción incorrecta");break;
            }


            
        }
    }
}
