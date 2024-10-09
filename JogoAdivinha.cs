using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Isso é um Jogo de adivinhação de números!!");
        Console.WriteLine("Escolha a dificuldade:");
        Console.WriteLine("Digite 1 para adivinhar de um a 10");
        Console.WriteLine("Digite 2 para adivinhar de um a 20");
        Console.WriteLine("Digite 3 para adivinhar de um a 30");

        int opcao;
        if (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número de 1 a 3.");
            return;
        }

        switch (opcao)
        {
            case 1:
                guess1();
                break;
            case 2:
                guess2();
                break;
            case 3:
                guess3();
                break;
            default:
                Console.WriteLine("Escolha uma das opções (1-3)");
                break;
        }
    }

    private static void guess1()
    {
        Random RANDOMICO = new Random();
        string input;

        while (true)
        {
            int nr = RANDOMICO.Next(1, 11);
            Console.Write("Entre um número de 1 a 10 (ou digite 'sair' para parar): ");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }

            if (!int.TryParse(input, out int pedido))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }

            if (pedido == nr)
            {
                Console.WriteLine("Acertou, era {0}", nr);
            }
            else
            {
                Console.WriteLine("Errou, era {0}", nr);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione <Enter> para tentar um novo número ou digite 'sair' para encerrar...");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }
        }
    }

    private static void guess2()
    {
        Random RANDOMICO = new Random();
        string input;

        while (true)
        {
            int nr = RANDOMICO.Next(1, 21);
            Console.Write("Entre um número de 1 a 20 (ou digite 'sair' para parar): ");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }

            if (!int.TryParse(input, out int pedido))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }

            if (pedido == nr)
            {
                Console.WriteLine("Acertou, era {0}", nr);
            }
            else
            {
                Console.WriteLine("Errou, era {0}", nr);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione <Enter> para tentar um novo número ou digite 'sair' para encerrar...");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }
        }
    }

    private static void guess3()
    {
        Random RANDOMICO = new Random();
        string input;

        while (true)
        {
            int nr = RANDOMICO.Next(1, 31);
            Console.Write("Entre um número de 1 a 30 (ou digite 'sair' para parar): ");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }

            if (!int.TryParse(input, out int pedido))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }

            if (pedido == nr)
            {
                Console.WriteLine("Acertou, era {0}", nr);
            }
            else
            {
                Console.WriteLine("Errou, era {0}", nr);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione <Enter> para tentar um novo número ou digite 'sair' para encerrar...");
            input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                Console.WriteLine("Você decidiu sair do jogo.");
                break;
            }
        }
    }
}



