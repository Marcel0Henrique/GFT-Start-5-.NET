using CadastroDeSeries.Enum;
namespace CadastroDeSeries.Classes
{
    public class Series : EntidadeBase
    {


        //* Atributos
        private Genero Genero { get; set; }
        public string Titulo { get; set; }

        public string? Descricao { get; set; }

        public int Ano { get; set; }
        public bool Excluido { get; set; }

        //* Construtor  
        public Series(int id, Genero genero, string titulo, string? descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override bool Equals(object? obj)
        {
            return obj is Series series &&
                   Id == series.Id &&
                   Genero == series.Genero &&
                   Titulo == series.Titulo &&
                   Descricao == series.Descricao &&
                   Ano == series.Ano;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Genero, Titulo, Descricao, Ano);
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string RetornarTitulo()
        {
            return this.Titulo;
        }
        public int RetornarId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}