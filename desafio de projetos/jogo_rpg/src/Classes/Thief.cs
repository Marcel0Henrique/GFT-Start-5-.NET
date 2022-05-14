namespace jogo_rpg.src.Classes
{
    public class Thief : Personagem
    {
        public Thief(string name, int level = 1, int hp = 100, int mp = 20, int strength = 10, int agility = 15, int intelligence = 5) : base(name, level, hp, mp, strength, agility, intelligence)
        {
            this.Classe = Classes.Thief;
        }
    }
}