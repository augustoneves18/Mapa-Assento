
    
    
        int totalFileiras = 5;
        int totalColunas = 6;
        char[,] mapa = new char[totalFileiras, totalColunas];
        // Preenche o mapa inicial: 'L' para Livre

        for (int f = 0; f < totalFileiras; f++)
        {

            for (int c = 0; c < totalColunas; c++)
            {

                mapa[f, c] = 'L';

            }


        }

        while (true)
        {

            Console.Clear();

            ExibirMapa(mapa, totalFileiras, totalColunas);
            // Menu de opções 

            Console.WriteLine("\n[1] Reservar Assento");

            Console.WriteLine("[2] Sair ");

            Console.WriteLine("Escolher uma opção;");

            string opcao = Console.ReadLine();

            if (opcao == "2") break;

            if (opcao != "1") continue;

            // solicitar a fileira

            Console.WriteLine(opcao);

            Console.Write($"\nDigite a fileira(1 a {totalFileiras}:)");

            if (!int.TryParse(Console.ReadLine(), out int fEscolhida) || fEscolhida < 1 || fEscolhida > totalFileiras)
            {

                MensagemErro("Fileira inválida! Pressione Qualquer tecla.");

                continue;
            }

            // Solicita a coluna 

            Console.Write($"Digite o assento/coluna({totalColunas}:)");
            {
                if (!int.TryParse(Console.ReadLine(), out int cEscolhida) || cEscolhida <
                     1 || cEscolhida > totalColunas)

                    MensagemErro("Assento inválido! Pressione qualquer tecla.");
                continue;

            

            // Ajusta para o índice do array (base 0)
            int indexF = fEscolhida - 1;
            int indexC = cEscolhida - 1;
            // Verifica status do assento
            if (mapa[indexF, indexC] == 'O')
            {
                MensagemErro("Este assento já está ocupado! Escolha outro.");
            }
            else
            {
                mapa[indexF, indexC] = 'O'; // 'O' para Ocupado
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAssento reservado com sucesso!");
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        static void ExibirMapa(char[,] mapa, int fileiras, int colunas)
        {
            Console.WriteLine("=== MAPA DE ASSENTOS ===");
            Console.WriteLine("L = Livre | O = Ocupado\n");
            // Imprime os números das colunas
            Console.Write(" ");
            for (int c = 1; c <= colunas; c++)
            {


                Console.Write($"{c} ");
            }
            Console.WriteLine("\n " + new string('-', colunas * 2));
            // Imprime as fileiras com os assentos
            for (int f = 0; f < fileiras; f++)
            {
                Console.Write($"F{f + 1} | ");
                for (int c = 0; c < colunas; c++)
                {
                    // Altera a cor do caractere para facilitar a leitura visual
                    if (mapa[f, c] == 'O') Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{mapa[f, c]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        static void MensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{mensagem}");
            Console.ResetColor();
            Console.ReadKey();
        }
    }






