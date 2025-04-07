// Importamos el espacio de nombres System, que contiene clases básicas de C#
using System;

// Declaramos una clase llamada ProgramaMatriz, que contiene toda la lógica del programa
class ProgramaMatriz
{
    // Método principal del programa, donde todo inicia
    static void Main()
    {
        // Creamos y llenamos una matriz de 5x5 con números aleatorios
        int[,] matriz = CrearMatriz();

        // Creamos una variable booleana para controlar cuándo salir del menú
        bool salir = false;

        // Ciclo que mantiene el programa corriendo hasta que el usuario elija salir
        while (!salir)
        {
            // Mostramos las opciones del menú
            MostrarMenu();

            // Leemos la opción que el usuario escribe en la consola
            string opcion = Console.ReadLine();

            // Usamos switch para ejecutar la acción según la opción elegida
            switch (opcion)
            {
                case "1":
                    // Imprimir la matriz completa
                    ImprimirMatriz(matriz);
                    break;

                case "2":
                    // Pedimos al usuario el número de columna (de 0 a 4)
                    Console.Write("Ingrese el número de columna (0 a 4): ");
                    int col = Convert.ToInt32(Console.ReadLine());
                    ImprimirColumna(matriz, col);
                    break;

                case "3":
                    // Pedimos al usuario el número de fila (de 0 a 4)
                    Console.Write("Ingrese el número de fila (0 a 4): ");
                    int fila = Convert.ToInt32(Console.ReadLine());
                    ImprimirFila(matriz, fila);
                    break;

                case "4":
                    // Imprimir la diagonal principal (de izquierda a derecha)
                    ImprimirDiagonalPrincipal(matriz);
                    break;

                case "5":
                    // Imprimir la diagonal secundaria (de derecha a izquierda)
                    ImprimirDiagonalSecundaria(matriz);
                    break;

                case "6":
                    // Salimos del ciclo y terminamos el programa
                    salir = true;
                    break;

                default:
                    // En caso de que la opción no sea válida
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }

        // Mensaje de despedida
        Console.WriteLine("¡Fin del programa!");
    }

    // Muestra el menú de opciones en la consola
    static void MostrarMenu()
    {
        Console.WriteLine("\n======= MENÚ =======");
        Console.WriteLine("1. Imprimir la matriz completa");
        Console.WriteLine("2. Imprimir una columna específica");
        Console.WriteLine("3. Imprimir una fila específica");
        Console.WriteLine("4. Imprimir la diagonal principal");
        Console.WriteLine("5. Imprimir la diagonal secundaria");
        Console.WriteLine("6. Salir");
        Console.Write("Elija una opción (1-6): ");
    }

    // Función que crea y llena una matriz 5x5 con números aleatorios del 1 al 100
    static int[,] CrearMatriz()
    {
        // Declaramos una matriz de 5 filas y 5 columnas
        int[,] matriz = new int[5, 5];

        // Creamos un generador de números aleatorios
        Random aleatorio = new Random();

        // Recorremos cada fila
        for (int fila = 0; fila < 5; fila++)
        {
            // Recorremos cada columna de la fila actual
            for (int columna = 0; columna < 5; columna++)
            {
                // Asignamos un número aleatorio entre 1 y 100 a esa posición
                matriz[fila, columna] = aleatorio.Next(1, 101); // 101 porque el límite superior es exclusivo
            }
        }

        // Retornamos la matriz ya llena
        return matriz;
    }

    // Imprime todos los elementos de la matriz en formato de tabla
    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("\nMatriz completa:");

        // Recorremos filas
        for (int fila = 0; fila < 5; fila++)
        {
            // Recorremos columnas
            for (int columna = 0; columna < 5; columna++)
            {
                // Imprimimos el número en formato de 3 dígitos (ej: 001, 100, etc.)
                Console.Write(matriz[fila, columna].ToString("D3") + " ");
            }

            // Salto de línea después de imprimir cada fila
            Console.WriteLine();
        }
    }

    // Imprime una columna específica de la matriz
    static void ImprimirColumna(int[,] matriz, int columna)
    {
        // Verificamos que el número de columna sea válido (entre 0 y 4)
        if (columna >= 0 && columna < 5)
        {
            Console.WriteLine($"\nColumna {columna}:");

            // Recorremos las filas y mostramos solo la columna indicada
            for (int fila = 0; fila < 5; fila++)
            {
                Console.WriteLine(matriz[fila, columna]);
            }
        }
        else
        {
            // Mensaje de error si la columna está fuera del rango permitido
            Console.WriteLine("Número de columna fuera de rango (0-4).");
        }
    }

    // Imprime una fila específica de la matriz
    static void ImprimirFila(int[,] matriz, int fila)
    {
        // Verificamos que el número de fila sea válido (entre 0 y 4)
        if (fila >= 0 && fila < 5)
        {
            Console.WriteLine($"\nFila {fila}:");

            // Recorremos las columnas de la fila indicada
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }

            // Salto de línea al final
            Console.WriteLine();
        }
        else
        {
            // Mensaje de error si la fila está fuera del rango permitido
            Console.WriteLine("Número de fila fuera de rango (0-4).");
        }
    }

    // Imprime la diagonal principal (de izquierda a derecha)
    static void ImprimirDiagonalPrincipal(int[,] matriz)
    {
        Console.WriteLine("\nDiagonal principal:");

        // La diagonal principal va de [0,0] a [4,4]
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }

    // Imprime la diagonal secundaria (de derecha a izquierda)
    static void ImprimirDiagonalSecundaria(int[,] matriz)
    {
        Console.WriteLine("\nDiagonal secundaria:");

        // La diagonal secundaria va de [0,4] a [4,0]
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, 4 - i]);
        }
    }
}
