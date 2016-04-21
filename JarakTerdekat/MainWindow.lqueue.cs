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

            L_queue lqueue = new L_queue();

            var fromIndex = -1;
            var toIndex = -1;
            var cost = 0.0;

            for (int i = 0; i < nodeCollection.Nodes.Count; i++)
            {
                fromIndex = i;

                if (nodeCollection.Nodes[i].neighborsCollection.Nodes.Count > 0)
                {
                    foreach (var neighbor in nodeCollection.Nodes[i].neighborsCollection.Nodes)
                    {
                        toIndex = nodeCollection.getIndexByName(neighbor.node.name);
                        cost = neighbor.jarak;

                        lqueue.Edge.Add(new L_queue.edge(fromIndex, toIndex, cost));
                    }
                }
            }

            lqueue.getShortestPathList(nodeCollection.getIndexByName(cb_initialNode.Text), nodeCollection.getIndexByName(cb_endNode.Text));

            totalJarak = lqueue.totalJarak;

            return lqueue.shortestPathList;
        }
    }
}
