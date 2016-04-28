using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
   
    // graph berarah/ tidak berarah
    public class L_queue
    {
        public List<edge> Edge = new List<edge>();
        public int V;   // jumlah verteks
        public double[] shortestPath;

        public int tempVertex;

        bool isFirstIteration = true;

        public double totalJarak;

        public List<int> shortestPathList;

        private bool isNewSession = true;

        public L_queue()
        {
            shortestPathList = new List<int>();
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
        public double[] GetShortestPath(int startIndex, int toIndex)
        {
            if (V == 0 && Edge.Count > 0) generateV();

            shortestPath = new double[V];

            double INF = double.PositiveInfinity;

            for (int i = 0; i < V; i++)
                shortestPath[i] = INF;

            shortestPath[startIndex] = 0;
            while (true)
            {
                bool update = false;
                foreach (edge e in Edge)
                {
                    if (shortestPath[e.from] != INF && shortestPath[e.to] > shortestPath[e.from] + e.cost)
                    {
                        shortestPath[e.to] = shortestPath[e.from] + e.cost;

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
                totalJarak = shortestPath[toIndex];
                isFirstIteration = false;
            }

            return shortestPath;
        }



        public void getShortestPathList(int startIndex, int toIndex)
        {
            if (isNewSession)
            {
                shortestPathList.Add(toIndex);
                isNewSession = false;
            }

            GetShortestPath(startIndex, toIndex);

            if (startIndex == toIndex)
            {
                isNewSession = true;
                return;
            }

            shortestPathList.Add(tempVertex);

            getShortestPathList(startIndex, tempVertex);
        }


    }
}
