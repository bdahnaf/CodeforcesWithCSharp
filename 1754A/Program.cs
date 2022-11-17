/**
 * Problem Link - https://codeforces.com/problemset/problem/1754/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 17 November 2022, 11:17 PM
 */
int n = int.Parse(Console.ReadLine());
string[] ans = new string[n];
while (n > 0)
{
    int j = 0;
    int t = int.Parse(Console.ReadLine());
    string line = Console.ReadLine();
    int q = 0;
    int a = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == 'Q')
        {
            q++;
        }
        else
        {
            a++;
        }
    }

    if (a >= q)
    {
        ans[j] = "Yes";
    }
    else
    {
        ans[j] = "No";
    }
    j++;
    n--;
}


for (int i = 0; i < ans.Length; i++)
{
    Console.WriteLine(ans[i]);
}