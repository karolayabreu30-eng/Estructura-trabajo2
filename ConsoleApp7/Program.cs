using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Digite el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        // Si el primero es mayor, se intercambia
        if (num1 > num2)
        {
            int aux = num1;
            num1 = num2;
            num2 = aux;
        }

        Console.WriteLine("Los múltiplos de 5 entre esos números son: ");

        for (int i = num1; i <= num2; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}
