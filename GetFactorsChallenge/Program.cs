using System;
using System.Collections.Generic;
using System.Linq;

namespace GetFactorsChallenge
{
    

    class Program
    {
        public static List<int> CreateList(HashSet<int> set)
        {
            List<int> factors = new List<int>();

            factors.AddRange(set);

            return factors;
        }

        public static List<List<int>> getFactors(int n)
        {
            List<List<int>> factorList = new List<List<int>>();
            HashSet<int> initFactors = new HashSet<int>();

            for (int i = 2; i <= n - 1; i++)
            {
                int result1 = 0;
                int result2 = 0;
                
                if (n % i == 0)
                {
                    result1 = n / i;

                    initFactors.Add(i);
                    initFactors.Add(result1);

                    factorList.Add(CreateList(initFactors));

                }

                

            }

            


            return factorList;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer: ");

            try
            {
                int inputNumber = int.Parse(Console.ReadLine());

                List<int> factors = new List<int>();

                foreach (var item in getFactors(inputNumber))
                {
                    factors = item;
                    Console.WriteLine(item);
                    
                }

                //foreach (var numbs in factors)
                //{
                //    Console.WriteLine(numbs);

                //}

                Console.WriteLine("Count: " + getFactors(inputNumber).Count);

            }

            catch(Exception)
            {
                Console.WriteLine("Please enter an integer, and try again.");
            }

            
        }
    }
}
