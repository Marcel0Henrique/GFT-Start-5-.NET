using static System.Console;
using static System.Math;
using static System.Convert;
internal class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14159;
        double r = ToDouble(ReadLine());
        double volume = ((4 * pi) * Pow(r,3.0)) / 3;

        WriteLine($"VOLUME = {volume.ToString("0.000")}");
    }
}