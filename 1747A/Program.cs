﻿/**
 * Problem Link - https://codeforces.com/problemset/problem/1747/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 05 November 2022, 11:46 AM
 */

int t = int.Parse(Console.ReadLine());
long[] ansArray = new long[t];
for (int j = 0; j < t; j++)
{
    long n = long.Parse(Console.ReadLine());
    long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
    long sum = 0;
    long sum1 = 0;
    long sum2 = 0;
    for (int i = 0; i < input.Length; i++)
    {
        //if (input[i] > 0)
        //{
        //    sum1 += input[i];
        //}
        //else
        //{
        //    sum2 += input[i];
        //}
        sum += input[i];
    }
    //ansArray[j] = (long)Math.Abs(Math.Abs((decimal)sum1) - Math.Abs((decimal)sum2));
    ansArray[j] = sum;
    //sum1 = 0;
    //sum2 = 0;
}

for (int i = 0; i < t; i++)
{
    if (ansArray[i] < 0)
    {
        Console.WriteLine(ansArray[i] * -1);
    }
    else
    {
        Console.WriteLine(ansArray[i]);
    }
}