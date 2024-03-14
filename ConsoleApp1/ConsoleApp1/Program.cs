// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!!");

static double getAvg(int[] tab1)
{
    int sum = 0;
    
    for (int i = 0; i < tab1.Length; i++)
    {
        sum += tab1[i];
    }
    
    return sum / tab1.Length;
}

static double getMax(int[] tab1)
{
    return tab1.Max();
}

int[] tab = { 1, 2, 3, 4, 5 };
Console.WriteLine(getAvg(tab));