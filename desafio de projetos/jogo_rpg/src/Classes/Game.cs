using static System.Console;
namespace jogo_rpg.src.Classes
{
    public class Game
    {
        public Game()
        {
        }

        public void Init()
        {

            MainMenu();


        }

        static void MainMenu()
        {
            int input;
            WriteLine("\n*** Jogo de RPG ***\n");
            WriteLine("1 - Iniciar\n2 - Sair\n");

            Write("Digite sua escolha: ");
            input = Convert.ToInt32(ReadLine());

            switch (input)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    System.Diagnostics.Process.GetCurrentProcess().Close();
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

            WriteLine("\n*** Criação de Personagem ***\n");

            Write("Digite o nome do personagem: ");
            name = ReadLine();

            WriteLine("\n*** Classe ****\n");
            WriteLine("1 - Guerreiro\n2 - Ladrão\n3 - Mago\n");

            Write("Digite sua escolha: ");
            classe = Convert.ToInt32(ReadLine());

            if (classe == 1)
            {
                Warrior player = new Warrior(name != null ? name : "Player");
                GameMenu(player);
            }
            else if (classe == 2)
            {
                Thief player = new Thief(name != null ? name : "Player");
                GameMenu(player);
            }
            else
            {
                Wizard player = new Wizard(name != null ? name : "Player");
                GameMenu(player);
            }

        }

        static void GameMenu(Personagem player)
        {
            bool game = true;
            while (game)
            {
                int input;
                WriteLine($"\n***{player.Name.ToUpper()}***\n");

                WriteLine("1 - Explorar\n2 - Descansar\n3 - sair\n");

                Write("Digite sua escolha: ");
                input = Convert.ToInt32(ReadLine());

                switch (input)
                {
                    case 1:
                        Battle(player);
                        break;
                    case 2:
                        player.Rest();
                        WriteLine($"\n--- {player.Name} descansou! ---\n");
                        break;
                    case 3:
                        game = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void Battle(Personagem player)
        {
            Warrior globin = new Warrior("Globin");

            while (true)
            {
                if (player.Classe == Personagem.Classes.Warrior || player.Classe == Personagem.Classes.Thief)
                {
                    int input;
                    WriteLine("\n***Batalha***\n");

                    WriteLine("\n***************************\n");

                    WriteLine($"Jogador: {player.Name}\n");
                    WriteLine($"Vida: {player.Hp}\n");

                    WriteLine("\n***************************\n");

                    WriteLine($"Inimigo: {globin.Name}\n");
                    WriteLine($"Vida: {globin.Hp}\n");
                    WriteLine("1 - Atacar\n2 - Fugir\n");

                    Write("Digite sua escolha: ");
                    input = Convert.ToInt32(ReadLine());

                    if (input == 1)
                    {
                        Attack(player, globin);
                    }
                    else if (input == 2)
                    {
                        WriteLine($"--- {player.Name} fugiu da batalha! ---");
                        break;
                    }
                    else
                    {
                        WriteLine($"\n--- OPÇÃO INCORRETA! ---\n");
                    }
                }
                else
                {
                    int input;
                    WriteLine("\n***Batalha***\n");

                    WriteLine("\n***************************\n");

                    WriteLine($"Jogador: {player.Name}\n");
                    WriteLine($"Vida: {player.Hp}\n");

                    WriteLine("\n***************************\n");

                    WriteLine($"Inimigo: {globin.Name}\n");
                    WriteLine($"Vida: {globin.Hp}\n");
                    WriteLine("1 - Atacar\n2 - Magia\n3 - Fugir\n");

                    Write("Digite sua escolha: ");
                    input = Convert.ToInt32(ReadLine());

                    if (input == 1)
                    {
                        Attack(player, globin);
                    }
                    else if (input == 2)
                    {
                        WriteLine("\n***Batalha***\n");
                        WriteLine("1 - Bola de Fogo\n2 - Lamina de Vento\n3 - Relampago\n");

                        Write("Digite sua escolha: ");
                        int inputMagic = Convert.ToInt32(ReadLine());

                        if (inputMagic == 1)
                        {
                            Wizard playerMagic = (Wizard)player;
                            playerMagic.Magic = Wizard.Spells.FireBall;
                        } else if (inputMagic == 2)
                        {
                            Wizard playerMagic = (Wizard)player;
                            playerMagic.Magic = Wizard.Spells.Windblade;
                        } else if (inputMagic == 3)
                        {
                            Wizard playerMagic = (Wizard)player;
                            playerMagic.Magic = Wizard.Spells.Lightning;
                        }

                        Attack(player, globin, true);
                    }
                    else if (input == 3)
                    {
                        WriteLine($"\n--- {player.Name} fugiu da batalha! ---\n");
                        break;
                    }
                    else
                    {
                        WriteLine($"\n--- OPÇÃO INCORRETA! ---\n");
                    }
                }
            }




        }

        static void Attack(Personagem player, Personagem enemy, bool magic = false)
        {

            if (!magic)
            {
                WriteLine($"---{player.Name} atacou {enemy.Name} e causou {player.PhysicalAttack()} de dano---");
                enemy.Hp -= player.PhysicalAttack();
                WriteLine($"---{enemy.Name} revidou causando {enemy.PhysicalAttack()} de dano á {player.Name}---");
                player.Hp -= enemy.PhysicalAttack();
            }
            else
            {
                Wizard playerMagic = (Wizard)player;
                WriteLine($"---{playerMagic.Name} atacou {enemy.Name} e causou {playerMagic.MagicAttack(playerMagic.Magic)} de dano---");
                enemy.Hp -= playerMagic.MagicAttack(playerMagic.Magic);
                WriteLine($"---{enemy.Name} revidou causando {enemy.PhysicalAttack()} de dano á {playerMagic.Name}---");
                playerMagic.Hp -= enemy.PhysicalAttack();
            }

        }

    }
}