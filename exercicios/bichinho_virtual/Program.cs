using bichinho_virtual.classes;

namespace bichinho_virtual
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bichinho animal = new Bichinho("Tom");
            Console.WriteLine(animal.fome);
            Console.WriteLine(animal.especie);
        }
    }
}