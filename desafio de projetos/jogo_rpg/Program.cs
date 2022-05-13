using jogo_rpg.src.Classes;

public class Program
{
    private static void Main(string[] args)
    {
        Personagem arus = new Personagem("Arus",15,"Knight");
        Personagem inimigo = new Personagem("Boss",20,"Paladin");
        Console.WriteLine(arus);
        Console.WriteLine(arus.ToString());
        Console.WriteLine(arus.Attack());
        
    }
}