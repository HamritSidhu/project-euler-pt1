﻿using System;


/*
 * Problem Definition: If we list all the natural numbers below 10 that are multiples of 3 or 5, 
 * we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace euler
{
    class _solution1  : solutionInterface
    {
        //Solution
        public int sumof3and5multiples(int below)
        {
            int sum = 0;

            for (int i = 1; i < below; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }

        //Print answer; called in main
        public void solve()
        {
            int answer = this.sumof3and5multiples(1000);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
