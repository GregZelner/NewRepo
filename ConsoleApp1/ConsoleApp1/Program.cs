using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aStringThatContainsANumber = "67";

            int aNumberThatCameFromAString = int.Parse(aStringThatContainsANumber);

            if (aNumberThatCameFromAString < 50)
            {
                Console.WriteLine("Statement was true");
                aStringThatContainsANumber = "fart";
            }
            else
            {
                Console.WriteLine("Statement was false");
            }


            Console.WriteLine("the magic string is now: " + aStringThatContainsANumber);

        }
    }
}
