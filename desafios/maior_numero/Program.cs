using System;
using static System.Console;
using static System.Convert;
internal class Program
{
    private static void Main(string[] args)
    {
        int n;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                n = ToInt32(Console.ReadLine());
                if(n > maior)
                {
                    maior = n;
                    posicao = i;     
                } 
            }
            WriteLine(maior);
            WriteLine(posicao);
    }
}