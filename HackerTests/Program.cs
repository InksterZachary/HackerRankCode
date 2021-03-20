using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int simpleArraySum(int[] arg)
            {
                int sum = 0;
                int arraySize = arg.Length;
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine(arg[i]);
                    sum += arg[i];
                }
                return sum;
            }
            int[] array = new int[] { 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(simpleArraySum(array));
            Console.ReadLine();
        }   
            
    }
}
