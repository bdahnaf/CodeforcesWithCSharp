/**
 * Problem Link - https://codeforces.com/problemset/problem/69/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 31 Oct 2022, 09:35 PM
 */

int c = int.Parse(Console.ReadLine());
string input = "";
int[] inputArray = new int[3];
int x = 0;
int y = 0;
int z = 0;
for (int i = 0; i < c; i++)
{
    input = Console.ReadLine();
    inputArray = Array.ConvertAll(input.Split(' '), int.Parse);
    x = x + inputArray[0];
    y = y + inputArray[1];
    z = z + inputArray[2];
}

if (x == 0 && y == 0 && z == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}