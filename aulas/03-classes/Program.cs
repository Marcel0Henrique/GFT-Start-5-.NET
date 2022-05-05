internal class Program
{
    private static void Main(string[] args)
    {
        Professor p = new Professor("Carlos", 32, 1.75);
        Animal n = new Animal();
        Console.WriteLine($"Nome: {p.nome}, Idade: {p.idade}, Altura: {p.altura}"); 
        n.idade = 4;
        n.envelhecer();
        Console.WriteLine(n.idade);
    }
}