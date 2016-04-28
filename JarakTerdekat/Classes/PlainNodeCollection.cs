using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class PlainNodeCollection
    {
        public List<PlainNode> plainNodes;

        public PlainNodeCollection()
        {
            plainNodes = new List<PlainNode>();
        }

        public void populateNodes(List<Nodes> Nodes)
        {
            foreach (var node in Nodes)
            {
                plainNodes.Add(new PlainNode());

                plainNodes[plainNodes.Count - 1].name = node.name;

                foreach (var neighbor in node.neighborsCollection.Nodes)
                {
                    plainNodes[plainNodes.Count - 1].NeighborCollection.Add(new PlainNeighbor(neighbor.node.name, neighbor.jarak));
                }

                foreach (var availableNeighbor in node.availableNeighbors)
                {
                    plainNodes[plainNodes.Count - 1].availableNeighbors.Add(availableNeighbor.name);
                }
            }
        }

        public NodeCollection toNodeCollection()
        {
            NodeCollection nodeCollection = new NodeCollection();

            foreach(var plainNode in plainNodes)
            {
                nodeCollection.addNode(new Nodes(plainNode.name));
            }

            foreach (var plainNode in plainNodes)
            {
                foreach (var plainNeighbor in plainNode.NeighborCollection)
                {
                    var node = nodeCollection.getNodeByName(plainNode.name);

                    node.addNeighbor(plainNeighbor.name);

                    node.neighborsCollection.Nodes[node.neighborsCollection.Nodes.Count - 1].jarak = plainNeighbor.jarak;
                }
            }

            

            return nodeCollection;
        }
    }
}
