using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class NodeCollection
    {
        public List<Nodes> Nodes;
        public Nodes selectedNode;

        public NodeCollection()
        {
            this.Nodes = new List<Nodes>();
        }

        public void addNode(Nodes newNode)
        {
            Nodes.Add(newNode);
            Nodes[Nodes.Count - 1].allNodes = this;
            addPreviousNodesToAvailableNeighobor();
            addToNodesAvailableNeigbor(Nodes.Count - 1);
        }

        public bool isContainsNode(string name)
        {
            foreach(var node in Nodes)
            {
                if(node.name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public Nodes getNodeByName(string name)
        {
            var index = getIndexByName(name);

            if(index != -1)
            {
                return Nodes[index];
            }

            return null;
        }

        public int getIndexByName(string name)
        {
            int index = -1;
            int count = 0;
            foreach (var node in Nodes)
            {
                if (node.name == name)
                {
                    index = count;
                    break;
                }
                count++;
            }
            return index;
        }

        public PlainNodeCollection serialize()
        {
            PlainNodeCollection plainNodesCollection = new PlainNodeCollection();

            plainNodesCollection.populateNodes(Nodes);

            return plainNodesCollection;
        }

        protected void addPreviousNodesToAvailableNeighobor()
        {
            if (Nodes.Count - 1 >= 0)
            {
                for (int i=0; i<Nodes.Count-1; i++)
                {
                    Nodes[Nodes.Count - 1].availableNeighbors.Add(Nodes[i]);
                }
            }
        }

        protected void addToNodesAvailableNeigbor(int index)
        {
            foreach(var node in Nodes)
            {
                if (node.name != Nodes[index].name)
                {
                    node.availableNeighbors.Add(Nodes[Nodes.Count - 1]);
                }
            }
        }
    }
}
