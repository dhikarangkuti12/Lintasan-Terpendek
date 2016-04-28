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
    public partial class MainWindow : MaterialForm
    {
        private bool isGraphReady;
        private readonly MaterialSkinManager materialSkinManager;

        private NodeCollection nodeCollection;

        private System.Diagnostics.Stopwatch watch;

        private double totalJarak;

        private bool isNewGraph = false;

        public MainWindow()
        {
            nodeCollection = new NodeCollection();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponents();

            Load += Form1_Load;

            panel_nodeProperty.Visible = false;

            isGraphReady = false;

            cb_algoritma.Text = cb_algoritma.Items[0].ToString();

            watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Stop();

            textBox_about.ScrollBars = ScrollBars.Vertical;

        }

        void Form1_Load(object sender, EventArgs e)
        {
            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();
        }

        private void but_generate_Click(object sender, EventArgs e)
        {
            _gArea.RelayoutGraph();
        }

        private void but_reload_Click(object sender, EventArgs e)
        {

            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();

            _gArea.GenerateGraph(true);
            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();

            //_gArea.SetEdgesHighlight(true, (GraphControlType)1);

            _gArea.RelayoutGraph();

            _gArea.ShowAllEdgesArrows(true);

            isGraphReady = true;
        }

        private void btn_tambahNode_Click(object sender, EventArgs e)
        {
            if(txtField_nodeName.Text!="" && !nodeCollection.isContainsNode(txtField_nodeName.Text))
            {
                nodeCollection.addNode(new Nodes(txtField_nodeName.Text));
                treeView1.Nodes[0].Nodes.Add(txtField_nodeName.Text);
                updateAvailableNeigborsComboBox();
            }

            updatePathFinderComboBox();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text != "Root")
            {
                updateAvailableNeigborsComboBox();
                panel_nodeProperty.Visible = true;
                nodeCollection.selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);
                populateSelectedNodeDataToList();
            }
            else
            {
                panel_nodeProperty.Visible = false;
            }
        }

        private void btn_tambahTetangga_Click(object sender, EventArgs e)
        {
            if(comboBox_neighbors.Text != "")
            {
                var selectedNeighborName = comboBox_neighbors.Text;
                var selectedNeighbor = nodeCollection.getNodeByName(selectedNeighborName);

                listview_nodeNeighbors.Items.Add(new ListViewItem(new[] { selectedNeighborName, "0" }));
                nodeCollection.selectedNode.addNeighbor(selectedNeighborName);
                //nodeCollection.getNodeByName(selectedNeighborName).addNeighbor(nodeCollection.selectedNode.name);

                updateAvailableNeigborsComboBox();
                comboBox_neighbors.Text = "";
            }
        }

        private void btn_deleteSelectedNode_Click(object sender, EventArgs e)
        {
            if (listview_nodeNeighbors.SelectedItems.Count > 0)
            {
                var selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);
                selectedNode.removeNeighbor(listview_nodeNeighbors.SelectedItems[0].Text);
                //nodeCollection.getNodeByName(listview_nodeNeighbors.SelectedItems[0].Text).removeNeighbor(selectedNode.name);

                updateAvailableNeigborsComboBox();
                populateSelectedNodeDataToList();
            }
        }

        private void listview_nodeNeighbors_DoubleClick(object sender, EventArgs e)
        {
            if (listview_nodeNeighbors.SelectedItems.Count > 0)
            {
                var selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);

                var selectedNeighbor = selectedNode.getNeighborByName(listview_nodeNeighbors.SelectedItems[0].Text);

                using (textInputDialogue updateJarakDialogue = new textInputDialogue("Update Jarak","",selectedNeighbor.jarak.ToString()))
                {
                    updateJarakDialogue.checkBox.Text = "Dua arah";
                    updateJarakDialogue.checkBox.Visible = true;

                    if (updateJarakDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        selectedNeighbor.jarak = double.Parse(updateJarakDialogue.inputText);

                        if (updateJarakDialogue.checkBox.Checked == true)
                        {
                            if(nodeCollection.getNodeByName(selectedNeighbor.node.name).getNeighborByName(nodeCollection.selectedNode.name) == null)
                            {
                                nodeCollection.getNodeByName(selectedNeighbor.node.name).addNeighbor(nodeCollection.selectedNode.name);
                            }
                            selectedNeighbor.node.getNeighborByName(selectedNode.name).jarak = selectedNeighbor.jarak;
                        }
                    }
                }
                populateSelectedNodeDataToList();
            }
        }

        private void btn_calculateShortestPath_Click(object sender, EventArgs e)
        {
            if (!isGraphReady)
                return;

            if (cb_initialNode.Text == "" || cb_endNode.Text == "")
                return;

            if (cb_initialNode.Items.Count == 0 || cb_endNode.Items.Count == 0)
                return;

            if (cb_initialNode.Text == cb_endNode.Text)
            {
                List<int> hasil = new List<int>();
                hasil.Add(nodeCollection.getIndexByName(cb_initialNode.Text));
                hasil.Add(nodeCollection.getIndexByName(cb_endNode.Text));
                highlightPath(hasil);

                lbl_executionTime.Text = "";
                lbl_totalJarak.Text = "";
                return;
            }

            

            List<int> result = new List<int>();

            double elapsedMs = 0;

            if (cb_algoritma.Text == "Floyd")
            {
                watch.Restart();
                result = getPathWithFloyd();
            }
            else
            {
                watch.Restart();
                result = getPathWithLqueue();
            }

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
           
            highlightPath(result);

            lbl_executionTime.Text = (elapsedMs + " ms");
            lbl_totalJarak.Text = (totalJarak.ToString());
        }

        private void btn_loadNodes_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "json files (*.json)|*.json|All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            string sFileName = "";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                Console.WriteLine(sFileName);
            }

            if (sFileName != "")
            {
                PlainNodeCollection plainNodesCollection = JsonSerialization.ReadFromJsonFile<PlainNodeCollection>(sFileName);

                this.nodeCollection = plainNodesCollection.toNodeCollection();

                treeView1.Nodes[0].Nodes.Clear();
                foreach (var node in nodeCollection.Nodes)
                {
                    treeView1.Nodes[0].Nodes.Add(node.name);
                }

                updatePathFinderComboBox();
            }
            isGraphReady = false;
            isNewGraph = true;
        }

        private void btn_saveNodes_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (textInputDialogue updateJarakDialogue = new textInputDialogue("Nama File", "Nama File", null))
            {
                if (updateJarakDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = updateJarakDialogue.inputText;
                }
            }

            string path = Directory.GetCurrentDirectory();

            path = string.Format("{0}\\SavedGraphs", path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (fileName == "" || fileName == null)
                fileName = "default";

            path = string.Format("{0}\\{1}.json", path, fileName);

            JsonSerialization.WriteToJsonFile(path, nodeCollection.serialize());
        }
        

        private void btn_deleteNode_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Root")
                return;

            var selectedNodeIndex = nodeCollection.getIndexByName(treeView1.SelectedNode.Text);
            var selectedNodeName = nodeCollection.Nodes[selectedNodeIndex].name;

            nodeCollection.Nodes.RemoveAt(selectedNodeIndex);

            treeView1.Nodes[0].Nodes.RemoveAt(selectedNodeIndex);

            foreach(var node in nodeCollection.Nodes)
            {
                var i = 0;

                while(i != node.neighborsCollection.Nodes.Count)
                {
                    var neighbor = node.neighborsCollection.Nodes[i];
                    if (neighbor.node.name == selectedNodeName)
                    {
                        node.removeNeighborHard(selectedNodeName);

                        node.neighborsCollection.Nodes.RemoveAt(node.neighborsCollection.getNeighborIndexByName(neighbor.node.name));
                        i--;
                    }
                    i++;
                }
            }

            populateSelectedNodeDataToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(materialTabControl1.SelectedIndex == 1 && isNewGraph)
            {
                but_reload_Click(sender, e);
                isNewGraph = false;
            }
        }
    }
}
