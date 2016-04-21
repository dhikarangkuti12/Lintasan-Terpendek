using System;
using System.Linq;
using System.Windows;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using GraphX.Controls.Models;
using QuickGraph;

namespace JarakTerdekat
{
    partial class MainWindow
    {
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
            if (cpyRght == null)
                throw new Exception();
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
            for (int i = 0; i < nodeCollection.Nodes.Count; i++)
            {
                if (nodeCollection.Nodes[i].neighborsCollection.Nodes.Count > 0)
                {
                    foreach (var neighbor in nodeCollection.Nodes[i].neighborsCollection.Nodes)
                    {
                        dataEdge = new DataEdge(vlist[i], vlist[nodeCollection.getIndexByName(neighbor.node.name)]) { Text = neighbor.jarak.ToString() };
                        dataGraph.AddEdge(dataEdge);

                        neighbor.edge = dataEdge;
                    }
                }
            }

            return dataGraph;
        }
    }
}
