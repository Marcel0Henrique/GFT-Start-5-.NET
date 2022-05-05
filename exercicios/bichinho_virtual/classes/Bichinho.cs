namespace bichinho_virtual.classes
{
    public class Bichinho
    {
        //* Atributos
        private string? _nome;
        private int _vida;
        private int _fome;
        private int _tedio;
        private int _sono;

        public Bichinho()
        {
        }

        public Bichinho(string? nome)
        {
            Random rand = new Random();
            this.nome = nome;
            this.vida = 100;
            this.fome = rand.Next(0,100);
            this.tedio = rand.Next(0,100);
            this.sono = rand.Next(0,100);
           
        }



        //* Getters e Setters
        public string? nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int vida
        {
            get { return _vida; }
            set { _vida = value; }
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