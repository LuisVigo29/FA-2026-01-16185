using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int ed=int.Parse(Console.ReadLine());

            if (ed < 18) Console.WriteLine("\nMenor de edad");
            else if (ed <= 64) Console.WriteLine("\nMayor de edad");
            else Console.WriteLine("\nAdulto mayor");

            Console.ReadKey();
        }
    }
}
