namespace JarakTerdekat
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_calculateShortestPath = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.but_generate = new System.Windows.Forms.Button();
            this.but_reload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_loadNodes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_nodeProperty = new System.Windows.Forms.Panel();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_deleteSelectedNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_tambahTetangga = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox_neighbors = new System.Windows.Forms.ComboBox();
            this.listview_nodeNeighbors = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_saveNodes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_tambahNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtField_nodeName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_nodeProperty.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1174, 58);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 117);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1174, 477);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialDivider4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.wpfHost);
            this.tabPage1.Controls.Add(this.but_generate);
            this.tabPage1.Controls.Add(this.but_reload);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1166, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // materialDivider4
            // 
            this.materialDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(242, 11);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1, 434);
            this.materialDivider4.TabIndex = 24;
            this.materialDivider4.TabStop = false;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_calculateShortestPath);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.materialFlatButton6);
            this.panel1.Controls.Add(this.materialFlatButton5);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 380);
            this.panel1.TabIndex = 3;
            // 
            // btn_calculateShortestPath
            // 
            this.btn_calculateShortestPath.Depth = 0;
            this.btn_calculateShortestPath.Location = new System.Drawing.Point(83, 136);
            this.btn_calculateShortestPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_calculateShortestPath.Name = "btn_calculateShortestPath";
            this.btn_calculateShortestPath.Primary = true;
            this.btn_calculateShortestPath.Size = new System.Drawing.Size(106, 32);
            this.btn_calculateShortestPath.TabIndex = 23;
            this.btn_calculateShortestPath.Text = "Go";
            this.btn_calculateShortestPath.UseVisualStyleBackColor = true;
            this.btn_calculateShortestPath.Click += new System.EventHandler(this.btn_calculateShortestPath_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(68, 109);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(68, 61);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(4, 100);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(28, 36);
            this.materialFlatButton6.TabIndex = 20;
            this.materialFlatButton6.Text = "Ke";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(4, 52);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(42, 36);
            this.materialFlatButton5.TabIndex = 19;
            this.materialFlatButton5.Text = "Dari";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = true;
            this.materialFlatButton4.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton4.TabIndex = 18;
            this.materialFlatButton4.Text = "Tentukan Rute";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(245, 3);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(844, 442);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // but_generate
            // 
            this.but_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_generate.Image = ((System.Drawing.Image)(resources.GetObject("but_generate.Image")));
            this.but_generate.Location = new System.Drawing.Point(1095, 6);
            this.but_generate.Name = "but_generate";
            this.but_generate.Size = new System.Drawing.Size(65, 65);
            this.but_generate.TabIndex = 1;
            this.but_generate.UseVisualStyleBackColor = true;
            this.but_generate.Click += new System.EventHandler(this.but_generate_Click);
            // 
            // but_reload
            // 
            this.but_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_reload.Image = ((System.Drawing.Image)(resources.GetObject("but_reload.Image")));
            this.but_reload.Location = new System.Drawing.Point(1095, 77);
            this.but_reload.Name = "but_reload";
            this.but_reload.Size = new System.Drawing.Size(65, 65);
            this.but_reload.TabIndex = 2;
            this.but_reload.UseVisualStyleBackColor = true;
            this.but_reload.Click += new System.EventHandler(this.but_reload_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1166, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Vertexs";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_loadNodes);
            this.panel5.Controls.Add(this.panel_nodeProperty);
            this.panel5.Controls.Add(this.btn_saveNodes);
            this.panel5.Controls.Add(this.materialDivider3);
            this.panel5.Controls.Add(this.materialDivider2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.treeView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1160, 445);
            this.panel5.TabIndex = 1;
            // 
            // btn_loadNodes
            // 
            this.btn_loadNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadNodes.Depth = 0;
            this.btn_loadNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadNodes.Location = new System.Drawing.Point(1015, 419);
            this.btn_loadNodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_loadNodes.Name = "btn_loadNodes";
            this.btn_loadNodes.Primary = true;
            this.btn_loadNodes.Size = new System.Drawing.Size(68, 23);
            this.btn_loadNodes.TabIndex = 25;
            this.btn_loadNodes.Text = "Load";
            this.btn_loadNodes.UseVisualStyleBackColor = true;
            this.btn_loadNodes.Click += new System.EventHandler(this.btn_loadNodes_Click);
            // 
            // panel_nodeProperty
            // 
            this.panel_nodeProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_nodeProperty.Controls.Add(this.materialDivider6);
            this.panel_nodeProperty.Controls.Add(this.btn_deleteSelectedNode);
            this.panel_nodeProperty.Controls.Add(this.materialDivider5);
            this.panel_nodeProperty.Controls.Add(this.btn_tambahTetangga);
            this.panel_nodeProperty.Controls.Add(this.comboBox_neighbors);
            this.panel_nodeProperty.Controls.Add(this.listview_nodeNeighbors);
            this.panel_nodeProperty.Location = new System.Drawing.Point(207, 0);
            this.panel_nodeProperty.Name = "panel_nodeProperty";
            this.panel_nodeProperty.Size = new System.Drawing.Size(374, 448);
            this.panel_nodeProperty.TabIndex = 22;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(20, 406);
            this.materialDivider6.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(336, 1);
            this.materialDivider6.TabIndex = 36;
            this.materialDivider6.TabStop = false;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // btn_deleteSelectedNode
            // 
            this.btn_deleteSelectedNode.Depth = 0;
            this.btn_deleteSelectedNode.Location = new System.Drawing.Point(72, 410);
            this.btn_deleteSelectedNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deleteSelectedNode.Name = "btn_deleteSelectedNode";
            this.btn_deleteSelectedNode.Primary = true;
            this.btn_deleteSelectedNode.Size = new System.Drawing.Size(224, 27);
            this.btn_deleteSelectedNode.TabIndex = 29;
            this.btn_deleteSelectedNode.Text = "Delete Selected Neighbor";
            this.btn_deleteSelectedNode.UseVisualStyleBackColor = true;
            this.btn_deleteSelectedNode.Click += new System.EventHandler(this.btn_deleteSelectedNode_Click);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(12, 47);
            this.materialDivider5.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(336, 1);
            this.materialDivider5.TabIndex = 35;
            this.materialDivider5.TabStop = false;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // btn_tambahTetangga
            // 
            this.btn_tambahTetangga.Depth = 0;
            this.btn_tambahTetangga.Location = new System.Drawing.Point(146, 16);
            this.btn_tambahTetangga.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tambahTetangga.Name = "btn_tambahTetangga";
            this.btn_tambahTetangga.Primary = true;
            this.btn_tambahTetangga.Size = new System.Drawing.Size(138, 22);
            this.btn_tambahTetangga.TabIndex = 30;
            this.btn_tambahTetangga.Text = "Tambah Tetangga";
            this.btn_tambahTetangga.UseVisualStyleBackColor = true;
            this.btn_tambahTetangga.Click += new System.EventHandler(this.btn_tambahTetangga_Click);
            // 
            // comboBox_neighbors
            // 
            this.comboBox_neighbors.FormattingEnabled = true;
            this.comboBox_neighbors.Location = new System.Drawing.Point(13, 17);
            this.comboBox_neighbors.Name = "comboBox_neighbors";
            this.comboBox_neighbors.Size = new System.Drawing.Size(121, 21);
            this.comboBox_neighbors.TabIndex = 33;
            // 
            // listview_nodeNeighbors
            // 
            this.listview_nodeNeighbors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_nodeNeighbors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listview_nodeNeighbors.Depth = 0;
            this.listview_nodeNeighbors.Font = new System.Drawing.Font("Roboto", 24F);
            this.listview_nodeNeighbors.FullRowSelect = true;
            this.listview_nodeNeighbors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_nodeNeighbors.Location = new System.Drawing.Point(20, 71);
            this.listview_nodeNeighbors.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listview_nodeNeighbors.MouseState = MaterialSkin.MouseState.OUT;
            this.listview_nodeNeighbors.Name = "listview_nodeNeighbors";
            this.listview_nodeNeighbors.OwnerDraw = true;
            this.listview_nodeNeighbors.RightToLeftLayout = true;
            this.listview_nodeNeighbors.Size = new System.Drawing.Size(328, 332);
            this.listview_nodeNeighbors.TabIndex = 28;
            this.listview_nodeNeighbors.UseCompatibleStateImageBehavior = false;
            this.listview_nodeNeighbors.View = System.Windows.Forms.View.Details;
            this.listview_nodeNeighbors.DoubleClick += new System.EventHandler(this.listview_nodeNeighbors_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tetangga";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jarak";
            this.columnHeader2.Width = 123;
            // 
            // btn_saveNodes
            // 
            this.btn_saveNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveNodes.Depth = 0;
            this.btn_saveNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveNodes.Location = new System.Drawing.Point(1089, 419);
            this.btn_saveNodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_saveNodes.Name = "btn_saveNodes";
            this.btn_saveNodes.Primary = true;
            this.btn_saveNodes.Size = new System.Drawing.Size(68, 23);
            this.btn_saveNodes.TabIndex = 24;
            this.btn_saveNodes.Text = "Save";
            this.btn_saveNodes.UseVisualStyleBackColor = true;
            this.btn_saveNodes.Click += new System.EventHandler(this.btn_saveNodes_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(586, 17);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1, 428);
            this.materialDivider3.TabIndex = 21;
            this.materialDivider3.TabStop = false;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(203, 16);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 434);
            this.materialDivider2.TabIndex = 20;
            this.materialDivider2.TabStop = false;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.btn_tambahNode);
            this.panel4.Controls.Add(this.txtField_nodeName);
            this.panel4.Location = new System.Drawing.Point(588, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 439);
            this.panel4.TabIndex = 6;
            // 
            // btn_tambahNode
            // 
            this.btn_tambahNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tambahNode.Depth = 0;
            this.btn_tambahNode.Location = new System.Drawing.Point(236, 216);
            this.btn_tambahNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tambahNode.Name = "btn_tambahNode";
            this.btn_tambahNode.Primary = true;
            this.btn_tambahNode.Size = new System.Drawing.Size(160, 34);
            this.btn_tambahNode.TabIndex = 1;
            this.btn_tambahNode.Text = "Tambah Node";
            this.btn_tambahNode.UseVisualStyleBackColor = true;
            this.btn_tambahNode.Click += new System.EventHandler(this.btn_tambahNode_Click);
            // 
            // txtField_nodeName
            // 
            this.txtField_nodeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtField_nodeName.Depth = 0;
            this.txtField_nodeName.Hint = "Nama Node";
            this.txtField_nodeName.Location = new System.Drawing.Point(29, 187);
            this.txtField_nodeName.MaxLength = 32767;
            this.txtField_nodeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_nodeName.Name = "txtField_nodeName";
            this.txtField_nodeName.PasswordChar = '\0';
            this.txtField_nodeName.SelectedText = "";
            this.txtField_nodeName.SelectionLength = 0;
            this.txtField_nodeName.SelectionStart = 0;
            this.txtField_nodeName.Size = new System.Drawing.Size(367, 23);
            this.txtField_nodeName.TabIndex = 3;
            this.txtField_nodeName.TabStop = false;
            this.txtField_nodeName.UseSystemPasswordChar = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(195, 426);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 599);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1175, 1);
            this.materialDivider1.TabIndex = 23;
            this.materialDivider1.TabStop = false;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 643);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penghitung Rute Terdekat";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_nodeProperty.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_calculateShortestPath;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button but_generate;
        private System.Windows.Forms.Button but_reload;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_nodeProperty;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialRaisedButton btn_deleteSelectedNode;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialRaisedButton btn_tambahTetangga;
        private System.Windows.Forms.ComboBox comboBox_neighbors;
        private MaterialSkin.Controls.MaterialListView listview_nodeNeighbors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton btn_tambahNode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_nodeName;
        private System.Windows.Forms.TreeView treeView1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_saveNodes;
        private MaterialSkin.Controls.MaterialRaisedButton btn_loadNodes;
    }
}

