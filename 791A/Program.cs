/**
 * Problem Link - https://codeforces.com/problemset/problem/791/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 03:46 PM
 */
string input = Console.ReadLine();
int[] inputArray = Array.ConvertAll(input.Split(' '), int.Parse);
int a = inputArray[0];
int b = inputArray[1];
int y = 0;

while(a <= b)
{
    y++;
    a *= 3;
    b *= 2;
}
Console.WriteLine(y);