internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        //* Sintaxe de consulta
        var numerosPares =
            from num in numeros
            where num % 2 == 0
            orderby num
            select num;
    }
}