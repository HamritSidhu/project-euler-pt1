using System;


namespace euler
{
    class Program
    {
        //Used to print out answers on console
        static void Main(string[] args) { 
            _solution2 solution = new _solution2();
            int answer = solution.fibEvenSum(4000000);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
