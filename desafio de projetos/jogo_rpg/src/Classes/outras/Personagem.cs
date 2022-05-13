namespace jogo_rpg.src.Classes
{   
    //* uma classe abstract não pode ser instanciada, apenas herdada
    public abstract class Personagem
    {
        public Personagem(string name, int level,string classe)
        {
            this.Name = name;
            this.Level = level;
            this.Classe = classe;
            this.Hp = 100;
            this.Mp = 20;
        }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Level { get; set; }
        public string Classe { get; set; }
        
        //* Sobrescrita de método
        public override string ToString()
        {
            return this.Name + ", " + this.Level + ", " + this.Classe;
        }

        //* Virtual permite sobrescrever quando for herdado a classe
        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada!";
        }
    }
}