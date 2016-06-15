using System;
using System.Diagnostics;

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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Root");
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Title = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_totalJarak = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_executionTime = new MaterialSkin.Controls.MaterialLabel();
            this.cb_algoritma = new System.Windows.Forms.ComboBox();
            this.btn_calculateShortestPath = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cb_endNode = new System.Windows.Forms.ComboBox();
            this.cb_initialNode = new System.Windows.Forms.ComboBox();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.but_reload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_deleteNode = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_about = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cpyRght = new System.Windows.Forms.Label();
            this.but_generate = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.Title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_nodeProperty.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.Title);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 117);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1174, 477);
            this.materialTabControl1.TabIndex = 20;
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
            // 
            // Title
            // 
            this.Title.Controls.Add(this.panel2);
            this.Title.Location = new System.Drawing.Point(4, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1166, 451);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            this.Title.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 451);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(325, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 421);
            this.panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(93, 360);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(361, 47);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "PROGRAM STUDI S-1 ILMU KOMPUTER\r\nFAKULTAS ILMU KOMPUTER DAN TEKNOLOGI INFORMASI\r\n" +
    "UNIVERSITAS SUMATERA UTARA";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(361, 107);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ANALISIS PERBANDINGAN ALGORITMA L-QUEUE \r\nDAN ALGORITMA FLOYD DALAM PENENTUAN \r\nL" +
    "INTASAN TERPENDEK PADA GRAPH\r\n\r\n\r\nDHIKA HANDAYANI RANGKUTI\r\n121401110";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::JarakTerdekat.Properties.Resources.logo_usu_untuk_semua_png1;
            this.pictureBox1.Location = new System.Drawing.Point(183, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 187);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialDivider4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.wpfHost);
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
            this.panel1.Controls.Add(this.lbl_totalJarak);
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.lbl_executionTime);
            this.panel1.Controls.Add(this.cb_algoritma);
            this.panel1.Controls.Add(this.btn_calculateShortestPath);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.cb_endNode);
            this.panel1.Controls.Add(this.cb_initialNode);
            this.panel1.Controls.Add(this.materialFlatButton6);
            this.panel1.Controls.Add(this.materialFlatButton5);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 439);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_totalJarak
            // 
            this.lbl_totalJarak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_totalJarak.AutoSize = true;
            this.lbl_totalJarak.Depth = 0;
            this.lbl_totalJarak.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_totalJarak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_totalJarak.Location = new System.Drawing.Point(140, 357);
            this.lbl_totalJarak.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_totalJarak.Name = "lbl_totalJarak";
            this.lbl_totalJarak.Size = new System.Drawing.Size(0, 19);
            this.lbl_totalJarak.TabIndex = 28;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(4, 349);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = true;
            this.materialFlatButton2.Size = new System.Drawing.Size(129, 36);
            this.materialFlatButton2.TabIndex = 29;
            this.materialFlatButton2.Text = "Total Jarak       :";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // lbl_executionTime
            // 
            this.lbl_executionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_executionTime.AutoSize = true;
            this.lbl_executionTime.Depth = 0;
            this.lbl_executionTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_executionTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_executionTime.Location = new System.Drawing.Point(140, 405);
            this.lbl_executionTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_executionTime.Name = "lbl_executionTime";
            this.lbl_executionTime.Size = new System.Drawing.Size(0, 19);
            this.lbl_executionTime.TabIndex = 25;
            // 
            // cb_algoritma
            // 
            this.cb_algoritma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_algoritma.FormattingEnabled = true;
            this.cb_algoritma.Items.AddRange(new object[] {
            "L-Queue",
            "Floyd"});
            this.cb_algoritma.Location = new System.Drawing.Point(81, 156);
            this.cb_algoritma.Name = "cb_algoritma";
            this.cb_algoritma.Size = new System.Drawing.Size(80, 21);
            this.cb_algoritma.TabIndex = 26;
            // 
            // btn_calculateShortestPath
            // 
            this.btn_calculateShortestPath.Depth = 0;
            this.btn_calculateShortestPath.Location = new System.Drawing.Point(167, 156);
            this.btn_calculateShortestPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_calculateShortestPath.Name = "btn_calculateShortestPath";
            this.btn_calculateShortestPath.Primary = true;
            this.btn_calculateShortestPath.Size = new System.Drawing.Size(46, 21);
            this.btn_calculateShortestPath.TabIndex = 23;
            this.btn_calculateShortestPath.Text = "Go";
            this.btn_calculateShortestPath.UseVisualStyleBackColor = true;
            this.btn_calculateShortestPath.Click += new System.EventHandler(this.btn_calculateShortestPath_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(4, 397);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(131, 36);
            this.materialFlatButton1.TabIndex = 27;
            this.materialFlatButton1.Text = "Execution Time  :";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cb_endNode
            // 
            this.cb_endNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_endNode.FormattingEnabled = true;
            this.cb_endNode.Location = new System.Drawing.Point(81, 109);
            this.cb_endNode.Name = "cb_endNode";
            this.cb_endNode.Size = new System.Drawing.Size(132, 21);
            this.cb_endNode.TabIndex = 22;
            // 
            // cb_initialNode
            // 
            this.cb_initialNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_initialNode.FormattingEnabled = true;
            this.cb_initialNode.Location = new System.Drawing.Point(81, 61);
            this.cb_initialNode.Name = "cb_initialNode";
            this.cb_initialNode.Size = new System.Drawing.Size(132, 21);
            this.cb_initialNode.TabIndex = 21;
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
            this.materialFlatButton4.Location = new System.Drawing.Point(4, 16);
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
            // but_reload
            // 
            this.but_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_reload.Image = ((System.Drawing.Image)(resources.GetObject("but_reload.Image")));
            this.but_reload.Location = new System.Drawing.Point(1095, 6);
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
            this.tabPage2.Text = "Setting Verteks";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_deleteNode);
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
            // btn_deleteNode
            // 
            this.btn_deleteNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteNode.Depth = 0;
            this.btn_deleteNode.Location = new System.Drawing.Point(3, 410);
            this.btn_deleteNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deleteNode.Name = "btn_deleteNode";
            this.btn_deleteNode.Primary = true;
            this.btn_deleteNode.Size = new System.Drawing.Size(195, 27);
            this.btn_deleteNode.TabIndex = 37;
            this.btn_deleteNode.Text = "Delete Selected Node";
            this.btn_deleteNode.UseVisualStyleBackColor = true;
            this.btn_deleteNode.Click += new System.EventHandler(this.btn_deleteNode_Click);
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
            this.btn_deleteSelectedNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btn_tambahTetangga.Text = "Tambah Edge";
            this.btn_tambahTetangga.UseVisualStyleBackColor = true;
            this.btn_tambahTetangga.Click += new System.EventHandler(this.btn_tambahTetangga_Click);
            // 
            // comboBox_neighbors
            // 
            this.comboBox_neighbors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            treeNode2.Name = "Node0";
            treeNode2.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(195, 387);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1166, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1160, 445);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox_about);
            this.panel7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1160, 445);
            this.panel7.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox3.Location = new System.Drawing.Point(245, 64);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(351, 100);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Name              : Dhika Handayani Rangkuti\r\nNim                 : 121401110\r\nE-" +
    "mail              : dhikahandayani12@gmail.com\r\nDepartment    : Computer Science" +
    "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.Image = global::JarakTerdekat.Properties.Resources.OKEU9948_1_;
            this.pictureBox2.Location = new System.Drawing.Point(139, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 132);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "About";
            // 
            // textBox_about
            // 
            this.textBox_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_about.BackColor = System.Drawing.Color.White;
            this.textBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_about.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_about.Location = new System.Drawing.Point(245, 170);
            this.textBox_about.Multiline = true;
            this.textBox_about.Name = "textBox_about";
            this.textBox_about.ReadOnly = true;
            this.textBox_about.Size = new System.Drawing.Size(692, 274);
            this.textBox_about.TabIndex = 2;
            this.textBox_about.Text = resources.GetString("textBox_about.Text");
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
            // cpyRght
            // 
            this.cpyRght.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpyRght.AutoSize = true;
            this.cpyRght.BackColor = System.Drawing.Color.Transparent;
            this.cpyRght.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpyRght.Location = new System.Drawing.Point(1075, 615);
            this.cpyRght.Name = "cpyRght";
            this.cpyRght.Size = new System.Drawing.Size(0, 13);
            this.cpyRght.TabIndex = 24;
            this.cpyRght.Tag = "http://www.github.com/nugrahawahyu";
            // 
            // but_generate
            // 
            this.but_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_generate.Image = ((System.Drawing.Image)(resources.GetObject("but_generate.Image")));
            this.but_generate.Location = new System.Drawing.Point(1158, 607);
            this.but_generate.Name = "but_generate";
            this.but_generate.Size = new System.Drawing.Size(10, 28);
            this.but_generate.TabIndex = 1;
            this.but_generate.UseVisualStyleBackColor = true;
            this.but_generate.Visible = false;
            this.but_generate.Click += new System.EventHandler(this.but_generate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 643);
            this.Controls.Add(this.cpyRght);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.but_generate);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penghitung Rute Terdekat";
            this.materialTabControl1.ResumeLayout(false);
            this.Title.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_nodeProperty.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_calculateShortestPath;
        private System.Windows.Forms.ComboBox cb_endNode;
        private System.Windows.Forms.ComboBox cb_initialNode;
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
        private System.Windows.Forms.ComboBox cb_algoritma;
        private MaterialSkin.Controls.MaterialLabel lbl_executionTime;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_deleteNode;
        private System.Windows.Forms.TabPage Title;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lbl_totalJarak;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label cpyRght;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_about;
    }
}

