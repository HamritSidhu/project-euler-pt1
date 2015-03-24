using System;
/*  Problem Definition: The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?*/

namespace euler
{
    class _solution3 : solutionInterface
    {
        public Int64 largestPrimeFactor(Int64 num) {

            Int64 prime = num;
            int i = 2;

            while (i <= prime / 2)
            {
                if (prime % i == 0)
                    prime = prime / i;
                else
                    i++;
            }

            return prime;
        }

        public void solve()
        {
            Int64 answer = this.largestPrimeFactor(600851475143);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

    }
}
