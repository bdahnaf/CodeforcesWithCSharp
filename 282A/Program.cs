/**
 * Problem Link - https://codeforces.com/problemset/problem/282/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 12:30 PM
 */

int n = int.Parse(Console.ReadLine());
int value = 0;
string op = "";
for(int i = 0; i < n; i++)
{
    op = Console.ReadLine();
    if (op[0] == '+' || op[2] == '+')
    {
        value++;
    }
    else if (op[0] == '-' || op[2] == '-')
    {
        value--;
    }
}
Console.WriteLine(value);