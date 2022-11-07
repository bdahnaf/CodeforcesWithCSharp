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

for (int i = 0; i < 4; i++)
{
    for (int j = i + 1; j <= i; j++)
    {
        Console.WriteLine("Adding " + input[i] + " + " + input[j] + " = " + input[i] + input[j]);
    }

    Console.WriteLine("__------------------------");
}
