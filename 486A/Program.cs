/**
 * Problem Link - https://codeforces.com/problemset/problem/486/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 09 November 2022, 09:11 PM
 */
long number = long.Parse(Console.ReadLine());
int par = 0;
long sum = 0;
if (number % 2 == 0)
{
    Console.WriteLine(number/2);
}
else
{
    Console.WriteLine(((number / 2) + 1) * -1);
}