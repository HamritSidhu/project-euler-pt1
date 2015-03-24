using System;
using System.Text;

/*
 * A palindromic number reads the same both ways. 
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

namespace euler
{
    class _solution4 : solutionInterface
    {
        public int largestPalindrome(int numDigits)
        {
            int smallest = (int)Math.Pow(10, numDigits - 1);
            int largest = (int)Math.Pow(10, numDigits) - 1;
            int num = 0;
            
            for (int i = smallest; i <= largest; i++) {
                for (int j = i; j <= largest; j++) {
                    if (isPalindrome(i * j) && (i*j)>num)
                        num = i * j;
                }
            }
            return num;
        }

        public bool isPalindrome(int num) {
            string stringNum = num.ToString();
            char[] chars = stringNum.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            return stringNum == reversed;
        }

        public void solve() {
            int result = this.largestPalindrome(3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //ALTERNATE WAY OF CHECKING FOR PALINDROME
        //public bool isPalindrome(int num) {
        //    string number = num.ToString();
        //    ASCIIEncoding encode = new ASCIIEncoding();
        //    byte[] charAsciis = encode.GetBytes(number);

        //    int i = 0;
        //    int j = charAsciis.Length - 1;
        //    while (i <= j)
        //    {
        //        if (charAsciis[i] != charAsciis[j])
        //            return false;
        //        i++;
        //        j--;
        //    }
        //    return true;
        //}
    }
}
