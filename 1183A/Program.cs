/**
 * Problem Link - https://codeforces.com/problemset/problem/1183/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 07 November 2022, 11:59 PM
 */

int number = int.Parse(Console.ReadLine());
int digitSum = _GetSumDigit(number);
while (digitSum % 4 != 0)
{
    number++;
    digitSum = _GetSumDigit(number);
}
Console.WriteLine(number);

int _GetSumDigit(int number)
{
    int digit = 0;
    int sum = 0;
    while (number > 0)
    {
        digit = number % 10;
        number = number / 10;
        sum = sum + digit;
    }
    return sum;
}