﻿/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class CompareCharArrays
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine();
        Console.WriteLine("Enter two char contained arrays.");
        Console.Write("Size of the first. ");
        int char1Size = int.Parse(Console.ReadLine());
        char[] charArray1 = new char[char1Size];
        //charArray1[0] = 'E';
        //charArray1[1] = '2';
        //charArray1[2] = '$';
        //charArray1[3] = 'f';
        Console.WriteLine("Start entery at first array.");
        for (int i = 0; i < char1Size; i++)
        {
            charArray1[i] = char.Parse(Console.ReadLine());
            //Console.WriteLine(charArray1[i]);
        }

        Console.Write("Size of the second. ");
        int char2Size = int.Parse(Console.ReadLine());
        char[] charArray2 = new char[char2Size];
        Console.WriteLine("Start entery at second array.");
        for (int i = 0; i < char2Size; i++)
        {
            charArray2[i] = char.Parse(Console.ReadLine());
        }


        //compare
        for (int i = 0; i < char1Size; i++)
        {
            for (int j = 0; j < char2Size; j++)
            {
                if (charArray1[i] == charArray2[j])
                {
                    Console.WriteLine("1array[{0}] = {1} EQUAL WITH 2array[{2}] = {3}", i, charArray1[i], j, charArray2[j]);
                }
                else
                {
                    Console.WriteLine("1array[{0}] = {1} NOT equal with 2array[{2}] = {3}", i, charArray1[i], j, charArray2[j]);
                }
            }
            //Thread.Sleep(150);
        }


    }
}
