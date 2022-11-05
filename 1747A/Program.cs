//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int t = int.Parse(Console.ReadLine());
long[] ansArray = new long[t];
for (int j = 0; j < t; j++)
{
    long n = long.Parse(Console.ReadLine());
    long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
    long sum1 = 0;
    long sum2 = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > 0)
        {
            sum1 += input[i];
        }
        else
        {
            sum2 += input[i];
        }
    }
    ansArray[j] = (long)Math.Abs(Math.Abs((decimal)sum1) - Math.Abs((decimal)sum2));
    sum1 = 0;
    sum2 = 0;
}

for (int i = 0; i < t; i++)
{
    Console.WriteLine(ansArray[i]);
}