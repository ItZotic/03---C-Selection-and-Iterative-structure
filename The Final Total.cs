using System;

class TenIsTotal
{
    static void Main()
    {
        int total = 10;

        Console.Write("Enter an integer: ");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        if (num > 0)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                total += num * num;
            }
            else
            {
                Console.WriteLine("The number is odd.");
                total += num * num * num;
            }
            Console.WriteLine($"Total: {total}");
        }
        else if (num < 0)
        {
            Console.Write("Enter another integer (exponent): ");
            if (!int.TryParse(Console.ReadLine(), out int exponent))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            try
            {
                double powerResult = Math.Pow(num, exponent);
                if (double.IsInfinity(powerResult) || double.IsNaN(powerResult))
                {
                    Console.WriteLine("The result is too large or invalid.");
                    return;
                }

                total += (int)powerResult;
                Console.WriteLine($"Total: {total}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The calculation resulted in an overflow.");
            }
        }
        else
        {
            Console.WriteLine("NOTHING HAPPENED");
        }
    }
}
