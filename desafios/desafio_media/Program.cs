using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {   
        const double pesoNota1 = 2, pesoNota2 = 3, pesoNota3 = 5;
        const double pesoMedia  = pesoNota1 + pesoNota2 + pesoNota3;
        double nota1,nota2,nota3, media;

        nota1 = double.Parse(ReadLine());
        nota2 = double.Parse(ReadLine());
        nota3 = double.Parse(ReadLine());

        nota1 = nota1 * pesoNota1;
        nota2 = nota2 * pesoNota2;
        nota3 = nota3 * pesoNota3;
        media = (nota1 + nota2 + nota3) / pesoMedia;
        
        
        WriteLine($"MEDIA = {media.ToString("0.0")}");
            
        


    }
}