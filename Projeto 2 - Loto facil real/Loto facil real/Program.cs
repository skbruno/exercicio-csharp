using System;

namespace Loto_facil_real
{
    class Program
    {
        static void Main(string[] args)
        {
			int[,] matrizA = new int[13, 3];
			int[,] matrizB = new int[13, 3];
			int n = 1, cont = 0, opcao;

			Random ale = new Random();

			Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("Loteria de Aposta Esportiva, Digite o resultado dos jogos, Sendo que 1 é a vitoria do time A, 2 Empate e ambos os times, 3 vitoria do time B, 4 vitoria ou empate do time A e 5 Vitoria ou empate do time B");
			Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

			//Perguntando ao usuario
			for (int i = 0; i < 13; i++)
			{
				Console.WriteLine("Digite o resultado para o jogo " + n);
				opcao = int.Parse(Console.ReadLine());
				n += 1;


				switch (opcao)
				{
					case 1:
						matrizA[i, 0] = 1;
						break;

					case 2:
						matrizA[i, 1] = 1;
						break;

					case 3:
						matrizA[i, 2] = 1;
						break;

					case 4:
						matrizA[i, 0] = 1;
						matrizA[i, 1] = 1;
						break;

					case 5:
						matrizA[i, 1] = 1;
						matrizA[i, 2] = 1;
						break;

					default:
						Console.WriteLine("Valor digitado invalido");
						i--;
						n -= 1;
						break;
				}
			}

			// Mostrando os Resultado da aposta do usuario
			n = 1;
			Console.WriteLine("As aposta que foram feita foi:");
			for (int i = 0; i < 13; i++)
			{
				for (int j = 0; j < 1; j++)
				{
					Console.Write("Jogo " + n + " - "); Console.Write("{0}\t ", matrizA[i, 0] + "   " + matrizA[i, 1] + "   " + matrizA[i, 2]);
					n += 1;
				}
				Console.Write("\n");
			}

			// Fazendo os numero aleatorios e ordenando / resultado oficial
			for (int i = 0; i < 13; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					matrizB[i, j] = ale.Next(0, 2);

					if (matrizB[i, 0] == 1)
					{
						matrizB[i, 1] = 0;
						matrizB[i, 2] = 0;

					}
					else if (matrizB[i, 1] == 1)
					{
						matrizB[i, 2] = 0;

					}
					else
					{
						matrizB[i, 2] = 1;
					}
				}
			}

			//Mostrando os Resultado dos numeros aleatorio/ resultado oficial
			n = 1;
			Console.WriteLine("Os resultados das apostas que foram feita foi:");
			for (int i = 0; i < 13; i++)
			{
				for (int j = 0; j < 1; j++)
				{
					Console.Write("Jogo " + n + " - "); Console.Write("{0}\t ", matrizB[i, 0] + "   " + matrizB[i, 1] + "   " + matrizB[i, 2]);
					n += 1;
				}
				Console.Write("\n");
			}

			//Comparando
			for (int i = 0; i < 13; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (matrizA[i, j] == matrizB[i, j] && matrizB[i, j] == 1)
					{
						cont += 1;
					}

				}
			}



			//Resultado
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Você acertou " + cont + " Jogos.");
			Console.WriteLine("-----------------------------------");
		}
    }
}
