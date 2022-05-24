using static System.Console;
using static System.Convert;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] v = ReadLine().Split();
        int p = ToInt32(v[0]) * ToInt32(v[1]);
        WriteLine($"{p}");
    }
}