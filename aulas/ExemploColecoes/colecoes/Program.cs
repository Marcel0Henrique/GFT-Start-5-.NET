internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 1;
        arrayInteiros[1] = 2;
        arrayInteiros[2] = 3;

        foreach (var item in arrayInteiros)
        {
            Console.WriteLine(item);
        }
    }
}