namespace demo_reference.classes
{
    public class Pessoa
    {

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Documento { get; set; }


        public void AlterarNome(string nome)
        {
            Nome = nome;
        }
    }
}