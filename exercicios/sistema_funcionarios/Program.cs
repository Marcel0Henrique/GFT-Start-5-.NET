using sistema_funcionarios.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Sistema db = new Sistema();

        db.Connection();
        db.Listar();

        // while (true)
        // {
        //     LoginTela(db);
        // }
    }

    static void LoginTela(Sistema db)
    {
        
        Console.WriteLine("*** Login ***\n");

        Console.Write("Email: ");
        string? email = Console.ReadLine();
        Console.Write("Senha: ");
        string? senha = Console.ReadLine();

        if (db.Login(email, senha))
        {
            LimparTela();
            MainTela();

        }
    }

    static void MainTela()
    {  
        LimparTela();
        string? s;
        int opcao;
        Console.WriteLine("*** Sistema de Funcionarios ***\n");
        Console.WriteLine("1 - Listar Funcionarios");
        Console.WriteLine("2 - Cadastrar funcionario");
        Console.WriteLine("3 - Promover Funcionario");
        Console.WriteLine("4 - Apagar Funcionario\n");

        Console.Write("Digite uma opção: ");
        s = Console.ReadLine();
        if (s != null)
        {
            try
            {
                opcao = int.Parse(s);
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine("Digite uma opção valida!");
                 MainTela();
            }
        }
    }
    static void LimparTela()
    {
        for (var i = 0; i < 100; i++)
        {
            Console.WriteLine("");
        }
    }
    
}