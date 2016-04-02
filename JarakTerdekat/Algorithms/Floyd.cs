using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    public class Floyd
    {

        public List<List<double>> P;
        public List<List<double>> M;
        public int N;


        public void init(List<List<double>> inputTable, double N)
        {
            this.N = (int)N;
            P = new List<List<double>>();
            M = inputTable;

            for (int i = 0; i < N; i++)
            {
                P.Add(new List<double>());

                for (int j = 0; j < N; j++)
                {
                    P[i].Add(0);
                }
            }
        }

        public void calculateShortestPath(int startIndex, int endIndex)
        {
            Console.WriteLine("Matrix to find the shortest path of.");
            printMatrix(M);
            Console.WriteLine("Shortest Path Matrix.");
            printMatrix(FloydAlgo(M));
            Console.WriteLine("Path Matrix");
            printMatrix(P);
        }

        public List<List<double>> FloydAlgo(List<List<double>> M)
        {
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        // to keep track.;
                        if (M[i][k] + M[k][j] < M[i][j])
                        {
                            M[i][j] = M[i][k] + M[k][j];
                            P[i][j] = k;
                        }
                        // or not to keep track.
                        //M[i][j] = min(M[i][j], M[i][k] + M[k][j]);
                    }
                }
            }
            return M;
        }

        public int min(int i, int j)
        {
            if (i > j)
            {
                return j;
            }
            return i;
        }

        public void printMatrix(List<List<double>> Matrix)
        {
            Console.Write("\n\t");
            for (int j = 0; j < N; j++)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine();
            for (int j = 0; j < 35; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write(i + " |\t");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Matrix[i][j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }

    }
}
