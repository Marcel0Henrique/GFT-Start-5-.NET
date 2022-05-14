namespace jogo_rpg.src.Classes
{
    public class Wizard : Personagem
    {
        public Wizard(string name, int level = 1, int hp = 100, int mp = 20, int strength = 5, int agility = 5, int intelligence = 15) : base(name, level, hp, mp, strength, agility, intelligence)
        {
        }

        public enum Spells
        {
            FireBall = 15,
            Windblade = 10,
            Lightning = 20,
        }

        public int MagicAttack(Spells magic)
        {
            if (this.Classe == Classes.Warrior)
            {

                int IntelligenceWeight = 3;
                int Attack = (((int)magic * IntelligenceWeight) + (Intelligence * IntelligenceWeight)) / (IntelligenceWeight * 2);

                return Attack;

            }
            else if (this.Classe == Classes.Thief)
            {

                int IntelligenceWeight = 3;
                int Attack = (((int)magic * IntelligenceWeight) + (Intelligence * IntelligenceWeight)) / (IntelligenceWeight * 2);

                return Attack;

            }
            else
            {

                int IntelligenceWeight = 3;
                int Attack = (((int)magic * IntelligenceWeight) + (Intelligence * IntelligenceWeight)) / (IntelligenceWeight * 2);

                return Attack;
            }

        }
    }
}