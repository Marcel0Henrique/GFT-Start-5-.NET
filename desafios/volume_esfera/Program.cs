using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14159;
        double r = Convert.ToDouble(ReadLine());
        double volume = ((4 * pi) * Math.Pow(r,3.0)) / 3;

        WriteLine($"VOLUME = {volume.ToString("0.000")}");
    }
}