using System;

namespace Matriz_triangular_inferior
{
    class Program
    {
		public static void Main(string[] args)
		{

			int n, valores = 1;

			Console.WriteLine("Qual o tamanho da matriz:");
			n = int.Parse(Console.ReadLine());

			int[,] matrizinferior = new int[n, n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (j > i)
					{
						matrizinferior[i, j] = 0;
					}
					else
					{
						matrizinferior[i, j] = valores++;
					}
					Console.Write("{0}\t", matrizinferior[i, j]);
				}
				Console.Write("\n");
			}
		}

	}
}
