using System;

namespace ExeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
                Console.WriteLine(args[0]);
            else if (args.Length > 1)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            else
                Console.WriteLine("ExeTest <string parameter>");
        }
    }
}
