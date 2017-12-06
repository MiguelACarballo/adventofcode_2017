namespace _05_a_maze_of_twisty_trampolines
{
    using System;
    using System.IO;
 
    class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("./input.txt");
            int[] step = new int[content.Length];
            int jumps = 0;
            int position = 0;

            // part one
            
            for (int i = 0; i < content.Length; i++)
            {
                step[i] = Convert.ToInt32(content[i].ToString());
            }

            
            while(position >= 0 && position < content.Length)
            {
                jumps++;
                position += step[position]++;
            }

            Console.WriteLine(jumps);

            // part two

            jumps = 0;
            position = 0;

            for (int i = 0; i < content.Length; i++)
            {
                step[i] = Convert.ToInt32(content[i].ToString());
            }

            while(position >= 0 && position < content.Length)
            {
                jumps++;
                if(step[position] >= 3)
                {
                    position += step[position]--;
                }
                else
                {
                    position += step[position]++;
                }
            }

            Console.WriteLine(jumps);
        }
    }
}
