using jogo_rpg.src.Classes;

public class Program
{
    private static void Main(string[] args)
    {
        Knight arus = new Knight("Arus",15,"Knight");
        Wizard janie = new Wizard("Janie",17,"Wizard");
        Knight inimigo = new Knight("Boss",20,"Knight");
        Console.WriteLine(arus);
        Console.WriteLine(arus.ToString());
        Console.WriteLine(arus.Attack());
        Console.WriteLine(janie.Attack());
        Console.WriteLine(janie.Attack(7));
        
    }
}