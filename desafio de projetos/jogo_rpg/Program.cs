using jogo_rpg.src.Classes;

public class Program
{
    private static void Main(string[] args)
    {
        Personagem arus = new Personagem("Arus",15,"Knight");
        Personagem inimigo = new Personagem("Boss",15,"Knight");
        Console.WriteLine(arus);
        Console.WriteLine(arus.ToString());
        
    }
}