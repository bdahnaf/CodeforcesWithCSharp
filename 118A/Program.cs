/**
 * Problem Link - https://codeforces.com/problemset/problem/118/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 11:29 PM
 */
string word = Console.ReadLine();
string output = "";

for (int i = 0; i < word.Length; i++)
{

    if (word[i] == 'A' || word[i] == 'O' || word[i] == 'Y' || word[i] == 'E' || word[i] == 'U' || word[i] == 'I')
    {
        output = output + "";
    }
    else if (word[i] == 'a' || word[i] == 'o' || word[i] == 'y' || word[i] == 'e' || word[i] == 'u' || word[i] == 'i')
    {
        output = output + "";
    }
    else if ((int)word[i] <= 90)
    {
        output = output + "." + (char)((int)word[i] + 32);
    }
    else
    {
        output = output + "." + word[i];
    }
}
Console.WriteLine(output);