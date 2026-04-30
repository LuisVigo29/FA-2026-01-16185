using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Sistema de calculo de areas-----\n");
   
            Console.WriteLine("*****Menú de opciones*****");
            Console.WriteLine("1.Cuadrado");
            Console.WriteLine("2.Rectámgulo");
            Console.WriteLine("3.Triangulo");
            Console.WriteLine("4.Circulo\n");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            double area;
            switch (opc)
            {
                case 1:
                    
                    Console.WriteLine("Ingrese el lado: ");
                    int lc=int.Parse(Console.ReadLine());
                    area= lc*lc;
                    Console.WriteLine("Area del cuadrado es "+ (area));
                    break;

                case 2:

                    Console.WriteLine("Ingrese la base: ");
                    int bs = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura");
                    int al = int.Parse(Console.ReadLine());
                    area = bs * al;
                    Console.WriteLine("Area del rectangulo es " + (area));   
                    break;
                case 3:

                    Console.WriteLine("Ingrese la base: ");
                    int bt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura");
                    int alt = int.Parse(Console.ReadLine());
                    area = bt * alt/2;
                    Console.WriteLine("Area del Triangulo es " + (area));
                    break;
                case 4:

                    Console.WriteLine("Ingrese el Radio: ");
                    int rc = int.Parse(Console.ReadLine());
                    area=Math.PI*Math.Pow(rc,2);
                    Console.WriteLine("Area del circulo es " + (area));
                    break;
                default: Console.WriteLine("\nOpción incorrecta"); break;
            }
            Console.ReadKey();
        }
    }
}
