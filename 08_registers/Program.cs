namespace _08_registers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("./input.txt");
            string[] lines = {};
            Dictionary<string,int> vars = new Dictionary<string,int>();
            int highest = 0;

            // part one

            for (int i = 0; i < input.Length; i++)
            {
                lines = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                vars.TryAdd(lines[0], 0);
            }

            for (int i = 0; i < input.Length; i++)
            {
                lines = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (lines[5])
                {
                    case "<":
                    {
                        if(vars[lines[4]] < Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    case ">":
                    {
                        if(vars[lines[4]] > Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    case "==":
                    {
                        if(vars[lines[4]] == Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    case "<=":
                    {
                        if(vars[lines[4]] <= Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    case ">=":
                    {
                        if(vars[lines[4]] >= Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    case "!=":
                    {
                        if(vars[lines[4]] != Int32.Parse(lines[6]))
                        {
                            if(lines[1] == "inc")
                            {
                                vars[lines[0]] += Int32.Parse(lines[2]);
                            }
                            else
                            {
                                vars[lines[0]] -= Int32.Parse(lines[2]);
                            }
                        }
                        break;
                    }
                    default:
                        break;
                }

                // part two
                if(vars.Values.Max() > highest)
                {
                    highest = vars.Values.Max();
                }
            }
            // part two
            Console.WriteLine(highest);
            // part one
            Console.WriteLine(vars.Values.Max());
        }
    }
}
