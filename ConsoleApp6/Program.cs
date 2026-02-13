using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números desea ingresar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int num;
        int contadorPrimos = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            num = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(num))
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + contadorPrimos);
        Console.ReadLine();
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
