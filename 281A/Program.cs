/**
 * Problem Link - https://codeforces.com/problemset/problem/281/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 10:57 PM
 */

string word = Console.ReadLine();
if ((int)word[0] > 90)
{
    int wordInInt = (int)word[0] - 32;
    Console.Write((char)(wordInInt));
    for (int i = 1; i < word.Length; i++)
    {
        Console.Write(word[i]);
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine(word);
}