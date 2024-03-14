// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!!");

static double getAvg(int[] tab)
{
    int sum = 0;
    
    for (int i = 0; i < tab.Length; i++)
    {
        sum += tab[i];
    }
    
    return sum / tab.Length;
}

static double getMax(int[] tab)
{
    return tab.Max();
}

int[] tab = { 1, 2, 3, 4, 5 };
Console.WriteLine(getAvg(tab));