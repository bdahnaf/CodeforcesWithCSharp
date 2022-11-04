/**
 * Problem Link - https://codeforces.com/problemset/problem/1328/A
 * Author - Ahnaf Shahriar
 * Status - Trying
 * Date & Time - 04 November 2022, 08:27 AM
 */

/**
 * TLE
 */
int t = int.Parse(Console.ReadLine());
//while (t > 0)
//{
//    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//    int a = input[0];
//    int b = input[1];
//    int cnt = 0;
//    while (a > 0)
//    {
//        a = a - b;
//        cnt++;
//    }

//    int ans = a * -1;
//    Console.WriteLine(ans);
//    t--;
//}
while (t > 0)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int a = input[0];
    int b = input[1];
    int cnt = 0;
    int ans = a % b;
    Console.WriteLine(ans);
    t--;
}