using static System.Console;
namespace array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] pares = new int[]{0,2,4,6,8,10,12,14,16,18,20};

            foreach (var num in pares)
            {
                WriteLine(num);
            }

            MudarParaImpar(pares);

            foreach (var num in pares)
            {
                WriteLine(num);
            }
        }

        static void MudarParaImpar(int[] pares)
        {
            for (var i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }
    }
}
