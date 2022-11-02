/**
 * Problem Link - https://codeforces.com/problemset/problem/110/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 02 Nov 2022, 11:17 PM
 */

ulong number = UInt64.Parse(Console.ReadLine());
ulong lastDigit = 0;
ulong lucky = 0;
int flag = 0;

while (number > 0)
{
    lastDigit = number % 10;
    if (lastDigit == 4 || lastDigit == 7)
    {
        lucky++;
    }

    number /= 10;
}
while (lucky > 0)
{
    lastDigit = lucky % 10;
    if (lastDigit == 4 || lastDigit == 7)
    {
        flag = 1;
    }
    else
    {
        flag = 0;
        break;
    }
    lucky /= 10;
}

if (flag == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}