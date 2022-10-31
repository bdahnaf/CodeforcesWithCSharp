/**
 * Problem Link - https://codeforces.com/problemset/problem/617/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 31 Oct 2022, 08:29 PM
 */

int number = int.Parse(Console.ReadLine());
int result = 0;
while (number > 0)
{
    if (number >= 5)
    {
        number -= 5;
    }
    else if (number >= 4)
    {
        number -= 4;
    }
    else if (number >= 3)
    {
        number -= 3;
    }
    else if (number >= 2)
    {
        number -= 2;
    }
    else if (number >= 1)
    {
        number -= 1;
    }
    result++;
}
Console.WriteLine(result);