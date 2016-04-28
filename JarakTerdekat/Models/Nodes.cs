using System.Collections.Generic;


namespace JarakTerdekat
{
    class Nodes
    {
        public string name;
        public DataVertex vertex;

        public List<Nodes> availableNeighbors;
        public NeighborCollection neighborsCollection;
        public NodeCollection allNodes;

        public Nodes(string name)
        {
            this.name = name;
            this.availableNeighbors = new List<Nodes>();
            this.neighborsCollection = new NeighborCollection();
        }

        public void addNeighbor(string neighborName)
        {
            int index = getIndexByName(neighborName, allNodes.Nodes);

            if(index != -1)
            {
                neighborsCollection.Nodes.Add(new Neighbor(allNodes.Nodes[index], 0));

                availableNeighbors.RemoveAt(getIndexByName(allNodes.Nodes[index].name, availableNeighbors));
            }
        }

        public void removeNeighbor(string neighborName)
        {
            neighborsCollection.Nodes.RemoveAt(getNeighborIndexByName(neighborName, neighborsCollection.Nodes));
            availableNeighbors.Add(allNodes.Nodes[getIndexByName(neighborName, allNodes.Nodes)]);
        }

        public void removeNeighborHard(string neighborName)
        {
            int index = getIndexByName(neighborName, allNodes.Nodes);

            if (index != -1)
            {
                availableNeighbors.RemoveAt(getIndexByName(allNodes.Nodes[index].name, availableNeighbors));
            }
        }

        public Neighbor getNeighborByName(string name)
        {
            var index = getNeighborIndexByName(name, neighborsCollection.Nodes);
            if (index > -1)
            {
                return neighborsCollection.Nodes[index];
            }
            return null;
        }

        public int getIndexByName(string nodeName, List<Nodes> Collection)
        {
            int index = -1;
            int count = 0;
            foreach (var node in Collection)
            {
                if(node.name == nodeName)
                {
                    index = count;
                    break;
                }

                count++;
            }

            return index;
        }

        protected int getNeighborIndexByName(string nodeName, List<Neighbor> Collection)
        {
            int index = -1;
            int count = 0;
            foreach (var node in Collection)
            {
                if (node.node.name == nodeName)
                {
                    index = count;
                    break;
                }

                count++;
            }

            return index;
        }
    }

    class Position
    {
        public double x;
        public double y;

        public Position(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Neighbor
    {
        public double jarak;
        public Nodes node;
        public DataEdge edge;

        public Neighbor(Nodes neighbor, double jarak)
        {
            this.node = neighbor;
            this.jarak = jarak;
        }
    }

    class NeighborCollection
    {
        public List<Neighbor> Nodes;
        public NeighborCollection()
        {
            Nodes = new List<Neighbor>();
        }

        public Neighbor getNeighborByName(string name)
        {
            var index = getNeighborIndexByName(name);
            if (index > -1)
            {
                return Nodes[index];
            }
            return null;
        }

        public int getNeighborIndexByName(string nodeName)
        {
            int index = -1;
            int count = 0;
            foreach (var node in Nodes)
            {
                if (node.node.name == nodeName)
                {
                    index = count;
                    break;
                }

                count++;
            }

            return index;
        }
    }
}
