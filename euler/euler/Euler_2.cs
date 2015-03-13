﻿using System;

/*
 Problem Definition: Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
 * By starting with 1 and 2, the first 10 terms will be:
 * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
 * find the sum of the even-valued terms.
 */

namespace euler
{
    class _solution2
    {
        //Solution
        public int fibEvenSum(int below)
        {

            int sum = 0;
            int fibOld = 0;
            int fibNew = 1;
            int currentSum;

            while (fibNew < below)
            {
                currentSum = fibOld + fibNew;

                if (currentSum % 2 == 0)
                    sum += currentSum;

                fibOld = fibNew;
                fibNew = currentSum;
            }

            return sum;
        }

    }
}