using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la temperatura en Celsius: ");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + (32);

            Console.WriteLine(c + "ºC es equivalente ha " + f + "ºF");

            Console.ReadLine();
        }
    }
}
