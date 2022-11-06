/**
 * Problem Link - https://codeforces.com/problemset/problem/1335/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 06 November 2022, 10:40 PM
 */

int n = int.Parse(Console.ReadLine());
int ans = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    //for (int a = number - 1, b = 1; a > b; a--, b++)
    //{
    //    ans++;
    //}
    //Console.WriteLine(ans);
    ans = (number - 1) / 2;
    Console.WriteLine(ans);
    ans = 0;
}

