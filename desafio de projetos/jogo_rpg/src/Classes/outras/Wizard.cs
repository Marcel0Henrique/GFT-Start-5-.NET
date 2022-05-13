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
            if (bonus > 6)
            {
                return $"{this.Name} lançou uma magia super efetiva com bonus de attack de {bonus}";
            }else
            {
                return $"{this.Name} lançou uma magia fraca com bonus de attack de {bonus}";
            }

            
        }
    }
}