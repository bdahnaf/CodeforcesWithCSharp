/**
 * Problem Link - https://codeforces.com/problemset/problem/112/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 30 Oct 2022, 10:20 PM
 */

string first = Console.ReadLine();
string second = Console.ReadLine();
int charValueF = 0;
int charValueS = 0;
for (int i = 0; i < first.Length; i++)
{
    if ((int)first[i] <= 90)
    {
        charValueF = (int)first[i] + 32;
    }
    else
    {
        charValueF = (int)first[i];
    }
    if ((int)second[i] <= 90)
    {
        charValueS = (int)second[i] + 32;
    }
    else
    {
        charValueS = (int)second[i];
    }

    if (charValueF < charValueS)
    {
        Console.WriteLine("-1");
        return;
    }
    if (charValueF > charValueS)
    {
        Console.WriteLine("1");
        return;
    }
}

Console.WriteLine("0");