/**
 * Problem Link - https://codeforces.com/problemset/problem/144/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 09 November 2022, 08:13 PM
 */
int t = int.Parse(Console.ReadLine());
int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int largest = 0;
int smallest = 0;
int largestIndex = 0;
int smallestIndex = 0;
int smallestMove = 0;
int largestMove = 0;
for (int i = 0; i < t; i++)
{
    if (i == 0)
    {
        smallest = input[i];
        largest = smallest;
        largestIndex = i;
        smallestIndex = i;
    }
    else
    {
        if (input[i] <= smallest)
        {
            smallest = input[i];
            smallestIndex = i;
        }

        if (input[i] > largest)
        {
            largest = input[i];
            largestIndex = i;
        }
    }
}

smallestMove = t - smallestIndex - 1;
if (largestIndex > smallestIndex)
{
    Console.WriteLine(smallestMove + largestIndex - 1);
}
else
{
    Console.WriteLine(smallestMove + largestIndex);
}