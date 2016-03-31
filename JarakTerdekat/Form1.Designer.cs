namespace JarakTerdekat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Root");
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.but_generate = new System.Windows.Forms.Button();
            this.but_reload = new System.Windows.Forms.Button();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.neighborsPanel = new System.Windows.Forms.Panel();
            this.btnTambahTetangga = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxAvailableNeighbors = new System.Windows.Forms.ComboBox();
            this.btnRemoveRowFromTable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTambahNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textfieldTambahNode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.neighborsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(254, 6);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(828, 484);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // but_generate
            // 
            this.but_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_generate.Image = ((System.Drawing.Image)(resources.GetObject("but_generate.Image")));
            this.but_generate.Location = new System.Drawing.Point(1088, 10);
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
            this.but_reload.Location = new System.Drawing.Point(1088, 97);
            this.but_reload.Name = "but_reload";
            this.but_reload.Size = new System.Drawing.Size(65, 65);
            this.but_reload.TabIndex = 2;
            this.but_reload.UseVisualStyleBackColor = true;
            this.but_reload.Click += new System.EventHandler(this.but_reload_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1170, 48);
            this.materialTabSelector2.TabIndex = 19;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 118);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1170, 522);
            this.materialTabControl2.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialDivider4);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.but_reload);
            this.tabPage3.Controls.Add(this.but_generate);
            this.tabPage3.Controls.Add(this.wpfHost);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1162, 496);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Home";
            // 
            // materialDivider4
            // 
            this.materialDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(250, 17);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1, 479);
            this.materialDivider4.TabIndex = 21;
            this.materialDivider4.TabStop = false;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialRaisedButton2);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.materialFlatButton6);
            this.panel1.Controls.Add(this.materialFlatButton5);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 484);
            this.panel1.TabIndex = 0;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(124, 178);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(106, 32);
            this.materialRaisedButton2.TabIndex = 23;
            this.materialRaisedButton2.Text = "Go";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(109, 129);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 81);
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
            this.materialFlatButton6.Location = new System.Drawing.Point(4, 120);
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
            this.materialFlatButton5.Location = new System.Drawing.Point(4, 72);
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
            this.materialFlatButton4.Location = new System.Drawing.Point(13, 18);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = true;
            this.materialFlatButton4.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton4.TabIndex = 18;
            this.materialFlatButton4.Text = "Tentukan Rute";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1162, 496);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Manage Node";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.neighborsPanel);
            this.panel5.Controls.Add(this.btnRemoveNode);
            this.panel5.Controls.Add(this.materialDivider3);
            this.panel5.Controls.Add(this.materialDivider2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.treeView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1156, 490);
            this.panel5.TabIndex = 1;
            // 
            // neighborsPanel
            // 
            this.neighborsPanel.Controls.Add(this.btnTambahTetangga);
            this.neighborsPanel.Controls.Add(this.comboBoxAvailableNeighbors);
            this.neighborsPanel.Controls.Add(this.btnRemoveRowFromTable);
            this.neighborsPanel.Controls.Add(this.materialListView1);
            this.neighborsPanel.Location = new System.Drawing.Point(207, 0);
            this.neighborsPanel.Name = "neighborsPanel";
            this.neighborsPanel.Size = new System.Drawing.Size(343, 497);
            this.neighborsPanel.TabIndex = 2;
            // 
            // btnTambahTetangga
            // 
            this.btnTambahTetangga.Depth = 0;
            this.btnTambahTetangga.Location = new System.Drawing.Point(135, 7);
            this.btnTambahTetangga.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTambahTetangga.Name = "btnTambahTetangga";
            this.btnTambahTetangga.Primary = true;
            this.btnTambahTetangga.Size = new System.Drawing.Size(146, 23);
            this.btnTambahTetangga.TabIndex = 28;
            this.btnTambahTetangga.Text = "Tambah Tetangga";
            this.btnTambahTetangga.UseVisualStyleBackColor = true;
            this.btnTambahTetangga.Click += new System.EventHandler(this.btnTambahTetangga_Click);
            // 
            // comboBoxAvailableNeighbors
            // 
            this.comboBoxAvailableNeighbors.FormattingEnabled = true;
            this.comboBoxAvailableNeighbors.Location = new System.Drawing.Point(8, 7);
            this.comboBoxAvailableNeighbors.Name = "comboBoxAvailableNeighbors";
            this.comboBoxAvailableNeighbors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAvailableNeighbors.TabIndex = 26;
            // 
            // btnRemoveRowFromTable
            // 
            this.btnRemoveRowFromTable.Depth = 0;
            this.btnRemoveRowFromTable.Location = new System.Drawing.Point(259, 467);
            this.btnRemoveRowFromTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveRowFromTable.Name = "btnRemoveRowFromTable";
            this.btnRemoveRowFromTable.Primary = true;
            this.btnRemoveRowFromTable.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRowFromTable.TabIndex = 27;
            this.btnRemoveRowFromTable.Text = "Remove";
            this.btnRemoveRowFromTable.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(8, 34);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.RightToLeftLayout = true;
            this.materialListView1.Size = new System.Drawing.Size(326, 427);
            this.materialListView1.TabIndex = 25;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
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
            // btnRemoveNode
            // 
            this.btnRemoveNode.Depth = 0;
            this.btnRemoveNode.Location = new System.Drawing.Point(123, 470);
            this.btnRemoveNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Primary = true;
            this.btnRemoveNode.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNode.TabIndex = 22;
            this.btnRemoveNode.Text = "Remove";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(553, 5);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1, 479);
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
            this.materialDivider2.Size = new System.Drawing.Size(1, 479);
            this.materialDivider2.TabIndex = 20;
            this.materialDivider2.TabStop = false;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.btnTambahNode);
            this.panel4.Controls.Add(this.textfieldTambahNode);
            this.panel4.Location = new System.Drawing.Point(654, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 484);
            this.panel4.TabIndex = 6;
            // 
            // btnTambahNode
            // 
            this.btnTambahNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambahNode.Depth = 0;
            this.btnTambahNode.Location = new System.Drawing.Point(252, 239);
            this.btnTambahNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTambahNode.Name = "btnTambahNode";
            this.btnTambahNode.Primary = true;
            this.btnTambahNode.Size = new System.Drawing.Size(160, 34);
            this.btnTambahNode.TabIndex = 1;
            this.btnTambahNode.Text = "Tambah Node";
            this.btnTambahNode.UseVisualStyleBackColor = true;
            this.btnTambahNode.Click += new System.EventHandler(this.btnTambahNode_Click);
            // 
            // textfieldTambahNode
            // 
            this.textfieldTambahNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textfieldTambahNode.Depth = 0;
            this.textfieldTambahNode.Hint = "Nama Node";
            this.textfieldTambahNode.Location = new System.Drawing.Point(45, 210);
            this.textfieldTambahNode.MaxLength = 32767;
            this.textfieldTambahNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textfieldTambahNode.Name = "textfieldTambahNode";
            this.textfieldTambahNode.PasswordChar = '\0';
            this.textfieldTambahNode.SelectedText = "";
            this.textfieldTambahNode.SelectionLength = 0;
            this.textfieldTambahNode.SelectionStart = 0;
            this.textfieldTambahNode.Size = new System.Drawing.Size(367, 23);
            this.textfieldTambahNode.TabIndex = 3;
            this.textfieldTambahNode.TabStop = false;
            this.textfieldTambahNode.UseSystemPasswordChar = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.treeView1.Location = new System.Drawing.Point(3, 37);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(195, 427);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1162, 496);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Setting";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.materialButton1);
            this.panel6.Controls.Add(this.materialRaisedButton1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1162, 496);
            this.panel6.TabIndex = 24;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton1.Depth = 0;
            this.materialButton1.Location = new System.Drawing.Point(442, 201);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Primary = true;
            this.materialButton1.Size = new System.Drawing.Size(135, 36);
            this.materialButton1.TabIndex = 23;
            this.materialButton1.Text = "Ganti Theme";
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(583, 201);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(179, 36);
            this.materialRaisedButton1.TabIndex = 22;
            this.materialRaisedButton1.Text = "Ganti color scheme";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 723);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabControl2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penentu Rute Terdekat";
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.neighborsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button but_generate;
        private System.Windows.Forms.Button but_reload;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnTambahNode;
        private MaterialSkin.Controls.MaterialSingleLineTextField textfieldTambahNode;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialRaisedButton materialButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveNode;
        private System.Windows.Forms.Panel neighborsPanel;
        private MaterialSkin.Controls.MaterialRaisedButton btnTambahTetangga;
        private System.Windows.Forms.ComboBox comboBoxAvailableNeighbors;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveRowFromTable;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

