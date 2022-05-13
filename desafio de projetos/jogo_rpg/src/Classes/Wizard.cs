namespace jogo_rpg.src.Classes
{
    public class Wizard : Personagem
    {
        public Wizard(string name, int level, string classe) : base(name, level, classe)
        {
        }

        public override string Attack()
        {
            return $"{this.Name} lançou magia!";
        }

        public string Attack(int bonus)
        {
            return $"{this.Name} lançou magia com bonus de attack {bonus}";
        }
    }
}