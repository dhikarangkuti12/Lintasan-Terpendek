using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Forms;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using QuickGraph;

namespace JarakTerdekat
{
    class Node
    {
        public string name;
        public DataVertex vertex;

        public List<Node> availableNeighbors;
        public NeighborCollection neighborsCollection;
        public List<Node> allNodes;

        public Node(string name)
        {
            this.name = name;
            this.availableNeighbors = new List<Node>();
            this.neighborsCollection = new NeighborCollection();
        }

        public void addNeighbor(string neighborName)
        {
            int index = getIndexByName(neighborName, allNodes);

            if(index != -1)
            {
                neighborsCollection.Nodes.Add(new Neighbor(allNodes[index], 0));
                foreach(var node in availableNeighbors)
                {
                    Console.WriteLine(node.name);
                }
                availableNeighbors.RemoveAt(getIndexByName(allNodes[index].name, availableNeighbors));
            }
        }

        public void removeNeighbor(string neighborName)
        {

        }

        protected int getIndexByName(string nodeName, List<Node> Collection)
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
        public Node node;

        public Neighbor(Node neighbor, double jarak)
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
    }
}
