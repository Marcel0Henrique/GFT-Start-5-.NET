namespace jogo_rpg.src.Classes
{
    public class Personagem
    {
        public Personagem(string name, string classe)
        {
            this.Name = name;
            this.Level = 1;
            this.Classe = classe;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Classe { get; set; }
        
        //* Sobrescrita de método
        public override string ToString()
        {
            return this.Name + ", " + this.Level + ", " + this.Classe;
        }
    }
}