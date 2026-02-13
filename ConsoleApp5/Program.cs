using System;

class Program
{
    static void Main()
    {
        int num;
        int mayor = int.MinValue; // Valor inicial muy pequeño

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > mayor)
            {
                mayor = num;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.ReadLine();
    }
}
