/**
 * Problem Link - https://codeforces.com/problemset/problem/1230/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 06 November 2022, 12:09 AM
 */
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int sum = input[0] + input[1] + input[2] + input[3];
if (sum % 2 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
