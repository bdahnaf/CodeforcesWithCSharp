/**
 * Problem Link - https://codeforces.com/problemset/problem/581/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 09 November 2022, 09:13 PM
 */
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = input[0];
int b = input[1];

int dif = 0;
int same = 0;

if (a > b)
{
    dif = b;
    b = 0;
    a = a - b;
}
else if (b > a)
{
    dif = a;
    a = 0;
    b = b - a;
}
if 