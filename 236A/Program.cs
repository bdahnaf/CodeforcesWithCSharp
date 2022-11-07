/**
 * Problem Link - https://codeforces.com/problemset/problem/236/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 07 November 2022, 11:14 PM
 */

string word = Console.ReadLine();
int len = word.Length;
int ans = len;
for (int i = 0; i < len; i++)
{
    for (int j = i + 1; j < len; j++)
    {
        if (word[i] == word[j])
        {
            ans--;
            break;
        }
    }
}

if (ans % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}