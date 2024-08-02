using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3August
{
    internal class Factorial
    {
        public int GetFactorialOfNumber(int number)
        {
            int result = 1;
            for (int i = 1; i <=number; i++)
            {
                result= result*i;
            }
            return result;
        }
    }
}
