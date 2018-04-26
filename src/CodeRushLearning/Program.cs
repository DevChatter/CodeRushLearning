using System;
using System.Collections.Generic;

namespace CodeRushLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FizzBuzz World!");

            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(100, string.Empty);

            foreach (string fizzBuzzResult in fizzBuzzResults)
            {
                Console.WriteLine(fizzBuzzResult);
            }
        }
    }
}
