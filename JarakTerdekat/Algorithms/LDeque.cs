/** 
 * @title A Simulation of LQueue Algorithm (The graph growth algorithm implemented with a queue)
 * @author Mohammad Andri Budiman <mandrib@gmail.com> and Dhika Handayani Rangkuti <dhikahandayani12@gmail.com>
 * @reference Gallo, Giorgio, and Stefano Pallottino. "Shortest path algorithms." Annals of Operations Research 13.1 (1988): 1-79.
 * @version 0.71
 * @since 2016-05-10
 */

using System;
using JarakTerdekat.Classes;
using System.Collections.Generic;
using System.Linq;

namespace JarakTerdekat
{
    public class LDeque
    {
        public List<List<edge_>> graph;
        List<double> shortestDistances = new List<double>();
        List<double> predecessorVertex = new List<double>();
        public double totalJarak;
        public List<int> path;
        Stopwatch watch = new Stopwatch();
        public double elapsedTimeMs = 0;

        public LDeque(List<List<edge_>> graph)
        {
            this.graph = graph;
            path = new List<int>();
        }


        public void Ldeque(int startIndex, int toIndex)
        {
            watch.start();
            path.Add(toIndex);

            double INF = double.PositiveInfinity;
            Deque<int> deque = new Deque<int>();

            foreach (var pair in graph)
            {
                shortestDistances.Add(INF);
                predecessorVertex.Add(-1);
            }

            shortestDistances[startIndex] = 0;
            deque.AddToBack(startIndex);

            while (deque.Count != 0)
            {
                int u = deque.RemoveFromFront();
                foreach (var pair in graph[u])
                {
                    int v = pair.toIndex;
                    if (shortestDistances[v] > shortestDistances[u] + pair.cost)
                    {
                        if (!deque.Contains(v))
                        {
                            if(shortestDistances[v] == double.PositiveInfinity)
                            {
                                deque.AddToBack(v);
                            }
                            else
                            {
                                deque.AddToFront(v);
                            }
                        }
                        shortestDistances[v] = shortestDistances[u] + pair.cost;
                        predecessorVertex[v] = u;
                    }
                }
            }

            getPath(startIndex, toIndex);
            totalJarak = shortestDistances[toIndex];
            elapsedTimeMs = watch.stop();
        }

        public void getPath(int u, int v)
        {
            double k;

            k = predecessorVertex[v];

            if (k == -1 || u == v)
            {
                return;
            }

            path.Add((int)k);
            getPath(u, (int)k);

        }
    }
}