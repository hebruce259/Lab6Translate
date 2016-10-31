using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUdemy1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(5, 2);
            // int[] intArray = new int[] { 123, 1234, 56788 };
            // int arrayLength = intArray.Length;
            // Console.WriteLine(arrayLength);
        }
        public static void AddNumbers(int myNum, int otherNum)
        {
           
            int result = myNum + otherNum;
            Console.WriteLine(result.ToString());
        }
       
    }
}
