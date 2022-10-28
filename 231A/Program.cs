/**
 * Problem Link - https://codeforces.com/problemset/problem/231/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 28 Oct 2022, 09:13 AM
 */

int testCase = int.Parse(Console.ReadLine());
int output = 0;
while (testCase > 0)
{
    string line = Console.ReadLine();
    string[] values = line.Split(' ');
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += int.Parse(values[i]);
    }

    if (sum >= 2)
    {
        output++;
    }
    testCase--;
}
Console.WriteLine(output);