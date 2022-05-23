using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 0, 3, 4, 5, 6, 7, 8, 9, 10, 15, 16, 2, 1, 3, 9, 78, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        var minimo = numeros.Min();
        var maximo = numeros.Max();
        var medio = numeros.Average();
        var soma = numeros.Sum();
        var numerosunicos = numeros.Distinct().ToArray();


        //* Sintaxe de consulta
        var numerosParesQuery =
            from num in numeros
            where num % 2 == 0
            orderby num
            select num;

        //* Sintaxe de metodos
        var numerosParesMetodos = numeros.Where(num => num % 2 == 0).OrderBy(num => num).ToList();

        Console.WriteLine($"\nNumeros Pares Query: {String.Join(", ", numerosParesQuery)}");
        Console.WriteLine($"Numero Pares Métodos: {String.Join(", ", numerosParesMetodos)}");
        Console.WriteLine($"Valor mínimo: {minimo}");
        Console.WriteLine($"Valor médio: {medio}");
        Console.WriteLine($"Valor máximo: {maximo}");
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Numeros distintos: {String.Join(", ", numerosunicos)}");

    }
}