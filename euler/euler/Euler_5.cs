using System;
/**
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */
namespace euler
{
    class _solution5 : solutionInterface
    {

        public Int64 smallestMultiple(int divisorRange) {
            Int64 num = divisorRange;
            Int64 factorial = 1;

            for(int i = 1; i<= divisorRange; i++) {
                factorial *= i;
            }
            
            while(num<factorial) {
                for (int i = 1; i <= divisorRange; i++)
                {
                    if (num % i != 0)
                        break;
                    if (i == divisorRange)
                        return num;
                }
                num+=divisorRange;
            }
            
            return factorial;
        }

        public void solve() {
            Int64 result = this.smallestMultiple(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
