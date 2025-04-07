using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables principales para la cotización
            string nombreCliente; // Almacena el nombre del cliente
            int numAdultos, numPeque; // Contadores de adultos y niños
            int numPersonas; // Total de personas registradas en cada iteración
            int personasGuajira = 0, personasChicamocha = 0, personasLlanos = 0; // Contadores por destino
            string nombreDestino = ""; // Nombre del destino seleccionado
            double subTotalGuajira = 0, subtotalChicamocha = 0, subtotalLlanos = 0, vlrNeto = 0, totalDescuento = 0; // Variables de costos

            // Constantes de precios y descuentos
            const double descuentoN = 0.60; // 60% de descuento para niños sobre el precio de adulto
            const int precioAdultoGuajira = 1980000;
            const int precioAdultoChicamocha = 1600000;
            const int precioAdultoLlanos = 1500000;

            Console.WriteLine("Bienvenido a nuestra agencia");
            Console.WriteLine("1. Deseo Viajar ");
            Console.WriteLine("2. No quiero viajar ");
            int decisionUsuario = Convert.ToInt16(Console.ReadLine());

            if (decisionUsuario == 1)
            {
                bool registrarMasPersonas;
                do
                {
                    Console.Write("Digite la cantidad de personas a registrar: ");
                    numPersonas = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Digite su nombre: ");
                    nombreCliente = Console.ReadLine();

                    Console.WriteLine("Seleccione el destino:");
                    Console.WriteLine("1. Guajira");
                    Console.WriteLine("2. Cañón del Chicamocha");
                    Console.WriteLine("3. Llanos Orientales");
                    int opcionDestino = Convert.ToInt16(Console.ReadLine());

                    switch (opcionDestino)
                    {
                        case 1:
                            nombreDestino = "Guajira";
                            break;
                        case 2:
                            nombreDestino = "Cañón del Chicamocha";
                            break;
                        case 3:
                            nombreDestino = "Llanos Orientales";
                            break;
                        default:
                            Console.WriteLine("Destino inválido. Se asignará 'Desconocido'");
                            nombreDestino = "Desconocido";
                            break;
                    }

                    Console.Write("Digite cuántos adultos hay: ");
                    numAdultos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite cuántos niños hay: ");
                    numPeque = Convert.ToInt32(Console.ReadLine());

                    double subtotal = 0, descuentoAplicado = 0;

                    if (nombreDestino == "Guajira")
                    {
                        personasGuajira += numAdultos + numPeque;
                        subtotal = (numAdultos * precioAdultoGuajira) + (numPeque * precioAdultoGuajira * descuentoN);
                        subTotalGuajira += subtotal;
                    }
                    else if (nombreDestino == "Cañón del Chicamocha")
                    {
                        personasChicamocha += numAdultos + numPeque;
                        subtotal = (numAdultos * precioAdultoChicamocha) + (numPeque * precioAdultoChicamocha * descuentoN);
                        subtotalChicamocha += subtotal;
                    }
                    else if (nombreDestino == "Llanos Orientales")
                    {
                        personasLlanos += numAdultos + numPeque;
                        subtotal = (numAdultos * precioAdultoLlanos) + (numPeque * precioAdultoLlanos * descuentoN);
                        subtotalLlanos += subtotal;
                    }

                    if (numAdultos > 4 && numPeque > 2)
                    {
                        descuentoAplicado = subtotal * 0.20;
                        Console.WriteLine("¡Felicidades! Has obtenido un descuento del 20%");
                    }

                    vlrNeto = subtotal - descuentoAplicado;
                    totalDescuento += descuentoAplicado;

                    Console.WriteLine("\n--- Cotización ---");
                    Console.WriteLine($"Nombre del Cliente: {nombreCliente}");
                    Console.WriteLine($"Destino: {nombreDestino}");
                    Console.WriteLine($"Nro. Personas Adultas: {numAdultos}");
                    Console.WriteLine($"Nro. Niños: {numPeque}");
                    Console.WriteLine($"Subtotal: {subtotal:C}");
                    Console.WriteLine($"Valor Descuento: {descuentoAplicado:C}");
                    Console.WriteLine($"Neto a Pagar: {vlrNeto:C}");
                    Console.WriteLine("-------------------\n");

                    Console.WriteLine("¿Desea registrar más personas? (1: Sí, 2: No)");
                    registrarMasPersonas = Convert.ToInt16(Console.ReadLine()) == 1;

                } while (registrarMasPersonas);

                Console.WriteLine("\n=== Resumen Final ===");
                Console.WriteLine($"Total de personas que viajan a Guajira: {personasGuajira}");
                Console.WriteLine($"Total de personas que viajan a Cañón del Chicamocha: {personasChicamocha}");
                Console.WriteLine($"Total de personas que viajan a Llanos Orientales: {personasLlanos}");
                Console.WriteLine($"Subtotal viajes a Guajira: {subTotalGuajira:C}");
                Console.WriteLine($"Subtotal viajes a Cañón del Chicamocha: {subtotalChicamocha:C}");
                Console.WriteLine($"Subtotal viajes a Llanos Orientales: {subtotalLlanos:C}");
                Console.WriteLine($"Total de descuentos aplicados: {totalDescuento:C}");
                Console.WriteLine($"Total Neto a Pagar: {(subTotalGuajira + subtotalChicamocha + subtotalLlanos - totalDescuento):C}");
            }
            else
            {
                Console.WriteLine("Gracias por visitarnos.");
            }

            Console.ReadKey();
        }
    }
}