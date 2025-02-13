using System;

class Program
{
    static int SumOfDigits(int n)
    {
        if (n == 0)
            return 0;
        return (n % 10) + SumOfDigits(n / 10);
    }

    static void Main()
    {
        Console.Write("Въведете число: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Сумата на цифрите е: " + SumOfDigits(Math.Abs(number)));
    }
}
