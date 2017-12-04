namespace _01_inverse_captcha
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            String content = args[0];
            int result = 0;

            // Part One

            for (int i = 0; i < content.Length - 1; i++)
            {
                if(content[i] == content[i+1]) 
                {
                    result += Convert.ToInt32(content[i].ToString());
                }
            }
            
            if(content[content.Length - 1] == content[0])
            {
                result += Convert.ToInt32(content[0].ToString());
            }
            Console.WriteLine(result.ToString());

            // Part TWo

            result = 0;
            int halfWay = content.Length / 2;    

            for (int i = 0; i < content.Length; i++)
            {
                if(i + halfWay >= content.Length)
                {
                    int foo = halfWay - (content.Length - i);
                    if(content[i] == content[foo])
                    {
                        result += Convert.ToInt32(content[i].ToString());
                    }
                }
                else
                {
                    if(content[i] == content[i+halfWay]) 
                    {
                        result += Convert.ToInt32(content[i].ToString());
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
