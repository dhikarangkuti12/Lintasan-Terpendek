using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    partial class MainWindow
    {
        private List<int> getPathWithLdeque()
        {
            Console.WriteLine("Algorithm: L-Queue");

            var graph = new List<List<edge_>>();

            var fromIndex = -1;
            var toIndex = -1;
            var cost = 0.0;

            for (int i = 0; i < nodeCollection.Nodes.Count; i++)
            {
                fromIndex = i;
                graph.Add(new List<edge_>());

                if (nodeCollection.Nodes[i].neighborsCollection.Nodes.Count > 0)
                {
                    foreach (var neighbor in nodeCollection.Nodes[i].neighborsCollection.Nodes)
                    {
                        toIndex = nodeCollection.getIndexByName(neighbor.node.name);
                        cost = neighbor.jarak;
                        graph[i].Add(new edge_(fromIndex, toIndex, cost));
                    }
                }
            }

            LDeque lqueue = new LDeque(graph);

            lqueue.Ldeque(nodeCollection.getIndexByName(cb_initialNode.Text), nodeCollection.getIndexByName(cb_endNode.Text));


            totalJarak = lqueue.totalJarak;
            elapsedTimeMs = lqueue.elapsedTimeMs;

            return lqueue.path;
        }
    }
    public class edge_
    {
        public int fromIndex;
        public int toIndex;
        public double cost;
        public edge_(int fromIndex, int toIndex, double cost)
        {
            this.fromIndex = fromIndex;
            this.toIndex = toIndex;
            this.cost = cost;
        }

    }
}
