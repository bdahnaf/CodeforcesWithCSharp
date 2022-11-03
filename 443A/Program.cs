/**
 * Problem Link - https://codeforces.com/problemset/problem/443/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 30 Oct 2022, 03:35 PM
 */

string line = Console.ReadLine();
int len = line.Length;
int ans = 0;
int same = 0;

if(len > 2)
{
    for (int i = 1; i < line.Length - 1; i++)
    {
        //for(int j = 0; j < parts.Length; j++)
        //{
        //    if (parts[j] != line[i].ToString())
        //    {
        //        parts[j] = line[i].ToString();
        //    }
        //}
        //parts[i] = line[i];
        //Console.Write(line[i]);
    }
    string[] parts = line.Split(", ");
    for (int j = 0; j < parts.Length; j++)
    {
        for(int k = 0; k < parts.Length; k++)
        {
            if (parts[j] == parts[k])
            {
                same++;
            }
        }
        if(same == 1)
        {
            ans++;
        }
    }
}
else
{
    Console.WriteLine("0");
}

