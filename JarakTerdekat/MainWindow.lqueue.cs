using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    partial class MainWindow
    {
        private List<int> getPathWithLqueue()
        {
            Console.WriteLine("Algorithm: L-Queue");

            var graph = new Dictionary<int, Dictionary<int, double>>();

            var fromIndex = -1;
            var toIndex = -1;
            var cost = 0.0;

            for (int i = 0; i < nodeCollection.Nodes.Count; i++)
            {
                fromIndex = i;

                if (nodeCollection.Nodes[i].neighborsCollection.Nodes.Count > 0)
                {
                    graph.Add(i, new Dictionary<int, double>());
                    foreach (var neighbor in nodeCollection.Nodes[i].neighborsCollection.Nodes)
                    {
                        toIndex = nodeCollection.getIndexByName(neighbor.node.name);
                        cost = neighbor.jarak;
                        graph[i].Add(toIndex, cost);
                    }
                }
            }

            LQueueBaru lqueue = new LQueueBaru(graph);

            lqueue.LQueue(nodeCollection.getIndexByName(cb_initialNode.Text), nodeCollection.getIndexByName(cb_endNode.Text));


            totalJarak = lqueue.totalJarak;
            elapsedTimeMs = lqueue.elapsedTimeMs;

            return lqueue.path;
        }
    }
}
