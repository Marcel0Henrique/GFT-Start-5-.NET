namespace jogo_rpg.src.Classes
{
    public class Personagem2
    {
        public Personagem2(string name, int level = 1, int hp = 100, int mp = 20, int strength = 10, int agility = 5, int intelligence = 5, int Constitution = 10 )
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.Classe = Classes.Warrior;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
            this.Constitution = Constitution;
        }

        public string Name { get; set; }

        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        
        Classes Classe;
        

        enum Classes
        {
            Warrior,
            Mage,
            Thief,
            
        };

        
        public virtual int PhysicalAttack(Personagem2 inimigo)
        {
            if (Classe == Classes.Warrior)
            {
                //* Usar media poderada para calcular o ataque
                return 2;
            }

            return 2;
            
        }

    }
}