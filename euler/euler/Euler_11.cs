using euler.Properties;
using System;
using System.IO;

//Problem: What is the greatest product of four adjacent numbers in the same direction 
//(up, down, left, right, or diagonally) in the 20×20 grid?

namespace euler
{
    class _solution11 : solutionInterface
    {
        public Int64 greatestProductof20by20grid(int[,] array, int numAdj) {
            Int64 _product,_currentMax;
            _product = _currentMax = 0;
            Int64 _hcur, _vcur,_dcur,_dcur2;
            _hcur = _vcur = _dcur = _dcur2 = 1;
         
            int j;
            for (int i = 0; i <= 20 - numAdj ; i++) {
                j = 0;
                while(j <= 20 - numAdj) {
                    for (int k = 0; k < numAdj; k++) {
                        _hcur *= array[i, j + k];
                        _vcur *= array[j + k, i];
                        _dcur *= array[i + k, j + k];
                        _dcur2 *= array[i + k, 19 - (j + k)];
                    }
                    _currentMax = Math.Max(Math.Max(Math.Max(_hcur, _vcur), _dcur), _dcur2);
                    
                    if (_currentMax > _product)
                        _product = _currentMax;

                    _hcur = _vcur = _dcur =_dcur2 = 1;
                    j++;
                }
            }
            return _product;
        }

        public void solve() {
            int [,] _2darray = new int[20,20];
            var reader = new StreamReader(Settings.Default.problem11_textfile);
            string[] line;
            for (int i = 0; i < 20; i++)
            {
                line = reader.ReadLine().Split(' ');
                for (int j = 0; j < 20; j++)
                    _2darray[i, j] = Convert.ToInt16(line[j]);
            }

            Int64 product = this.greatestProductof20by20grid(_2darray, 4);
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
