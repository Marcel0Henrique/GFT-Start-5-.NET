using CadastroDeSeries.Classes;
using CadastroDeSeries.Enum;

internal class Program
{
    static SerieRepositorio repositorio = new SerieRepositorio();
    private static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarSeries();
                    break;
                default:
                    break;
            }
            
        }
    }

    private static string ObterOpcaoUsuario()
    {
        System.Console.WriteLine("\nDio Series a seu dispor!!!");
        System.Console.WriteLine("Informe a opção desejada: ");

        System.Console.WriteLine("1 - Listar series");
        System.Console.WriteLine("2 - Inserir nova serie");
        System.Console.WriteLine("3 - Atualizar serie");
        System.Console.WriteLine("4 - Excluir serie");
        System.Console.WriteLine("5 - Visualizar serie");
        System.Console.WriteLine("C - Limpar tela");
        System.Console.WriteLine("X - sair\n");

        string opcaoUsuario = Console.ReadLine().ToUpper();
        System.Console.WriteLine();
        return opcaoUsuario;
    }

    private static void ListarSeries()
    {
        System.Console.WriteLine("Listar Series");
        var lista = repositorio.Lista();

        if (lista.Count == 0)
        {
            System.Console.WriteLine("Nenhuma serie cadastrada");
        }
        foreach (var item in lista)
        {
            Console.WriteLine($"#ID {item.RetornarId}: - {item.RetornarTitulo} ");
            
        }
    }

    private static void InserirSerie()
    {
         System.Console.WriteLine("Inserir nova serie");

         foreach (int i in Enum.GetValues(typeof(Genero)))
         {
             Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero),i)}");  
         }
         System.Console.Write("Digite o genero entre as opções acima: ");
         int entradaGenero = Convert.ToInt32(Console.ReadLine());

         System.Console.Write("Digite o titulo da serie: ");

    }
}