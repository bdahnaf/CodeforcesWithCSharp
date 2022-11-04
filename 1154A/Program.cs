

using System.Collections;
/**
 * Problem Link - https://codeforces.com/problemset/problem/1154/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 04 November 2022, 08:12 AM
 */

string input = Console.ReadLine();
int[] inputArray = Array.ConvertAll(input.Split(' '), int.Parse);
Array.Sort(inputArray);
int ab = inputArray[0];
int ac = inputArray[1];
int bc = inputArray[2];
int abc = inputArray[3];
int a = abc - bc;
int b = abc - ac;
int c = abc - ab;
Console.WriteLine(a + " " + b + " " + c);