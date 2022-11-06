/**
 * Problem Link - https://codeforces.com/problemset/problem/432/A
 * Author - Ahnaf Shahriar
 * Status - Accepted
 * Date & Time - 06 November 2022, 10:22 PM
 */
int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = nk[0];
int k = nk[1];
int[] input = new int[n];

int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int inrCnt = 0;
int ans = 0;
for (int i = 0; i < n; i++)
{
    if ((line[i] + k) < 6)
    {
        inrCnt++;
    }

    if (inrCnt == 3)
    {
        inrCnt = 0;
        ans++;
    }
}
Console.WriteLine(ans);