/**
 * Problem Link - https://codeforces.com/problemset/problem/59/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 31 Oct 2022, 09:57 PM
 */

string word = Console.ReadLine();
int up = 0;
int low = 0;
for (int i = 0; i < word.Length; i++)
{
    if ((int)word[i] <= 90)
    {
        up++;
    }
    else
    {
        low++;
    }
}

if (up > low)
{
    for (int i = 0; i < word.Length; i++)
    {
        if ((int)word[i] > 90)
        {
            Console.Write((char)((int)word[i] - 32));
        }
        else
        {
            Console.Write(word[i]);
        }
    }
}
else
{
    for (int i = 0; i < word.Length; i++)
    {
        if ((int)word[i] <= 90)
        {
            Console.Write((char)((int)word[i] + 32));
        }
        else
        {
            Console.Write(word[i]);
        }
    }
}
Console.WriteLine();