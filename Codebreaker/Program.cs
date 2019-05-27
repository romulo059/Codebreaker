using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // APP Codebreaker - Rômulo Guedes Ferreira - 27/05/2019

            // OBJETIVO
            // Sua missão é implementar uma versão em C# do jogo Codebreaker.
            // O jogo pode ser jogado por um ou dois jogadores, sendo um deles o criador do código e o outro o decifrador do código.
            // O código é uma sequencia de 6 números de 1 à 6. 
            // Ao iniciar o jogo, o criador do código deve inserir uma sequência de números, como descrito acima (e.g. 435612).
            // Após isso, o decifrador tem 8 chances para tentar decifrar o código criado.
            // A cada tentativa feita pelo decifrador, fica mais fácil descobrir a sequência de números.
            // Suponha que a sequência seja 334211. 
            // O decifrador testará a sequência 316652. A sequência está errada, porém o número 3, por estar na posição correta da 
            // sequência, terá uma indicação de correto (e.g. coloração verde). Já os números 1 e 2 terão também uma indicação que
            // estão presentes na sequência a ser descoberta, porém em posições diferentes da tentativa (e.g. coloração vermelha). 
            // Na opção de um jogador, o computador sempre será o criador do código. Assim, o código gerado será uma sequência 
            // aleatória de números gerada. Se quiser colocar a opção de ser o decifrador, serão pontos extras ;)
            // O jogo acaba quando o decifrador desvenda o código ou quando 8 turnos se passarem.
            // A interface do jogo pode ser feita no próprio terminal, por linha de comando.

            // Variáveis

            int MenuGeral;
            int DificuldadeDoGame;
            int TentarNovamente;
            int[] valores = new int[6];
            int[] valoresadivinhar = new int[6];

            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("Bem-vindo ao Game Codebreaker");

                    Console.WriteLine("\nMENU"); //Título

                    Console.WriteLine("\n1 - Ser o criador do código"); // Opção 01 - Selecionar para ser o criador do código
                    Console.WriteLine("\n2 - Ser o decifrador do código"); // Opção 02 - Selecionar para ser o decifrador do código
                    Console.WriteLine("\n3 - Sair"); // Opção 03 - Sair do Game

                    Console.Write("\n\nEscolha uma das opções: "); 
                    MenuGeral = int.Parse(Console.ReadLine());

                    if (MenuGeral < 1 || MenuGeral > 4) // Caso o usuário insira um valor inválido
                    {
                        Console.WriteLine("\nVocê digitou uma opção inválida!");
                        Console.WriteLine("\nPressione [ENTER] para tentar novamente.");
                        Console.ReadLine();
                    }

                } while (MenuGeral < 1 || MenuGeral > 4);

                switch (MenuGeral)
                {
                    case 1:

                        // OPÇÃO 01 - Ser o criador do código

                        Console.Clear();

                        Console.WriteLine("Você escolheu: Ser o criador do código");

                        Console.Write("\nDigite uma sequência de 6 números: ");

                        Console.WriteLine("\n");

                        Console.WriteLine("\nObs: Só é permitido números de 1 à 6 ;)");

                        // Inserção dos valores para serem adivinhados

                        do
                        {
                            Console.WriteLine("\n");

                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write(String.Format(i + 1 + "ª Posição: ")); // Campo para o usuário inserir as 6 posições
                                valores[i] = int.Parse(Console.ReadLine());

                                if (valores[i] < 1 || valores[i] > 6) // Campo para caso o usuário insira um valor inválido
                                {
                                    Console.WriteLine("\nÉ permitido somente números de 1 à 6! :D");

                                    Console.WriteLine("\n");

                                    Console.Write(String.Format(i + 1 + "ª Posição: "));
                                    valores[i] = int.Parse(Console.ReadLine());
                                }
                            }
                        } while (valores[0] < 1 || valores[0] > 6);

                        Console.Clear();

                        // Adivinhar o código da pessoa

                        do
                        {
                            Console.WriteLine("\nTente adivinhar o código do seu colega :)");

                            Console.WriteLine("\n");

                            for (int i = 0; i < 6; i++)
                            {
                                Console.Write(String.Format((i + 1) + "ª Posição: ")); // Campo para o usuário inserir as 6 posições
                                valoresadivinhar[i] = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("\nVocê digitou: " + valoresadivinhar[0] + "," + valoresadivinhar[1] + "," + valoresadivinhar[2] + "," + valoresadivinhar[3] + "," + valoresadivinhar[4] + "," + valoresadivinhar[5]);

                            Console.ForegroundColor = ConsoleColor.Green;

                            // Acertos do usuário

                            if (valoresadivinhar[0] == valores[0])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 1ª posição: (" + valoresadivinhar[0] + ")");
                            }

                            if (valoresadivinhar[1] == valores[1])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 2ª posição: (" + valoresadivinhar[1] + ")");
                            }

                            if (valoresadivinhar[2] == valores[2])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 3ª posição: (" + valoresadivinhar[2] + ")");
                            }

                            if (valoresadivinhar[3] == valores[3])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 4ª posição: (" + valoresadivinhar[3] + ")");
                            }

                            if (valoresadivinhar[4] == valores[4])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 5ª posição: (" + valoresadivinhar[4] + ")");
                            }

                            if (valoresadivinhar[5] == valores[5])
                            {
                                Console.WriteLine("\nVocê adivinhou o valor da 6ª posição: (" + valoresadivinhar[5] + ")");
                            }

                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("_______________________________");

                            // Dica ao usuário para que o mesmo possa descobrir a sequência correta

                            //Valores da primeira linha

                            Console.ForegroundColor = ConsoleColor.Red;

                            if (valoresadivinhar[1] == valores[0])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[2] == valores[0])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[3] == valores[0])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[4] == valores[0])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[5] == valores[0])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                            }

                            //Valores da segunda linha

                            if (valoresadivinhar[0] == valores[1])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[2] == valores[1])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[3] == valores[1])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[4] == valores[1])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[5] == valores[1])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                            }

                            //Valores da terceira linha

                            if (valoresadivinhar[0] == valores[2])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[1] == valores[2])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[3] == valores[2])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[4] == valores[2])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[5] == valores[2])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                            }

                            //Valores da quarta linha

                            if (valoresadivinhar[0] == valores[3])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[1] == valores[3])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[2] == valores[3])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[4] == valores[3])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[5] == valores[3])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                            }

                            //Valores da quinta linha

                            if (valoresadivinhar[0] == valores[4])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[1] == valores[4])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[2] == valores[4])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[3] == valores[4])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[5] == valores[4])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                            }

                            //Valores da sexta linha

                            if (valoresadivinhar[0] == valores[5])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[1] == valores[5])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[2] == valores[5])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[3] == valores[5])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                            }

                            if (valoresadivinhar[4] == valores[5])
                            {
                                Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                            }

                            // Jogo ganho pelo usuário

                            if (valoresadivinhar[0] == valores[0] && valoresadivinhar[1] == valores[1] && valoresadivinhar[2] == valores[2] && valoresadivinhar[3] == valores[3] && valoresadivinhar[4] == valores[4] && valoresadivinhar[5] == valores[5])
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.WriteLine("\nPARABÉNS!!!");
                                Console.WriteLine("\nVocê adivinhou todas as posições!!!");
                            }

                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\nVocê deseja tentar novamente? Digite [1] para voltar ou [0] para sair para o Menu Geral"); // Opção para voltar ao menu
                            TentarNovamente = int.Parse(Console.ReadLine());

                        } while (TentarNovamente == 1);

                        break;

                    case 2:

                        // Não soube gerar valores aleatórios. Devido a isso, irei definir alguns números para serem adivinhados pelo usuário, classificando-os em níveis de dificuldade.

                        // OPÇÃO 02 - Ser o decifrador do código

                        Console.Clear();

                        Console.WriteLine("Você escolheu: Ser o decifrador do código");

                        Console.WriteLine("\nEscolha o nível de dificuldade: ");

                        do
                        {
                            // Níveis de dificuldade do Game

                            Console.WriteLine("\n1 - Fácil");
                            Console.WriteLine("\n2 - Médio");
                            Console.WriteLine("\n3 - Difícil");

                            Console.Write("\n\nEscolha uma das opções: "); // Opções para que o usuário escolha o nível de dificuldade do Game
                            DificuldadeDoGame = int.Parse(Console.ReadLine());

                            if (DificuldadeDoGame < 1 || DificuldadeDoGame > 3) // Campo para caso o usuário insira um valor inválido
                            {
                                Console.WriteLine("\nVocê digitou uma opção inválida!");
                                Console.WriteLine("\nPressione [ENTER] para tentar novamente.");
                                Console.ReadLine();
                            }

                        } while (DificuldadeDoGame < 1 || DificuldadeDoGame > 3);

                        Console.Clear();

                        Console.WriteLine("\nGerando código...");

                        switch (DificuldadeDoGame)
                        {
                            case 1: // Dificuldade: Fácil

                                int[] facil = new int[6];
                                facil[0] = 1;
                                facil[1] = 2;
                                facil[2] = 5;
                                facil[3] = 4;
                                facil[4] = 3;
                                facil[5] = 6;

                                do
                                {
                                    Console.Write("\nOK! Tente adivinhar o código que a máquina gerou :D");

                                    Console.WriteLine("\n");

                                    for (int i = 0; i < 6; i++)
                                    {
                                        Console.Write(String.Format((i + 1) + "ª Posição: ")); // Campo para o usuário inserir os valores
                                        valoresadivinhar[i] = int.Parse(Console.ReadLine());
                                    }

                                    Console.WriteLine("\nVocê digitou: " + valoresadivinhar[0] + "," + valoresadivinhar[1] + "," + valoresadivinhar[2] + "," + valoresadivinhar[3] + "," + valoresadivinhar[4] + "," + valoresadivinhar[5]);

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    // Acertos do usuário

                                    if (valoresadivinhar[0] == facil[0])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 1ª posição: (" + valoresadivinhar[0] + ")");
                                    }

                                    if (valoresadivinhar[1] == facil[1])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 2ª posição: (" + valoresadivinhar[1] + ")");
                                    }

                                    if (valoresadivinhar[2] == facil[2])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 3ª posição: (" + valoresadivinhar[2] + ")");
                                    }

                                    if (valoresadivinhar[3] == facil[3])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 4ª posição: (" + valoresadivinhar[3] + ")");
                                    }

                                    if (valoresadivinhar[4] == facil[4])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 5ª posição: (" + valoresadivinhar[4] + ")");
                                    }

                                    if (valoresadivinhar[5] == facil[5])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 6ª posição: (" + valoresadivinhar[5] + ")");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("_______________________________");

                                    //Valores da primeira linha

                                    Console.ForegroundColor = ConsoleColor.Red;

                                    if (valoresadivinhar[1] == facil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == facil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == facil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == facil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == facil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da segunda linha

                                    if (valoresadivinhar[0] == facil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == facil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == facil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == facil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == facil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da terceira linha

                                    if (valoresadivinhar[0] == facil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == facil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == facil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == facil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == facil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quarta linha

                                    if (valoresadivinhar[0] == facil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == facil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == facil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == facil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == facil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quinta linha

                                    if (valoresadivinhar[0] == facil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == facil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == facil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == facil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == facil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da sexta linha

                                    if (valoresadivinhar[0] == facil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == facil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == facil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == facil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == facil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    // Jogo ganho pelo usuário

                                    if (valoresadivinhar[0] == facil[0] && valoresadivinhar[1] == facil[1] && valoresadivinhar[2] == facil[2] && valoresadivinhar[3] == facil[3] && valoresadivinhar[4] == facil[4] && valoresadivinhar[5] == facil[5])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                        Console.WriteLine("\nPARABÉNS!!!");
                                        Console.WriteLine("\nVocê adivinhou todas as posições!!!");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("\nVocê deseja tentar novamente? Digite [1] para voltar ou [0] para sair para o Menu Geral"); // Opção para voltar ao menu
                                    TentarNovamente = int.Parse(Console.ReadLine());

                                } while (TentarNovamente == 1);

                                break;

                            case 2: // Dificuldade: Médio

                                int[] medio = new int[6];
                                medio[0] = 1;
                                medio[1] = 3;
                                medio[2] = 2;
                                medio[3] = 6;
                                medio[4] = 5;
                                medio[5] = 4;

                                do
                                {
                                    Console.Write("\nOK! Tente adivinhar o código que a máquina gerou :D");

                                    Console.WriteLine("\n");

                                    for (int i = 0; i < 6; i++)
                                    {
                                        Console.Write(String.Format((i + 1) + "ª Posição: ")); // Campo para o usuário inserir os valores
                                        valoresadivinhar[i] = int.Parse(Console.ReadLine());
                                    }

                                    Console.WriteLine("\nVocê digitou: " + valoresadivinhar[0] + "," + valoresadivinhar[1] + "," + valoresadivinhar[2] + "," + valoresadivinhar[3] + "," + valoresadivinhar[4] + "," + valoresadivinhar[5]);

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    // Acertos do usuário

                                    if (valoresadivinhar[0] == medio[0])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 1ª posição: (" + valoresadivinhar[0] + ")");
                                    }

                                    if (valoresadivinhar[1] == medio[1])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 2ª posição: (" + valoresadivinhar[1] + ")");
                                    }

                                    if (valoresadivinhar[2] == medio[2])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 3ª posição: (" + valoresadivinhar[2] + ")");
                                    }

                                    if (valoresadivinhar[3] == medio[3])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 4ª posição: (" + valoresadivinhar[3] + ")");
                                    }

                                    if (valoresadivinhar[4] == medio[4])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 5ª posição: (" + valoresadivinhar[4] + ")");
                                    }

                                    if (valoresadivinhar[5] == medio[5])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 6ª posição: (" + valoresadivinhar[5] + ")");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("_______________________________");

                                    //Valores da primeira linha

                                    Console.ForegroundColor = ConsoleColor.Red;

                                    if (valoresadivinhar[1] == medio[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == medio[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == medio[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == medio[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == medio[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da segunda linha

                                    if (valoresadivinhar[0] == medio[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == medio[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == medio[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == medio[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == medio[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da terceira linha

                                    if (valoresadivinhar[0] == medio[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == medio[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == medio[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == medio[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == medio[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quarta linha

                                    if (valoresadivinhar[0] == medio[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == medio[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == medio[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == medio[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == medio[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quinta linha

                                    if (valoresadivinhar[0] == medio[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == medio[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == medio[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == medio[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == medio[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da sexta linha

                                    if (valoresadivinhar[0] == medio[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == medio[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == medio[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == medio[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == medio[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    // Jogo ganho pelo usuário

                                    if (valoresadivinhar[0] == medio[0] && valoresadivinhar[1] == medio[1] && valoresadivinhar[2] == medio[2] && valoresadivinhar[3] == medio[3] && valoresadivinhar[4] == medio[4] && valoresadivinhar[5] == medio[5])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                        Console.WriteLine("\nPARABÉNS!!!");
                                        Console.WriteLine("\nVocê adivinhou todas as posições!!!");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("\nVocê deseja tentar novamente? Digite [1] para voltar ou [0] para sair para o Menu Geral"); // Campo para voltar ao menu
                                    TentarNovamente = int.Parse(Console.ReadLine());

                                } while (TentarNovamente == 1);

                                break;

                            case 3:

                                int[] dificil = new int[6];
                                dificil[0] = 4;
                                dificil[1] = 6;
                                dificil[2] = 5;
                                dificil[3] = 1;
                                dificil[4] = 3;
                                dificil[5] = 2;

                                do
                                {
                                    Console.Write("\nOK! Tente adivinhar o código que a máquina gerou :D");

                                    Console.WriteLine("\n");

                                    for (int i = 0; i < 6; i++)
                                    {
                                        Console.Write(String.Format((i + 1) + "ª Posição: ")); // Campo para o usuário inserir os valores
                                        valoresadivinhar[i] = int.Parse(Console.ReadLine());
                                    }

                                    Console.WriteLine("\nVocê digitou: " + valoresadivinhar[0] + "," + valoresadivinhar[1] + "," + valoresadivinhar[2] + "," + valoresadivinhar[3] + "," + valoresadivinhar[4] + "," + valoresadivinhar[5]);

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    // Acertos do usuário

                                    if (valoresadivinhar[0] == dificil[0])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 1ª posição: (" + valoresadivinhar[0] + ")");
                                    }

                                    if (valoresadivinhar[1] == dificil[1])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 2ª posição: (" + valoresadivinhar[1] + ")");
                                    }

                                    if (valoresadivinhar[2] == dificil[2])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 3ª posição: (" + valoresadivinhar[2] + ")");
                                    }

                                    if (valoresadivinhar[3] == dificil[3])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 4ª posição: (" + valoresadivinhar[3] + ")");
                                    }

                                    if (valoresadivinhar[4] == dificil[4])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 5ª posição: (" + valoresadivinhar[4] + ")");
                                    }

                                    if (valoresadivinhar[5] == dificil[5])
                                    {
                                        Console.WriteLine("\nVocê adivinhou o valor da 6ª posição: (" + valoresadivinhar[5] + ")");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("_______________________________");

                                    //Valores da primeira linha

                                    Console.ForegroundColor = ConsoleColor.Red;

                                    if (valoresadivinhar[1] == dificil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == dificil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == dificil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == dificil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == dificil[0])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da segunda linha

                                    if (valoresadivinhar[0] == dificil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == dificil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == dificil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == dificil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == dificil[1])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da terceira linha

                                    if (valoresadivinhar[0] == dificil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == dificil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == dificil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == dificil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == dificil[2])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quarta linha

                                    if (valoresadivinhar[0] == dificil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == dificil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == dificil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == dificil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == dificil[3])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da quinta linha

                                    if (valoresadivinhar[0] == dificil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == dificil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == dificil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == dificil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[5] == dificil[4])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[5] + ") está na posição errada!");
                                    }

                                    //Valores da sexta linha

                                    if (valoresadivinhar[0] == dificil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[0] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[1] == dificil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[1] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[2] == dificil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[2] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[3] == dificil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[3] + ") está na posição errada!");
                                    }

                                    if (valoresadivinhar[4] == dificil[5])
                                    {
                                        Console.WriteLine("\nO número (" + valoresadivinhar[4] + ") está na posição errada!");
                                    }

                                    // Jogo ganho pelo usuário

                                    if (valoresadivinhar[0] == dificil[0] && valoresadivinhar[1] == dificil[1] && valoresadivinhar[2] == dificil[2] && valoresadivinhar[3] == dificil[3] && valoresadivinhar[4] == dificil[4] && valoresadivinhar[5] == dificil[5])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;

                                        Console.WriteLine("\nPARABÉNS!!!");
                                        Console.WriteLine("\nVocê adivinhou todas as posições!!!");
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("\nVocê deseja tentar novamente? Digite [1] para voltar ou [0] para sair para o Menu Geral"); // Opção para o usuário voltar ao menu
                                    TentarNovamente = int.Parse(Console.ReadLine());

                                } while (TentarNovamente == 1);

                                break;
                        }
                        break;
                }
                Console.WriteLine("\nVocê deseja voltar ao Menu Geral? Digite [1] para voltar ou [0] para sair do Game"); // Opção para o usuário sair do Game
                MenuGeral = int.Parse(Console.ReadLine());

            } while (MenuGeral == 1);    
        }
    }
}
