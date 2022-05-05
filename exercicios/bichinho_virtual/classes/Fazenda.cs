using bichinho_virtual.classes;

public class Fazenda
{
    public Fazenda()
    {
    }

    List<Bichinho> curral = new List<Bichinho>();

    public void NovoAnimal(string nome)
    {   
        Bichinho animal = new Bichinho(nome);
        curral.Add(animal);
    }
    public void Alimentar()
    {
        foreach (var animal in curral)
        {
            animal.Comer();
        }
    }
    public void Dormir()
    {
        foreach (var animal in curral)
        {
            animal.Dormir();
        }
    }
    public void Brincar()
    {
        foreach (var animal in curral)
        {
            animal.Brincar();
        }
    }

    public void VerAnimais()
    {
        foreach (var animal in curral)
        {
            Console.WriteLine($"\n***{animal.nome}***");
            Console.WriteLine($"Especie: {animal.especie}");
            Console.WriteLine($"Fome: {animal.fome}");
            Console.WriteLine($"Sono: {animal.sono}");
            Console.WriteLine($"Tedio: {animal.tedio}\n");
        }
    }
}