namespace bichinho_virtual.classes
{
    public class Bichinho
    {
        //* Atributos
        private string? _nome;
        private string? _especie;
        private int _fome;
        private int _tedio;
        private int _sono;

        
        public Bichinho(string? nome)
        {
            Random rand = new Random();
            this.nome = nome;
            this.fome = rand.Next(0, 100);
            this.tedio = rand.Next(0, 10);
            this.sono = rand.Next(0, 100);

            string[] especies = { "Gato", "Cachorro", "Passaro" };

            this.especie = especies[rand.Next(0, 2)];
        }


        //* Getters e Setters
        public string? nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string? especie
        {
            get { return this._especie; }
            set { this._especie = value; }
        }
        public int fome
        {
            get { return _fome; }
            set { _fome = value; }
        }
        public int tedio
        {
            get { return _tedio; }
            set { _tedio = value; }
        }
        public int sono
        {
            get { return _sono; }
            set { _sono = value; }
        }

    }
}