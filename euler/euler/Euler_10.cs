using System;
//Find the sum of all the primes below two million.

namespace euler
{
    class _solution10 : solutionInterface
    {
        public Int64 sumPrimes(Int64 below) {
            Int64 sum = 2;
            Int64 num = 3;
            int factorLimit = 0;

            while (num < below) {
                factorLimit = (int)Math.Ceiling(Math.Sqrt(num));
                for (int i = 2; i <= factorLimit; i++)
                {
                    if (num % i == 0)
                        break;

                    if(i == factorLimit)
                        sum += num;
                }
                num = num + 2;
            }  
           return sum;
        }

        public void solve() {
            Int64 sum = this.sumPrimes(2000000);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
