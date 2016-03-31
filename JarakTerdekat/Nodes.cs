﻿using System;
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
        public List<Node> neighbors;
        public List<Node> allNodes;

        public struct Position
        {
            double x;
            double y;
        };

        public Node(List<Node> allNodes, string name, double x, double y)
        {
            this.name = name;

            this.allNodes = allNodes;
            this.availableNeighbors = new List<Node>();
            this.neighbors = new List<Node>();
        }

        public void addNeighbor(string neighborName)
        {
            int index = getIndexByName(neighborName);

            if(index != -1)
            {
                this.neighbors.Add(this.allNodes[index]);
                this.availableNeighbors.Remove(this.allNodes[index]);
            }
        }

        public void removeNeighbor(string neighborName)
        {
            int index = getIndexByName(neighborName);

            if (index != -1)
            {
                this.neighbors.Remove(this.allNodes[index]);
                this.availableNeighbors.Add(this.allNodes[index]);
            }
        }

        protected int getIndexByName(string nodeName)
        {
            int index = -1;
            int count = 0;
            foreach (var node in this.allNodes)
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
}
