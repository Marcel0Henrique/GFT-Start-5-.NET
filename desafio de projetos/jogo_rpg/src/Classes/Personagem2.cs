namespace jogo_rpg.src.Classes
{
    public class Personagem2
    {
        public Personagem2(string name, int level = 1, int hp = 100, int mp = 20)
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.Classe = Classes.Warrior;
        }

        public string Name { get; set; }

        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        
        Classes Classe;
        

        enum Classes
        {
            Warrior,
            Mage,
            Thief,
            
        };

        
        

    }
}