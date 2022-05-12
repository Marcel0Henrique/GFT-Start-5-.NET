using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 5;
        Adicionar20(ref n);
        WriteLine($"{n}");


    }

    static void Adicionar20(ref int num)
    {
        num += 20;
    }
}