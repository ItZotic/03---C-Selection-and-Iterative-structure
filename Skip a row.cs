using System;

class PatternMaking
{
    static void Main()
    {
        try
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) throw new Exception("n must be a positive integer.");

            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == y) continue;
                Console.WriteLine(new string('*', n * 2 - 1));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Invalid input: {e.Message}");
        }
    }
}
