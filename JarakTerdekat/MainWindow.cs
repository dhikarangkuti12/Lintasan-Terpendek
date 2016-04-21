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


namespace JarakTerdekat
{
    public partial class MainWindow : MaterialForm
    {
        private bool isGraphReady;
        private readonly MaterialSkinManager materialSkinManager;

        private NodeCollection nodeCollection;

        private Floyd floyd;

        private System.Diagnostics.Stopwatch watch;

        private double totalJarak;

        public MainWindow()
        {
            floyd = new Floyd();

            nodeCollection = new NodeCollection();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
            Load += Form1_Load;

            panel_nodeProperty.Visible = false;

            isGraphReady = false;

            cb_algoritma.Text = cb_algoritma.Items[0].ToString();

            watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Stop();

            //textBox_about.ScrollBars = ScrollBars.Vertical;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();
        }

        private ZoomControl _zoomctrl;
        private GraphAreaExample _gArea;

        private UIElement GenerateWpfVisuals()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            /* ENABLES WINFORMS HOSTING MODE --- >*/
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphAreaExample
            {
                EnableWinFormsHostingMode = true,
                LogicCore = logic,
                EdgeLabelFactory = new DefaultEdgelabelFactory()
            };
            _gArea.ShowAllEdgesLabels(true);
            logic.Graph = GenerateGraph();
            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.LinLog;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
            //((LinLogLayoutParameters)logic.DefaultLayoutAlgorithmParams). = 100;
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
            logic.AsyncAlgorithmCompute = false;
            _zoomctrl.Content = _gArea;
            _gArea.RelayoutFinished += gArea_RelayoutFinished;


            var myResourceDictionary = new ResourceDictionary { Source = new Uri("Templates\\template.xaml", UriKind.Relative) };
            _zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);

            return _zoomctrl;
        }

        void gArea_RelayoutFinished(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
        }

        private GraphExample GenerateGraph()
        {
            var dataGraph = new GraphExample();

            foreach (var node in nodeCollection.Nodes)
            {
                var dataVertex = new DataVertex(node.name);
                nodeCollection.getNodeByName(node.name).vertex = dataVertex;
                dataGraph.AddVertex(dataVertex);
            }

            DataEdge dataEdge;

            var vlist = dataGraph.Vertices.ToList();
            //Then create two edges optionaly defining Text property to show who are connected
            for(int i=0; i < nodeCollection.Nodes.Count; i++)
            {
                if(nodeCollection.Nodes[i].neighborsCollection.Nodes.Count > 0)
                {
                    foreach(var neighbor in nodeCollection.Nodes[i].neighborsCollection.Nodes)
                    {
                        dataEdge = new DataEdge(vlist[i], vlist[nodeCollection.getIndexByName(neighbor.node.name)]) { Text = neighbor.jarak.ToString()};
                        dataGraph.AddEdge(dataEdge);

                        neighbor.edge = dataEdge;
                    }
                }
            }

            return dataGraph;
        }

        private void but_generate_Click(object sender, EventArgs e)
        {
            wpfHost.Child = GenerateWpfVisuals();
            _zoomctrl.ZoomToFill();

            _gArea.GenerateGraph(true);
            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();

            //_gArea.SetEdgesHighlight(true, (GraphControlType)1);

            _gArea.RelayoutGraph();
            _gArea.ShowAllEdgesArrows(false);

            isGraphReady = true;
        }

        private void but_reload_Click(object sender, EventArgs e)
        {
            _gArea.RelayoutGraph();
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

        private void updateAvailableNeigborsComboBox()
        {
            if(treeView1.SelectedNode != treeView1.Nodes[0] && treeView1.SelectedNode != null)
            {
                comboBox_neighbors.Items.Clear();
                foreach (var node in nodeCollection.getNodeByName(treeView1.SelectedNode.Text).availableNeighbors)
                {
                    comboBox_neighbors.Items.Add(node.name);
                }
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
                nodeCollection.getNodeByName(selectedNeighborName).addNeighbor(nodeCollection.selectedNode.name);

                updateAvailableNeigborsComboBox();
                comboBox_neighbors.Text = "";
            }
        }

        private void populateSelectedNodeDataToList()
        {
            listview_nodeNeighbors.Items.Clear();

            var selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);
            var nodeNeighbors = selectedNode.neighborsCollection.Nodes;

            foreach(var neighbor in nodeNeighbors)
            {
                listview_nodeNeighbors.Items.Add(new ListViewItem(new[] { neighbor.node.name, neighbor.jarak.ToString() }));
            }
        }

        private void btn_deleteSelectedNode_Click(object sender, EventArgs e)
        {
            if (listview_nodeNeighbors.SelectedItems.Count > 0)
            {
                var selectedNode = nodeCollection.getNodeByName(treeView1.SelectedNode.Text);
                selectedNode.removeNeighbor(listview_nodeNeighbors.SelectedItems[0].Text);
                nodeCollection.getNodeByName(listview_nodeNeighbors.SelectedItems[0].Text).removeNeighbor(selectedNode.name);

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
                    if (updateJarakDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        selectedNeighbor.jarak = double.Parse(updateJarakDialogue.inputText);
                        selectedNeighbor.node.getNeighborByName(selectedNode.name).jarak = selectedNeighbor.jarak;
                    }
                }
                populateSelectedNodeDataToList();
            }
        }

        private void btn_calculateShortestPath_Click(object sender, EventArgs e)
        {
            if (!isGraphReady)
                return;


            if (cb_initialNode.Text == cb_endNode.Text || 
                (nodeCollection.getNodeByName(cb_initialNode.Text).neighborsCollection.Nodes.Count == 0) ||
                (nodeCollection.getNodeByName(cb_endNode.Text).neighborsCollection.Nodes.Count == 0))
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
                result = getPathWithBellmanFord();
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

        private void highlightPath(List<int> indexs)
        {
            Console.WriteLine("indexs:");
            foreach (var ind in indexs)
            {
                Console.WriteLine("indexs: " + ind);
            }
            _gArea.SetVerticesHighlight(false, (GraphControlType)1);

            foreach(var edge in _gArea.EdgesList)
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

                if(i+1 < indexs.Count)
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

            if(currentNeighbor != null)
                HighlightBehaviour.SetHighlighted(_gArea.EdgesList[currentNeighbor.edge], true);
        }

        private List<int> getPathWithFloyd()
        {
            Console.WriteLine("Algorithm: Floyd");

            double inf = double.PositiveInfinity;

            Console.WriteLine(inf);

            var pathTable = new List<List<double>>();

            for (int i = 0; i < nodeCollection.Nodes.Count; i++)
            {
                pathTable.Add(new List<double>());

                var from = nodeCollection.Nodes[i];
                var fromNeighbors = from.neighborsCollection;

                for (int j = 0; j < nodeCollection.Nodes.Count; j++)
                {
                    var to = nodeCollection.Nodes[j];

                    if (to.name == from.name)
                    {
                        pathTable[i].Add(0);
                    }
                    else
                    {
                        var index = fromNeighbors.getNeighborIndexByName(to.name);
                        if (index != -1)
                        {
                            pathTable[i].Add(fromNeighbors.Nodes[index].jarak);
                        }
                        else
                        {
                            pathTable[i].Add(inf);
                        }
                    }
                }
            }

            floyd.init(pathTable, (nodeCollection.Nodes.Count));
            var fromIndex = nodeCollection.getIndexByName(cb_initialNode.Text);
            var toIndex = nodeCollection.getIndexByName(cb_endNode.Text);

            if (fromIndex > toIndex)
            {
                var temp = fromIndex;
                fromIndex = toIndex;
                toIndex = temp;
            }

            List<int> hasil = floyd.calculateShortestPath(fromIndex, toIndex);

            totalJarak = floyd.totalJarak;

            return hasil;
        }

        private List<int> getPathWithBellmanFord()
        {
            Console.WriteLine("Algorithm: Bellman Ford");

            BellmanFord bellmanFord = new BellmanFord();

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

                        bellmanFord.Edge.Add(new BellmanFord.edge(fromIndex, toIndex, cost));
                    }
                }
            }

            bellmanFord.getShortestPathList(nodeCollection.getIndexByName(cb_initialNode.Text), nodeCollection.getIndexByName(cb_endNode.Text));

            totalJarak = bellmanFord.totalJarak;

            return bellmanFord.shortestPathList;
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

        private void textBox_about_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
