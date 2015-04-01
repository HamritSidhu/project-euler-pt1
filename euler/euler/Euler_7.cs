using System;

/*By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number? 
 */


namespace euler
{
    class _solution7 : solutionInterface
    {
        public int nthPrime(int n) {
            int prime = 2;
            int num = 2;
            while (n > 0) {
                for (int i = 2; i <= num; i++) {
                    if (num % i == 0 && num!=i)
                        break;

                    if (i == num) {
                        prime = num;
                        n--;
                    }  
                }
                num++;
            }
            return prime;   
        }

        public void solve() {
            int result = this.nthPrime(10001);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
