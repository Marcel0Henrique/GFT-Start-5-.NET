using static System.Console;
public class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        a = Adicionar20(a);
        
        WriteLine($"valor de A: {a}");
    }

    static int Adicionar20(int x)
    {
        return x + 20;
    }
}