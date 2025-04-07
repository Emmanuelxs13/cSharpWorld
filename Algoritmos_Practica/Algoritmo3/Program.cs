using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una escuela desea desarrollar un sistema para gestionar las calificaciones de sus estudiantes.
            //El programa debe permitir ingresar el nombre del estudiante, la cantidad de materias cursadas y las calificaciones de cada materia.
            //Luego, debe calcular el promedio y mostrar un mensaje indicando si el estudiante aprobó o reprobó.

            // Requisitos:
            // 1. Solicitar el nombre del estudiante.
            // 2. Pedir la cantidad de materias que cursa.
            // 3. Registrar las calificaciones de cada materia.
            // 4. Calcular el promedio de las calificaciones.
            // 5. Mostrar el promedio obtenido.
            // 6. Indicar si el estudiante aprueba o reprueba(aprueba si el promedio es mayor o igual a 3.0).

            //Variables
            string nameEstudiante, nameMateria, estado;
            int cantidadMaterias = 0, cantNotas = 0;
            double promedio, calificaciones = 0;

            Console.Write("Digite su nombre completo: ");
            nameEstudiante = Console.ReadLine();

            Console.Write("Digite la cantidad de materias que está cursando: ");
            cantidadMaterias = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < cantidadMaterias; i++)
            {
                Console.Write("Digite el nombre de la materia: ");
                nameMateria = Console.ReadLine();

                Console.Write("Digite la calificación de la materia: ");
                calificaciones = Convert.ToDouble(Console.ReadLine());

               
                cantNotas++;
            }

            promedio = calificaciones / cantNotas;

            if (promedio >= 3.0)
            {
                estado = "Aprobado";
            }
            else
            {
                estado = "Desaprobado";
            }



            Console.WriteLine("Resultados");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Estado: {estado}");

        }
    }
}
