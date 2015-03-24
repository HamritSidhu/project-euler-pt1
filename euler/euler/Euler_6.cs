using System;

/**
 * Find the difference between the sum of the squares of the first one hundred natural numbers 
 * and the square of the sum.
 */

namespace euler
{
    class _solution6 : solutionInterface
    {
        public int diffOfSums(int numNatural) {
            int sumSquares = 0;
            int squareSum = 0;

            for (int i = 1; i <= numNatural; i++) {
                sumSquares += (int)Math.Pow(i, 2);
                squareSum += i;
            }
            return (int)Math.Pow(squareSum, 2) - sumSquares;
        }

        public void solve() {
            int diff = this.diffOfSums(100);
            Console.WriteLine(diff);
            Console.ReadLine();
        }
    }
}
