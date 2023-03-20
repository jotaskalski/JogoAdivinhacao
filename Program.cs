namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            do
            {

                string firula = new string('-', 43);
                int numeroAleatorio = aleatorio.Next(1, 20);

                int nivelDificuldade = 0, tentativas = 0, numeroChute = 0;
                int pontuacao = 0;
                int pontuacaoFinal = 1000;

                Console.WriteLine("\nEscolha o nível de dificuldade");
                Console.WriteLine("\n(1) Fácil (2) Médio (3) Difícil");
                Console.Write("\nEscolha: ");

                nivelDificuldade = Convert.ToInt32(Console.ReadLine());

                switch (nivelDificuldade)
                {
                    case 1:
                        tentativas = 15;

                        for (int i = 0; i < tentativas; i++)
                        {

                            Console.WriteLine($"\nTentativa {i + 1} de {tentativas}\n");
                            Console.WriteLine(firula);


                            Console.Write($"\nQual o seu {i + 1}º chute? ");
                            numeroChute = Convert.ToInt32(Console.ReadLine());

                            if (numeroChute < numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;

                                Console.WriteLine("Seu chute foi menor que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute > numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;
                                Console.WriteLine("Seu chute foi maior que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute == numeroAleatorio)
                            {
                                Console.WriteLine("Parabéns, você acertou!");
                                Console.WriteLine($"\nPontuação final é de {pontuacaoFinal}!");
                                break;
                            }
                            if (i + 1 >= tentativas)
                            {
                                Console.WriteLine("Acabaram suas tentativas!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        break;

                    case 2:
                        tentativas = 10;

                        for (int i = 0; i < tentativas; i++)
                        {

                            Console.WriteLine($"\nTentativa {i + 1} de {tentativas}\n");
                            Console.WriteLine(firula);


                            Console.Write($"\nQual o seu {i + 1}º chute? ");
                            numeroChute = Convert.ToInt32(Console.ReadLine());

                            if (numeroChute < numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;

                                Console.WriteLine("Seu chute foi menor que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute > numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;
                                Console.WriteLine("Seu chute foi maior que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute == numeroAleatorio)
                            {
                                Console.WriteLine("Parabéns, você acertou!");
                                Console.WriteLine($"\nPontuação final é de {pontuacaoFinal}!");
                                break;
                            }
                            if (i + 1 >= tentativas)
                            {
                                Console.WriteLine("\nAcabaram suas tentativas!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        break;

                    case 3:
                        tentativas = 5;

                        for (int i = 0; i < tentativas; i++)
                        {

                            Console.WriteLine($"\nTentativa {i + 1} de {tentativas}\n");
                            Console.WriteLine(firula);

                            Console.Write($"\nQual o seu {i + 1}º chute? ");
                            numeroChute = Convert.ToInt32(Console.ReadLine());

                            if (numeroChute < numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;

                                Console.WriteLine("Seu chute foi menor que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute > numeroAleatorio)
                            {
                                pontuacao = Math.Abs((numeroChute - numeroAleatorio) / 2);
                                pontuacaoFinal = pontuacaoFinal - pontuacao;
                                Console.WriteLine("Seu chute foi maior que o número secreto!");
                                Console.WriteLine($"Você fez {pontuacaoFinal} pontos!");
                            }

                            if (numeroChute == numeroAleatorio)
                            {
                                Console.WriteLine("Parabéns, você acertou!");
                                Console.WriteLine($"\nPontuação final é de {pontuacaoFinal}!");
                                break;
                            }
                            if (i + 1 >= tentativas)
                            {
                                Console.WriteLine("\nAcabaram suas tentativas!");
                                Console.ReadLine();
                                break;
                            }
                        }
                        break;
                }
                Console.ReadLine();

            } while (true);

        }
    }
}