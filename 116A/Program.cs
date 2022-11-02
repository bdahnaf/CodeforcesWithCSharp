/**
 * Problem Link - https://codeforces.com/problemset/problem/116/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 31 Oct 2022, 11:33 PM
 */
int n = int.Parse(Console.ReadLine());
int sum = 0;
int a = 0;
int b = 0;
int ans = 0;
while (n > 0)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    a = input[0];
    b = input[1];
    sum = sum + b - a;
    if (sum >= ans)
    {
        ans = sum;
    }
    n--;
}
Console.WriteLine(ans);