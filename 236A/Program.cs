/**
 * Problem Link - https://codeforces.com/problemset/problem/236/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 07 November 2022, 06:36 PM
 */

string word = Console.ReadLine();

int len = word.Length;
char[] wordArr = new char[len];
int flag = 0;
int pos = 0;

for (int i = 0; i < len; i++)
{
    for (int j = 0; j <= i; j++)
    {
        //if (wordArr[j] == word[i])
        //{
        //    flag = 1;
        //    pos
        //}
        wordArr[i] = word[i];
    }
}