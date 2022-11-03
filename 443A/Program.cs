/**
 * Problem Link - https://codeforces.com/problemset/problem/443/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 03 November 2022, 03:35 PM
 */

string line = Console.ReadLine();
int len = line.Length;
int ans = 0;
int same = 0;

if(len > 2)
{
    string sortedLine = String.Concat(line.OrderBy(c => c));
    for (int i = 0; i < sortedLine.Length - 1; i++)
    {
        if (sortedLine[i] >= 'a' && sortedLine[i] <= 'z')
        {
            if (sortedLine[i] != sortedLine[i + 1])
            {
                ans++;
            }
        }
    }
    Console.WriteLine(ans);
}
else
{
    Console.WriteLine("0");
}

