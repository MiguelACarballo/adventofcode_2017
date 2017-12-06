namespace _03_spiral_memory
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int input = 289326;

            int square = (int)Math.Sqrt(input);
            int center = (square - 1) / 2;
            int steps = Math.Max(0, center - 1 + Math.Abs(center - input % square));

            Console.WriteLine(steps);
        }
    }
}
