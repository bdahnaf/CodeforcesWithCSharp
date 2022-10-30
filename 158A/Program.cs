/**
 * Problem Link - https://codeforces.com/problemset/problem/158/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 12:16 PM
 */

string firstLine = Console.ReadLine();
string secondLine = Console.ReadLine();

string[] data = firstLine.Split(' ');
int n = int.Parse(data[0]);
int k = int.Parse(data[1]);
data = secondLine.Split(' ');
int[] a = new int[n];
int i = 0;

foreach (var number in data)
{
    a[i] = int.Parse(number);
    i++;
}

int value = a[k-1];
int result = 0;
for(int j = 0; j < n; j++)
{
    if (a[j] >= value && a[j] > 0)
    {
        result++;
    }
}
Console.WriteLine(result);
