using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes = new string[]{"Marcelo", "Maria", "Ester", "Clara", "John"};
        AlterarNome(nomes,"Clara","Rodrigo");
        foreach (var nome in nomes)
        {
            WriteLine(nome);
        }

    }

    static void AlterarNome(string[] lista, string nomeAntigo,string nomeNovo)
    {
        for (var i = 0; i < lista.Length; i++)
        {
            if (lista[i] == nomeAntigo)
            {
                lista[i] = nomeNovo;
            }
        }
    }
}