using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)

        {

        }
    
        
          static int Sum(int Max)
        {
            int sum = 0;
            for (int i = 0; i <= Max; i++)
            {
                sum = sum + i;

            }
            return sum;
        }

    }
}
