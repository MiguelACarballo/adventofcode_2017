namespace _06_memory_reallocation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("./input.txt");

            Console.WriteLine(PartOne(input));
            Console.WriteLine(PartTwo(input));
        }

        public static string PartOne(string input)
        {
            var words = input.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            var banks = words.Select(x => int.Parse(x)).ToArray();
            var configs = new List<int[]>();

            while (!configs.Any(x => x.SequenceEqual(banks)))
            {
                configs.Add(banks.ToArray());
                RedistributeBlocks(banks);
            }

            return configs.Count().ToString();
        }

        private static void RedistributeBlocks(int[] banks)
        {
            var idx = banks.ToList().IndexOf(banks.Max());
            var blocks = banks[idx];

            banks[idx++] = 0;

            while (blocks > 0)
            {
                if (idx >= banks.Length)
                {
                    idx = 0;
                }

                banks[idx++]++;
                blocks--;
            }
        }

        public static string PartTwo(string input)
        {
            var words = input.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            var banks = words.Select(x => int.Parse(x)).ToArray();
            var configs = new List<int[]>();

            while (!configs.Any(x => x.SequenceEqual(banks)))
            {
                configs.Add((int[])banks.Clone());
                RedistributeBlocks(banks);
            }

            var seenIndex = configs.IndexOf(configs.First(x => x.SequenceEqual(banks)));
            var steps = configs.Count() - seenIndex;

            return steps.ToString();
        }
    }
}
