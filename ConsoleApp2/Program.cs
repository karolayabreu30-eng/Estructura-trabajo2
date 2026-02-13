using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite un número: ");
        int num = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 1;

        while (i < num)
        {
            if (num % i == 0)
            {
                suma += i;
            }
            i++;
        }

        if (suma == num)
        {
            Console.WriteLine("El número " + num + " es un número perfecto.");
        }
        else
        {
            Console.WriteLine("El número " + num + " no es un número perfecto.");
        }

        Console.ReadKey();
    }
}
