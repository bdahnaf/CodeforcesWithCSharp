/**
 * Problem Link - https://codeforces.com/problemset/problem/158/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 30 Oct 2022, 10:38 AM
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
