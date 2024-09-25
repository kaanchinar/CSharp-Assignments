using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        int primeCount = 0;

        for (int i = Math.Min(num1, num2); i <= Math.Max(num1, num2); i++)
        {
            if (IsPrime(i))
            {
                primeCount++;
            }
        }

        if (primeCount > 5)
        {
            Console.WriteLine("The range is too large");
        }
        else
        {
            Console.WriteLine("The range is normal");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}