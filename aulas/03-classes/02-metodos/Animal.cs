public class Animal
{
    //* Atributos
    private string? _nome;
    private int _idade;
    private string? _especie;

    //*Getters e Setters
    public string? nome
    {
        get { return this._nome; }
        set { this._nome = value; }
    }
    public int idade
    {
        get { return this._idade; }
        set { this._idade = value; }

    }
    public string? especie
    {
        get { return this._especie; }
        set { this._especie = value; }
    }

    //*Metodos
    public void envelhecer()
    {
        Console.WriteLine("Envelheceu");
        idade++;
    }
}