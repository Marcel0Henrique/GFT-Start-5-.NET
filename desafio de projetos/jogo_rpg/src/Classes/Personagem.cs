namespace jogo_rpg.src.Classes
{
    public abstract class Personagem
    {
        public Personagem(string name, int level = 1, int hp = 100, int mp = 20, int strength = 5, int agility = 5, int intelligence = 5)
        {
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
            this.Mp = mp;
            this.Classe = Classes.Warrior;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;

        }

        public string Name { get; set; }

        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }



        public enum Classes
        {
            Warrior,
            Mage,
            Thief,

        };

        public Classes Classe { get; set; }

        



        public int PhysicalAttack()
        {
            if (this.Classe == Classes.Warrior)
            {
                int StrengthWeight = 3;
                int AgilityWeight = 2;
                int IntelligenceWeight = 1;
                int Attack = ((this.Strength * StrengthWeight) + (this.Agility * AgilityWeight) + (this.Intelligence * IntelligenceWeight)) / (StrengthWeight + AgilityWeight + IntelligenceWeight);

                return Attack;

            }
            else if (this.Classe == Classes.Thief)
            {
                int StrengthWeight = 2;
                int AgilityWeight = 3;
                int IntelligenceWeight = 1;
                int Attack = ((this.Strength * StrengthWeight) + (this.Agility * AgilityWeight) + (this.Intelligence * IntelligenceWeight)) / (StrengthWeight + AgilityWeight + IntelligenceWeight);

                return Attack;

            }
            else
            {
                int StrengthWeight = 1;
                int AgilityWeight = 2;
                int IntelligenceWeight = 1;
                int Attack = ((this.Strength * StrengthWeight) + (this.Agility * AgilityWeight) + (this.Intelligence * IntelligenceWeight)) / (StrengthWeight + AgilityWeight + IntelligenceWeight);

                return Attack;
            }
        }
        
    }
}