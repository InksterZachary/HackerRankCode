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
            //Simple algorith for running through an array and adding up all members
            ////int simpleArraySum(int[] arg)
            ////{
            ////    int sum = 0;
            ////    int arraySize = arg.Length;
            ////    for (int i = 0; i < arraySize; i++)
            ////    {
            ////        Console.WriteLine(arg[i]);
            ////        sum += arg[i];
            ////    }
            ////    return sum;
            ////}
            ////int[] array = new int[] { 3, 4, 5, 6, 7, 8 };
            ////Console.WriteLine(simpleArraySum(array));
            ////Console.ReadLine();
            //Algorithm comparing two arrays and assigning points to the array with the higher number in the corresponding position
            List<int> compareTriplets(List<int> a, List<int> b)
            {
                int bob = 0;
                int alice = 0;

                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        alice += 1;
                    }
                    else if (a[i] < b[i])
                    {
                        bob += 1;
                    }
                    else
                    {
                        Console.WriteLine("Its a tie, no points");
                    }
                }
                int[] scores = new int[2];
                scores[0] = alice;
                scores[1] = bob;
                return scores.ToList();

            }
            List<int> a1 = new List<int>() { 5, 6, 7 };
            List<int> a2 = new List<int>() { 3, 6, 10 };
            Console.WriteLine(compareTriplets(a1, a2));
            Console.ReadLine();
        }   
            
    }
}
