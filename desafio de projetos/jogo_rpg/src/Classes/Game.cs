using static System.Console;
namespace jogo_rpg.src.Classes
{
    public class Game
    {
        public void Init()
        {
            while(true)
            {
                MainMenu();
            }

        }

        static void MainMenu()
        {
            int input;
            WriteLine("*** Jogo de RPG ***\n");
            WriteLine("1 - Iniciar\n2 - Sair\n");
            
            Write("Digite sua escolha: ");
            input = Convert.ToInt32(ReadLine());
            
            switch (input)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    break;
                default:
                    WriteLine("Opção invalida!");
                    break;
            }
            
        }

        static void Start()
        {
            string? name;
            int classe;

            WriteLine("*** Jogo de RPG ***");
            
            Write("Digite o nome do personagem: ");
            name = ReadLine();

            Write("\n*** Classe ****");
            WriteLine("1 - Guerreiro\n2 - Ladrão\n3 - Mago");

            Write("Digite sua escolha: ");
            classe = Convert.ToInt32(ReadLine());

            if (classe == 1)
            {
                Warrior player = new Warrior(name != null ? name :  "Player");
                GameMenu(player);
            } else if (classe == 2)
            {
                Thief player = new Thief(name != null ? name :  "Player");
                GameMenu(player);
            } else
            {
                Wizard player = new Wizard(name != null ? name :  "Player");
                GameMenu(player);
            }
            
        }

        static void GameMenu(Personagem player)
        {
            int input;
            WriteLine("*** Jogo de RPG ***");
            
            WriteLine("1 - Explorar\n2 - Descansar\n3 - sair");

            Write("Digite sua escolha: ");
            input = Convert.ToInt32(ReadLine());

            switch (input)
            {
                case 1:

                    break;
                case 2:
                    player.Rest();
                    break;
                case 3:
                    
                    break;
                default:
                    break;
            }
        }
        


    }
}