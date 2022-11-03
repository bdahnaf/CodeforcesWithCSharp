/**
 * Problem Link - https://codeforces.com/problemset/problem/996/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 03 November 2022, 11:10 PM
 */

int number = int.Parse(Console.ReadLine());
int ans = 0;
while (number > 0)
{
    if (number >= 100)
    {
        number -= 100;
        ans++;
    }
    else if (number >= 20)
    {
        number -= 20;
        ans++;
    }
    else if (number >= 10)
    {
        number -= 10;
        ans++;
    }
    else if (number >= 5)
    {
        number -= 5;
        ans++;
    }
    else if (number >= 1)
    {
        number -= 1;
        ans++;
    }
}
Console.WriteLine(ans);