/**
 * Problem Link - https://codeforces.com/problemset/problem/263/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 06 November 2022, 09:55 PM
 */
int[] input;
int[,] arr = new int[5,5];
int posi = 0;
int posj = 0;
for(int i = 0; i < 5; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    for(int j = 0; j < 5; j++)
    {
        arr[i, j] = input[j];
        if (input[j] == 1)
        {
            posi = i;
            posj = j;
        }
    }
}

int desi = Math.Abs(2 - posi);
int desj = Math.Abs(2 - posj);
Console.WriteLine(desi + desj);