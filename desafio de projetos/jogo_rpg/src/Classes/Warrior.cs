namespace jogo_rpg.src.Classes
{
    public class Warrior : Personagem
    {
        public Warrior(string name, int level = 1, int hp = 100, int mp = 20, int strength = 15, int agility = 10, int intelligence = 5) : base(name, level, hp, mp, strength, agility, intelligence)
        {
            this.Classe = Classes.Warrior;
        }
    }
}