using System;

class Program
{
    static void Main()
    {
        int num;
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            else
            {
                ceros++;
            }
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);

        Console.ReadKey();
    }
}
