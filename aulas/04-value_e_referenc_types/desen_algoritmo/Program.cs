using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[]{0,2,4,6,8};
        Write($"Digite o número que vc gostaria de encontrar:");
        int num = int.Parse(ReadLine());

        int idxEncontrado = EncontrarNumero(numeros, num);
        WriteLine($"Posição do numero encontrado: {idxEncontrado}");
        
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (var i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
            {
                return i;
            }
        }

        return -1;
    }
}