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
            //Simple algorith for running through an array and adding up all members---------------------
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


            //Algorithm comparing two arrays and assigning points to the array with the higher number in the corresponding position-----------------
            ////List<int> compareTriplets(List<int> a, List<int> b)
            ////{
            ////    int bob = 0;
            ////    int alice = 0;

            ////    for (int i = 0; i < a.Count; i++)
            ////    {
            ////        if (a[i] > b[i])
            ////        {
            ////            alice += 1;
            ////        }
            ////        else if (a[i] < b[i])
            ////        {
            ////            bob += 1;
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("Its a tie, no points");
            ////        }
            ////    }
            ////    int[] scores = new int[2];
            ////    scores[0] = alice;
            ////    scores[1] = bob;
            ////    return scores.ToList();

            ////}
            ////List<int> a1 = new List<int>() { 5, 6, 7 };
            ////List<int> a2 = new List<int>() { 3, 6, 10 };
            ////Console.WriteLine(compareTriplets(a1, a2));
            ////Console.ReadLine();

            //Finding the absolute value of the diagonal sums of a 2-d Array --------------------------
            ////int diagonalDifference(List<List<int>> arr)
            ////{
            ////    int leftDiag = arr[0][0] + arr[1][1] + arr[2][2];
            ////    int rightDiag = arr[0][2] + arr[1][1] + arr[2][0];
            ////    int abDiff = leftDiag - rightDiag;
            ////    return Math.Abs(abDiff);
            ////}

            //The above only solved one test case so I refactored and uncovered an algorithm that would solve any size square 2d array-----------------------
            ////int leftDiagonal = 0;
            ////int rightDiagonal = 0;
            ////int abDiff = 0;
            ////int n = arr.Count;

            ////for (int i = 0; i <= arr.Count - 1; i++)
            ////{
            ////    leftDiagonal += arr[i][i];
            ////    rightDiagonal += arr[i][n - 1 - i];
            ////    abDiff = leftDiagonal - rightDiagonal;
            ////}
            ////return Math.Abs(abDiff);

        }
    }
}
