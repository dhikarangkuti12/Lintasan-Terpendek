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
        public DataVertex verterx;

        public List<Node> availableNeighbors;
        public List<Node> neighbors;

        public Node(string name)
        {
            this.name = name;
            this.availableNeighbors = new List<Node>();
            this.neighbors = new List<Node>();
        }

        public void addNeighbor(string neighborName)
        {

        }

        public void removeNeighbor(string neighborName)
        {

        }
    }
}
