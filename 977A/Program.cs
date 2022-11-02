/**
 * Problem Link - https://codeforces.com/problemset/problem/977/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 02 Nov 2022, 08:47 PM
 */

string input = Console.ReadLine();
int[] inputInt = Array.ConvertAll(input.Split(' '), int.Parse);
int n = inputInt[0];
int k = inputInt[1];
int lastDigit = 0;
while (k > 0)
{
    lastDigit = n % 10;
    if (lastDigit == 0)
    {
        n = n / 10;
    }
    else
    {
        n -= 1;
    }

    k--;
}
Console.WriteLine(n);