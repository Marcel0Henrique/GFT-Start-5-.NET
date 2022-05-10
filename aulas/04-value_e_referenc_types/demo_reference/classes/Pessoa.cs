public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Documento { get; set; }

    public void AlterarNome(string nome)
    {
        this.Nome = nome;
    }
}