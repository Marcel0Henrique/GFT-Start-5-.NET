internal class Program
{
    static void Declaracoes()
    {

        //* Declarando variaveis
        int a;
        double b = 4.7;
        a = 10; //? atribuindo valor a variavel

        //* Declarando constantes
        const int c = 5;
        const double pi = 3.14;

        //* Declarando variavel nullabe
        int? nula = null; //? variavel revebendo valor nulo

        //* Declarando variaveis na mesma linha
        int d = 9, e = 16, f = 18;

        Console.WriteLine(a + b + c + e + d + f + pi);

        Console.WriteLine(nula.ToString());

    }

    static void InstrucaoIf(string[] lista)
    {
        if (lista.Length == 0)
        {
            Console.WriteLine("Lista vazia");
        }
        else if (lista.Length == 1)
        {
            Console.WriteLine("Lista tem 1 item");
        }
        else
        {
            Console.WriteLine("Lista tem mais de 1 item");
        }
    }

    static void IntrucaoSwitch(string[] args)
    {
        int numeroDeArgumentos = args.Length;

        switch (numeroDeArgumentos)
        {
            case 0:

                Console.WriteLine("Argumentos tem 0 itens");
                break;
            case 1:
                Console.WriteLine("Argumentos tem 1 item");
                break;
            default:
                Console.WriteLine($"Argumentos tem {numeroDeArgumentos} itens");
                break;
        }
    
    }

    static void InstrucaoWhile (string[] args)
    {
        int i = 0;
        while (i < args.Length)
        {
            Console.WriteLine(args[i]);
            i++;
        }
    }

    static void InstrucaoDo()
    {
        string? texto;
        do
        {   Console.WriteLine();
            texto = Console.ReadLine();
            Console.WriteLine(texto);
        } while (!string.IsNullOrEmpty(texto));
    }
    public static void Main(string[] args)
    {   
        string[] nome = {"Marcelo", "Henrique", "Monteiro"};
        Declaracoes();
        InstrucaoIf(lista:nome);
        IntrucaoSwitch(args:nome);
        InstrucaoWhile(args:nome);
        InstrucaoDo();
    }
}