using demo_reference.classes;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {   
        Pessoa p1 = new Pessoa("Marcos");

        WriteLine(p1.Nome);
    }
}