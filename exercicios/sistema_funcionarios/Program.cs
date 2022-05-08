using sistema_funcionarios.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Sistema db = new Sistema();
        
        db.Connection();

        while (true)
        {
            Console.WriteLine("*** Login ***");

            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Senha: ");
            string? senha = Console.ReadLine();

            if (db.Login(email,senha))
            {
                
            }
        }
    }
}