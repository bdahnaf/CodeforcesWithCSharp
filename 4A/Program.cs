/**
 * Problem Link - https://codeforces.com/problemset/problem/4/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 28 Oct 2022, 08:43 AM
 */
int w = int.Parse(Console.ReadLine());
if (w >= 1 && w <= 100)
{
    if (w % 2 == 0 && w != 2)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
