using demo_reference.classes;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {   
        Pessoa p1 = new Pessoa("Marcos");
        p1.Idade = 26;
        p1.Documento = "14523";

        p1.AlterarNome("Manoel");

        WriteLine(p1.Nome);
    }
}