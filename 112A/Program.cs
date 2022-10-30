/**
 * Problem Link - https://codeforces.com/problemset/problem/112/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 30 Oct 2022, 12:58 PM
 */
/**
 * aslkjlkasdd
 * asdlkjdajwi
*/
string first = Console.ReadLine();
string second = Console.ReadLine();
int len = first.Length;
int sumF = 0;
int sumS = 0;
for (int i = 0; i < len; i++)
{
    if ((int)first[i] <= 90)
    {
        sumF = sumF + (int)first[i] + 32;
    }
    else
    {
        sumF = sumF + (int)first[i];
    }
    if ((int)second[i] <= 90)
    {
        sumS = sumS + (int)second[i] + 32;
    }
    else
    {
        sumS = sumS + (int)second[i];
    }
}

if(sumF == sumS)
{
    Console.WriteLine("0");
}
else if (sumF < sumS)
{
    Console.WriteLine("-1");
}
else if (sumF > sumS)
{
    Console.WriteLine("1");
}