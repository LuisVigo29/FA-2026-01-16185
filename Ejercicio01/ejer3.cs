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
            Console.Write("Ingrese número 1: ");
            int num1= int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2= int.Parse(Console.ReadLine());    

            Console.WriteLine("\nSuma: "+(num1+num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("División: " + (num1 / num2));
            Console.ReadKey();

        }
    }
}
