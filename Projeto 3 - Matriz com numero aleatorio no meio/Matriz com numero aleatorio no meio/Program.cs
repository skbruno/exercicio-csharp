using System;

namespace Matriz_com_numero_aleatorio_no_meio
{
    class Program
    {
        static void Main(string[] args)
        {
			int n, cont = 0;

			Console.WriteLine("Informe o tamanho da matriz");
			n = int.Parse(Console.ReadLine());

			int[,] matriz = new int[n, n];

			Random rand = new Random();

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matriz[i, j] = rand.Next(10, 100);
				}
			}



			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (j != i)
					{
						matriz[i, j] = 0;
					}
					else
						cont += matriz[i, j];
				}
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0}\t", matriz[i, j]);
				}
				Console.Write("\n");
			}
			Console.WriteLine("A soma da {0}", cont);
		}
    }
}
