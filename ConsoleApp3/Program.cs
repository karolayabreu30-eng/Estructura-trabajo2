using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        double num;

        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            num = Convert.ToDouble(Console.ReadLine());
            suma += num;
        }

        
        double media = suma / 5;

        Console.WriteLine("La media aritmética es: " + media);
        Console.ReadLine();
    }
}
