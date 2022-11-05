//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int t = int.Parse(Console.ReadLine());
int[] ansArray = new int[t];
for (int j = 0; j < t; j++)
{
    int n = int.Parse(Console.ReadLine());
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int sum1 = 0;
    int sum2 = 0;
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
    ansArray[j] = Math.Abs(Math.Abs(sum1) - Math.Abs(sum2));
    sum1 = 0;
    sum2 = 0;
}

for (int i = 0; i < t; i++)
{
    Console.WriteLine(ansArray[i]);
}