/**
 * Problem Link - https://codeforces.com/problemset/problem/581/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 17 November 2022, 11:05 PM
 */

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = input[0];
int b = input[1];

int dif = 0;
int same = 0;

if (a > b)
{
    dif = b;
    a = a - b;
    b = 0;
    
    //Console.WriteLine(a);
    if (a % 2 == 0)
    {
        same = a / 2;
    }
    else
    {
        same = (a - 1) / 2;
    }
}
else if (b > a)
{
    dif = a;
    b = b - a;
    a = 0;
    //Console.WriteLine("b" + b);
    if (b % 2 == 0)
    {
        same = b / 2;
    }
    else if(b % 2 != 0 && b > 2)
    {
        same = (b - 1) / 2;
    }
    else
    {
        same = b - 1;
    }
}
else
{
    dif = a;
    same = 0;
}

//Console.WriteLine(dif);
//Console.WriteLine(same);
Console.WriteLine(dif + " " + same);
