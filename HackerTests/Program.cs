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

            //Remove any instances of vowels for a given sentence and return the leftovers ------------------------------
            ////string VowelRemoval(string str)
            ////{
            ////    char a = 'a';
            ////    char e = 'e';
            ////    char eye = 'i';
            ////    char o = 'o';
            ////    char u = 'u';
            ////    string newString = "";
            ////    char[] stri = str.ToCharArray();
            ////    for(int i = 0; i <= stri.Count() - 1; i++)
            ////    {
            ////        if (stri[i] != a && stri[i] != e && stri[i] != eye && stri[i] != o && stri[i] != u)
            ////        {
            ////            newString += (stri[i].ToString());
            ////        }
            ////        else if(stri[i+1].ToString() == " ")
            ////        {
            ////            newString += (" ");
            ////        }
            ////    }
            ////    return newString;
            ////}
            ////string sentence = "This is the best sentence ever!";
            ////Console.WriteLine(VowelRemoval(sentence));
            ////Console.ReadLine();

            //Prints the ratio of positive, negative, and 0 numbers in a given array ------------------------------------------------------
            ////void plusMinus(int[] arr)
            ////{
            ////    double pos = 0;
            ////    double neg = 0;
            ////    double neutral = 0;
            ////    for (int i = 0; i < arr.Count(); i++)
            ////    {
            ////        if (arr[i] < 0)
            ////        {
            ////            neg += 1;
            ////        }
            ////        else if (arr[i] > 0)
            ////        {
            ////            pos += 1;
            ////        }
            ////        else
            ////        {
            ////            neutral += 1;
            ////        }
            ////    }
            ////    double posD = pos / arr.Count();
            ////    double negD = neg / arr.Count();
            ////    double neutD = neutral / arr.Count();

            ////    Console.WriteLine(Math.Round(posD,6));
            ////    Console.WriteLine(Math.Round(negD, 6));
            ////    Console.WriteLine(Math.Round(neutD, 6));
            ////}
            ////int[] array = { -4, 3, -9, 0, 4, 1 };
            ////plusMinus(array);
            ////Console.ReadLine();

            //Algorithm to determine if every number up to a specified number is in an array ----------------------------------------------
            ////int[] testArray = { 1, 2, 3 };
            ////int[] testArray2 = { 1, 2, 3, 4, 4, 5, 6, 7, 8 };
            ////int[] testArray3 = { 1, 2, 3, 5, 6, 7, 8 };
            ////int X = 3;
            ////int Y = 8;

            ////bool solution(int[] A, int K)
            ////{
            ////    int n = A.Length;
            ////    for (int i = 0; i < n - 1; i++)
            ////    {
            ////        if (A[i] + 1 < A[i + 1])
            ////            return false;
            ////    }
            ////    if (A[0] != 1 || A[n - 1] != K)
            ////    {
            ////        return false;
            ////    }
            ////    else { 
            ////        return true;
            ////    }
            ////}
            ////Console.WriteLine(solution(testArray3, Y));
            ////Console.ReadLine();

            //Reverse a string While Loop -----------------------------------------------------------------------------------
            ////string ReverseString(string word)
            ////{
            ////    string reversedString = "";
            ////    int length = word.Length - 1;
            ////    while(length >= 0)
            ////    {
            ////        reversedString += word[length];
            ////        length--;
            ////    }
            ////    return reversedString;
            ////}
            ////Console.WriteLine(ReverseString("Johnny"));
            ////Console.ReadLine();

            //Reverse a string For Loop -----------------------------------------------------------
            ////string ReverseWordForLoop(string word)
            ////{
            ////    string newWord = "";
            ////    word.ToCharArray();
            ////    for(int i = word.Length - 1; i >= 0; i--)
            ////    {
            ////        newWord += word[i];
            ////    }
            ////    return newWord;
            ////}
            ////Console.WriteLine(ReverseWordForLoop("string"));
            ////Console.ReadLine();

            //Print a stair case of "#" and spaces with a height of n -------------------------------------Come back to this one
            void staircase(int n)
            {
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
                }
            }
            staircase(10);
            Console.ReadLine();
        
            //Given ant size number array find the minimum and maximum number you can get by adding only 4 numbers together from the array ---------------------
            ////void MiniMaxSum(int[] arr)
            ////{
            ////    long min = 0;
            ////    long max = 0;
            ////    int maximumLength = arr.Length - 5;
            ////    Array.Sort(arr);
            ////    for(int i = 0; i < 4; i++)
            ////    {
            ////        min += arr[i];
            ////    }
            ////    for(int i = arr.Length - 1; i > maximumLength; i--)
            ////    {
            ////        max += arr[i];
            ////    }
            ////    Console.WriteLine(min + " " + max);
            ////}
            ////int[] array = { 3, 4, 5, 6, 10, 7, 8, 9, 11, 2 };

            ////MiniMaxSum(array);
            ////Console.ReadLine();

            //Count the number of tallest birthday candles in a List ----------------------------------------------
            ////int BirthdayCakeCandles(List<int> candles)
            ////{
            ////    candles.Sort();
            ////    int maxHeight = candles[candles.Count - 1];
            ////    int maxCounter = 0;
            ////    for(int i = 0; i <= candles.Count - 1; i++)
            ////    {
            ////        if(maxHeight == candles[i])
            ////        {
            ////            maxCounter++;
            ////        }
            ////    }
            ////    return maxCounter;
            ////}
            ////List<int> cakeCandles = new List<int>();
            ////cakeCandles.Add(1);
            ////cakeCandles.Add(2);
            ////cakeCandles.Add(6);
            ////cakeCandles.Add(3);
            ////cakeCandles.Add(4);
            ////cakeCandles.Add(6);
            ////cakeCandles.Add(6);
            ////Console.WriteLine(BirthdayCakeCandles(cakeCandles));
            ////Console.ReadLine();
        }
    }
}
