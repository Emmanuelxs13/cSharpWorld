using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversión de Temperatura
            //Descripción: Crea un programa que solicite una temperatura y su tipo de unidad(Celsius o Fahrenheit). Luego, conviértela a la otra unidad y muestra el resultado.
            //Fórmulas:
            //°F = (°C × 9 / 5) +32
            //°C = (°F - 32) × 5 / 9

            //variables

            double temperaturaC, temperaturaF;

            Console.Write("Digite su temperatura en C°: ");
            temperaturaC = Convert.ToDouble(Console.ReadLine());

            temperaturaF = (temperaturaC * 9 / 5) + 32;

            Console.WriteLine($"Su temperatura en Fahrenheit: {temperaturaF}");

            Console.ReadKey();

        }
    }
}
