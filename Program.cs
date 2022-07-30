class Program
{
    static void Main()
    {
        int[] foo = new int[] { 0, 1, 2, 3, 4 };
        int fooCounter = 0;

        //Second Array created with a loop
        int m = 100;
        int[] bar = new int[m];
        int barCounter = 0;

        for (int i = 0; i < m; i++)
        {
            bar[i] = i;
        }
        foreach (int num1 in foo)
        {
            if (num1 % 2 == 0)
            {
                fooCounter++;
            }
        }
        foreach (int num2 in bar)
        {
            if (num2 % 2 == 0)
            {
                barCounter++;
            }
        }
        Console.WriteLine("The total number of even numbers in foo are: {0}. \n", fooCounter);
        Console.WriteLine("The total number of even numbers in bar are: {0}. \n", barCounter);
    }
}