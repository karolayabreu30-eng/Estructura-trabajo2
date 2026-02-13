using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Solicitar al usuario un número
            Console.Write("Ingrese un número para contar los pares hasta ese límite: ");
            int limite = int.Parse(Console.ReadLine());

            int contadorPares = 0;

            // 2. Usar un bucle FOR para recorrer desde 1 hasta el número ingresado
            for (int i = 1; i <= limite; i++)
            {
                // Verificar si el número es par usando el operador residuo (%)
                if (i % 2 == 0)
                {
                    contadorPares++;
                }
            }

            // 3. Mostrar el resultado
            Console.WriteLine("\nEntre 1 y " + limite + " hay " + contadorPares + " números pares.");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}