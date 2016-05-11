using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using GraphX.Controls.Models;
using QuickGraph;

using MaterialSkin;
using MaterialSkin.Controls;

using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace JarakTerdekat
{
    partial class MainWindow
    {
        private void updatePathFinderComboBox()
        {
            cb_initialNode.Items.Clear();
            cb_endNode.Items.Clear();
            foreach (var node in nodeCollection.Nodes)
            {
                cb_initialNode.Items.Add(node.name);
                cb_endNode.Items.Add(node.name);
            }
        }

        private void updateAvailableNeigborsComboBox()
        {
            if (treeView1.SelectedNode != treeView1.Nodes[0] && treeView1.SelectedNode != null)
            {
                comboBox_neighbors.Items.Clear();
                foreach (var node in nodeCollection.getNodeByName(treeView1.SelectedNode.Text).availableNeighbors)
                {
                    comboBox_neighbors.Items.Add(node.name);
                }
            }
        }

        private void populateSelectedNodeDataToList()
        {
            listview_nodeNeighbors.Items.Clear();

            var selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);
            var nodeNeighbors = selectedNode.neighborsCollection.Nodes;

            foreach (var neighbor in nodeNeighbors)
            {
                listview_nodeNeighbors.Items.Add(new ListViewItem(new[] { neighbor.node.name, neighbor.jarak.ToString() }));
            }
        }

        private void highlightPath(List<int> indexs)
        {
            if (indexs == null)
                return;

            Console.WriteLine("indexs:");
            foreach (var ind in indexs)
            {
                Console.WriteLine("indexs: " + ind);
            }
            _gArea.SetVerticesHighlight(false, (GraphControlType)1);

            foreach (var edge in _gArea.EdgesList)
            {
                HighlightBehaviour.SetHighlighted(edge.Value, false);
            }

            var index = 0;
            var currentNode = nodeCollection.Nodes[0];
            var nextNode = nodeCollection.Nodes[0];

            for (int i = 0; i < indexs.Count; i++)
            {
                index = indexs[i];
                currentNode = nodeCollection.Nodes[index];

                Console.WriteLine("Current Node: " + currentNode.name);

                if (i + 1 < indexs.Count)
                {
                    nextNode = nodeCollection.Nodes[indexs[i + 1]];

                    highlightTheEdge(currentNode, nextNode);
                    highlightTheEdge(nextNode, currentNode);
                }

                HighlightBehaviour.SetHighlighted(_gArea.VertexList[currentNode.vertex], true);
            }

        }

        private void highlightTheEdge(Nodes currentNode, Nodes nextNode)
        {
            Neighbor currentNeighbor = null;

            currentNeighbor = currentNode.getNeighborByName(nextNode.name);

            if (currentNeighbor != null)
                HighlightBehaviour.SetHighlighted(_gArea.EdgesList[currentNeighbor.edge], true);
        }
    }
}
