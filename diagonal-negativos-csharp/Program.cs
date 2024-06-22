using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal_negativos_csharp {
    internal class Program {
        static void Main(string[] args) {

            int N, cont;
            Console.Write("Qual a ordem da Matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine();
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            cont = 0;
            for (int i = 0; i < N; i++) {
                for(int j = 0; j < N; j++) { 
                    if (mat[i, j] < 0) {
                        cont++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " +cont);
        }
    }
}

