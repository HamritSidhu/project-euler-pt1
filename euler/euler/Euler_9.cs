using System;
/**
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
 */

namespace euler
{
    class _solution9 : solutionInterface
    {
        public Int64 tripletProduct()
        {
            int c = 0;
            double pythSqrt;

            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    pythSqrt = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    if (pythSqrt - (int)pythSqrt == 0)
                    {
                        c = (int)pythSqrt;
                        if (a + b + c == 1000)
                            return a * b * c;
                    }
                }
            }

            return 0;
        }

        public void solve()
        {
            Console.WriteLine(this.tripletProduct());
            Console.ReadLine();
        }
    }
}
