using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes = new string[] { "Marcelo", "Maria", "Ester", "Clara", "John" };



        //? Imprimindo a lista de nomes
        WriteLine($"***Lista de nomes***\n{string.Join(", ", nomes)}");

        int index = LocalizaNome(nomes, "Ester");

        AlterarNome(nomes, index, "Caio");

        WriteLine($"\n***Lista de nomes alterada***\n{string.Join(", ", nomes)}");

    }

    static int LocalizaNome(string[] lista, string nome)
    {
        for (int i = 0; i <= lista.Length; i++)
        {
            if (lista[i] == nome)
            {
                return i;
            }
        }

        return -1;
    }

    static void AlterarNome(string[] lista, int index, string nome)
    {
        try
        {
            lista[index] = nome;
        }
        catch (System.Exception ex)
        {
            WriteLine($"Não foi possível alterar o nome\n Erro:{ex}");
        }
    }
}