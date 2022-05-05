using bichinho_virtual.classes;

namespace bichinho_virtual
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Menu();
            Fazenda teste = new Fazenda();
            teste.NovoAnimal("Tom");
            teste.NovoAnimal("Jerry");
            teste.NovoAnimal("Cath");
            teste.VerAnimais();
        }

        static void Menu()
        {
            while (true)
            {
                int? escolha;
                Console.WriteLine("\n***Fazenda de Bichinhos***\n");
                Console.WriteLine("1 - Adicionar animal\n2 - Ver animais\n3 - Colocar comida\n4 - Brincar com os animais\n5 - Apagar a luz\n");
                var s = Console.ReadLine();
                if (s != null)
                {   
                    Console.Write("Digite uma opção: ");
                    escolha = int.Parse(s);
                    
                    break;
                } 
            }
        }
    }
}