// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!!");

static double getAvg(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    
    return sum / arr.Length;
}

static double getMax(int[] arr)
{
    return arr.Max();
}

int[] tab = { 1, 2, 3, 4, 5 };
Console.WriteLine(getAvg(tab));