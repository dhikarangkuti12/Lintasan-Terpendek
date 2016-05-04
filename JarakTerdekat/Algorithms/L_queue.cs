using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JarakTerdekat.Classes;


namespace JarakTerdekat
{
   
    // graph berarah/ tidak berarah
    public class L_queue
    {
        public List<edge> Edge = new List<edge>();
        public int V;   // jumlah verteks
        public List<double> shortestDistance;

        public int tempVertex;

        bool isFirstIteration = true;

        public double totalJarak;

        public List<int> predecessorVertex;
        public List<int> path;


        Stopwatch watch = new Stopwatch();
        public double elapsedTimeMs = 0;

        public L_queue()
        {
            predecessorVertex = new List<int>();
            shortestDistance = new List<double>();
            path = new List<int>();
        }

        public class edge
        {
            public int from, to;
            public double cost;
            public edge(int _from, int _to, double _cost)
            {
                from = _from;
                to = _to;
                cost = _cost;
            }
        }

        private double GetTotalPositiveCost()
        {
            double sum = 0;
            foreach (var e in Edge)
            {
                if (e.cost > 0) sum += e.cost;
            }
            return sum;
        }

        private void generateV()
        {
            foreach (var e in Edge)
            {
                V = Math.Max(V, e.from);
                V = Math.Max(V, e.to);
            }
            V++;
        }



        /// <summary>
        /// representasi jarak terpendek dari start index
        /// </summary>
        public List<double> GetShortestPath(int startIndex, int toIndex)
        {
            if (V == 0 && Edge.Count > 0) generateV();

            shortestDistance.Clear();
            predecessorVertex.Clear();

            double INF = double.PositiveInfinity;

            for (int i = 0; i < V; i++)
            {
                shortestDistance.Add(INF);
                predecessorVertex.Add(-1);
            }

            shortestDistance[startIndex] = 0;
            while (true)
            {
                bool update = false;
                foreach (edge e in Edge)
                {
                    if (shortestDistance[e.from] != INF && shortestDistance[e.to] > shortestDistance[e.from] + e.cost)
                    {
                        shortestDistance[e.to] = shortestDistance[e.from] + e.cost;
                        predecessorVertex[e.to] = e.from;

                        update = true;

                        // masukkan e.from ke tempVertex untuk disimpan ke path terdekat
                        // jika e.to merupakan toIndex
                        if(e.to == toIndex)
                        {
                            tempVertex = e.from;
                        }
                    }
                }
                if (!update) break;
            }

            if (isFirstIteration)
            {
                totalJarak = shortestDistance[toIndex];
                isFirstIteration = false;
            }

            return shortestDistance;
        }



        public void getShortestPathList(int startIndex, int toIndex)
        {
            watch.start();
            path.Add(toIndex);


            if (startIndex != toIndex)
            {
                GetShortestPath(startIndex, toIndex);
            }

            getPath(startIndex, toIndex);

            printPath();


            elapsedTimeMs = watch.stop();
        }

        public void getPath(int u, int v)
        {
            double k;

            k = predecessorVertex[v];

            if (k == -1 || u==v)
            {
                return;
            }

            path.Add((int)k);
            getPath(u, (int)k);

        }

        public void printPath()
        {
            Console.WriteLine("JUMLAH VERTEKS DI DALAM PATH = " + predecessorVertex.Count());

            int i = 0;
            foreach (int a in predecessorVertex)
            {
                Console.WriteLine("Predecessor Verteks <start>"+" -> " + i + " = " + a);
                i++;
            }
        }
    }
}
