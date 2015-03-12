using System;

/*
 * Problem Definition: If we list all the natural numbers below 10 that are multiples of 3 or 5, 
 * we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace Euler_1
{
    class _solution1
    {
        static void Main(string[] args)
        {
            _solution1 solution = new _solution1();
            //Printing out result
            int answer = solution.sumof3and5multiples(1000);
            Console.WriteLine(answer);
            Console.ReadLine();
        }


        //Solution
        int sumof3and5multiples(int below)
        {
            int sum = 0;

            for (int i = 1; i < below; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
