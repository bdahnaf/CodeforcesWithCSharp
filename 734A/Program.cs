/**
 * Problem Link - https://codeforces.com/problemset/problem/734/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 02 Nov 2022, 11:41 PM
 */
int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int a = 0;
int b = 0;
for (int i = 0; i < n; i++)
{
    if (input[i] == 'A')
    {
        a++;
    }
    else
    {
        b++;
    }
}

if (a == b)
{
    Console.WriteLine("Friendship");
}
else if (a > b)
{
    Console.WriteLine("Anton");
}
else
{
    Console.WriteLine("Danik");
}