internal class Program
{
    static void Declaracoes(){

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

    static void intrucaoIf(String[] lista){
        if (lista.Length == 0)
        {
            Console.WriteLine("Lista vazia");
        }else if(lista.Length == 1){
            Console.WriteLine("Lista tem 1 item");
        }else
        {
            Console.WriteLine("Lista tem mais de 1 item");
        }
    }

    public static void Main(string[] args)
    {
        Declaracoes();
    }
}