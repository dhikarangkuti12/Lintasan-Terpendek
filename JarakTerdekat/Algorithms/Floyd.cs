﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JarakTerdekat.Classes;

namespace JarakTerdekat
{
    public class Floyd
    {

        public List<List<double>> P;
        public List<List<double>> M;

        public double totalJarak;

        public int startIndex;
        public int endIndex;

        public List<int> result;
        public int N;

        Stopwatch watch = new Stopwatch();
        public double elapsedTimeMs = 0;


        public void init(List<List<double>> inputTable, double N)
        {
            this.N = (int)N;
            P = new List<List<double>>();
            result = new List<int>();
            M = inputTable;

            for (int i = 0; i < N; i++)
            {
                P.Add(new List<double>());

                for (int j = 0; j < N; j++)
                {
                    P[i].Add(-1);
                }
            }
        }

        public List<int> calculateShortestPath(int startIndex, int endIndex)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;

            watch.start();

            result.Add(startIndex);
            FloydAlgo(M);

            getPath(startIndex, endIndex);

            if (totalJarak != double.PositiveInfinity)
                result.Add(endIndex);

            elapsedTimeMs = watch.stop();
            return result;
        }

        public void getPath(int u, int v)
        {
            double k;

            k = P[u][v];

            if (k == -1)
            {
                return;
            }
            getPath(u, (int)k);

            result.Add((int)k);

            getPath((int)k, v);
        }

        public List<List<double>> FloydAlgo(List<List<double>> M)
        {
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (M[i][k] + M[k][j] < M[i][j])
                        {
                            M[i][j] = M[i][k] + M[k][j];
                            P[i][j] = k;
                        }
                    }
                }
            }
            totalJarak = M[startIndex][endIndex];
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
    }
}
