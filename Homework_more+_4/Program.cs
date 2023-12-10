class Program
{
    static void Main()
    {
        Console.WriteLine("Input sequence length");
        int length = int.Parse(Console.ReadLine()); 
        int result = CountVariations(length);

        Console.WriteLine($"Number of variations: {result}");
    }

    static int CountVariations(int length)
    {
        if (length < 1)
        {
            return 0;
        }

        int[] variations = new int[length];

        variations[0] = 2;
        variations[1] = 3;

        for (int i = 2; i < length; i++)
        {
            variations[i] = variations[i - 1] + variations[i - 2];
        }

        return variations[length - 1];
    }
}
