using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int mayor = Math.Max(num1, num2);
        int mcm = mayor;
              
        while (true)
        {
            if (mcm % num1 == 0 && mcm % num2 == 0)
            {
                break;
            }
            mcm += mayor;
        }

        Console.WriteLine("El Mínimo Común Múltiplo (MCM) es: " + mcm);
        Console.ReadLine();
    }
}
