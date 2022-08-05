public static class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        static int Solution(int value)
        {
            int sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            return sum;
        }
        Console.WriteLine($"{input} input");
        Console.WriteLine(Solution(input));
    }
}