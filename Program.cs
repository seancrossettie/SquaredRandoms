using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numberList = new List<int>();

            var squaredList = new List<int>();

            for (uint i = 1; i <= 20; i++)
            {
                numberList.Add(random.Next(50));
            }

            numberList.ForEach(number => squaredList.Add((int)Math.Pow((number), 2)));

            squaredList.ForEach(num => Console.WriteLine(num));

            foreach (int num in squaredList)
            {
                if (num % 2 != 0)
                {
                    squaredList.Remove(num);
                }
                else
                { 
                }
            }
        }
    }
}
