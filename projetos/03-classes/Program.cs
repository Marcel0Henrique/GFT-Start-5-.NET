internal class Program
{
    private static void Main(string[] args)
    {
        Professor p = new Professor("Carlos", 32, 1.75);
        Console.WriteLine($"Nome: {p.nome}, Idade: {p.idade}, Altura: {p.altura}"); 
    }
}