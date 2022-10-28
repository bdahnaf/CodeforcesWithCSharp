/**
 * Problem Link - https://codeforces.com/problemset/problem/71/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 28 Oct 2022, 08:57 AM
 */

int testCase = int.Parse(Console.ReadLine());

while (testCase > 0)
{
    string word = Console.ReadLine();
    int wordLength = word.Length;
    string output = "";
    if (wordLength > 10)
    {
        int wordLengthOutput = wordLength - 2;
        output = output + word[0] + wordLengthOutput.ToString() + word[wordLength-1];
        Console.WriteLine(output);
    }
    else
    {
        Console.WriteLine(word);
    }

    testCase--;
}