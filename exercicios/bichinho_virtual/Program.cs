using bichinho_virtual.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Bichinho animal = new Bichinho();
        animal.nome = "teste";
        Console.WriteLine(animal.nome);
    }
}