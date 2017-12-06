namespace _04_high_entropy_passphrases
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("./input.txt");
            string[] words;
            string currWord;
            string currAnagram;
            string checkAnagram;
            int counter = 0;


            // part one
            for (int i = 0; i < content.Length; i++)
            {
                words = content[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                for (int j = 0; j < words.Length; j++)
                {
                    currWord = words[j];

                    for (int k = j+1; k < words.Length; k++)
                    {
                        if (currWord.Equals(words[k]))
                        {
                            counter++;
                            j = words.Length;
                            break;
                        }
                    }    
                }
            }
            Console.WriteLine(content.Length - counter);

            // part two

            counter = 0;

            for (int i = 0; i < content.Length; i++)
            {
                words = content[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < words.Length; j++)
                {
                    currWord = words[j];

                    for (int k = j+1; k < words.Length; k++)
                    {
                        currAnagram = string.Concat(currWord.OrderBy(z => z));
                        checkAnagram = string.Concat(words[k].OrderBy(z => z));

                        if (currAnagram.Equals(checkAnagram))
                        {
                            counter++;
                            j = words.Length;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(content.Length - counter);
        }
    }
}
