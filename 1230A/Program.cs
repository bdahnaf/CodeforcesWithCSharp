/**
 * Problem Link - https://codeforces.com/problemset/problem/1230/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 06 November 2022, 12:09 AM
 */

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = input[0];
int b = input[1];
int c = input[2];
int d = input[3];

if ((a + b) == (c + d))
{
    Console.WriteLine("YES");
}
else if ((a + c) == (b + d))
{
    Console.WriteLine("YES");
}
else if ((b + c) == (a + d))
{
    Console.WriteLine("YES");
}
else if ((a + b + c) == d)
{
    Console.WriteLine("YES");
}
else if ((b + c + d) == a)
{
    Console.WriteLine("YES");
}
else if ((a + b + d) == c)
{
    Console.WriteLine("YES");
}
else if ((a + c + d) == b)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
