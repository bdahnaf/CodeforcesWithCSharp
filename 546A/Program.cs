/**
 * Problem Link - https://codeforces.com/problemset/problem/546/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 31 Oct 2022, 3:29 PM
 */

string input = Console.ReadLine();
int[] inputArray = Array.ConvertAll(input.Split(' '), int.Parse);
int k = inputArray[0];
int n = inputArray[1];
int w = inputArray[2];
int sum = 0;

for(int i = 1; i <= w; i++)
{
    sum += i * k;
}
if(sum >= n)
{
    Console.WriteLine(sum - n);
}
else
{
    Console.WriteLine("0");
}