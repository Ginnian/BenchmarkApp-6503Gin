namespace BenchmarkApp_6503Gin
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
            this.components = new System.ComponentModel.Container();
            this.gbxLoadSort = new System.Windows.Forms.GroupBox();
            this.lbxCreatures = new System.Windows.Forms.ListBox();
            this.SortZA = new System.Windows.Forms.Button();
            this.SortAZ = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxOwner = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadAndSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.gbxLoadSort.SuspendLayout();
            this.gbxSearchSave.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.lbxCreatures);
            this.gbxLoadSort.Controls.Add(this.SortZA);
            this.gbxLoadSort.Controls.Add(this.SortAZ);
            this.gbxLoadSort.Controls.Add(this.btnLoad);
            this.gbxLoadSort.Location = new System.Drawing.Point(27, 58);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(230, 321);
            this.gbxLoadSort.TabIndex = 0;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // lbxCreatures
            // 
            this.lbxCreatures.FormattingEnabled = true;
            this.lbxCreatures.ItemHeight = 16;
            this.lbxCreatures.Location = new System.Drawing.Point(11, 61);
            this.lbxCreatures.Name = "lbxCreatures";
            this.lbxCreatures.Size = new System.Drawing.Size(204, 244);
            this.lbxCreatures.TabIndex = 3;
            this.ttpToolTips.SetToolTip(this.lbxCreatures, "Displays a list of creatures");
            // 
            // SortZA
            // 
            this.SortZA.Location = new System.Drawing.Point(150, 21);
            this.SortZA.Name = "SortZA";
            this.SortZA.Size = new System.Drawing.Size(66, 29);
            this.SortZA.TabIndex = 2;
            this.SortZA.Text = "ZA";
            this.ttpToolTips.SetToolTip(this.SortZA, "Sort creatures ZA");
            this.SortZA.UseVisualStyleBackColor = true;
            this.SortZA.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // SortAZ
            // 
            this.SortAZ.Location = new System.Drawing.Point(78, 21);
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(66, 29);
            this.SortAZ.TabIndex = 1;
            this.SortAZ.Text = "AZ";
            this.ttpToolTips.SetToolTip(this.SortAZ, "Sort creatures AZ");
            this.SortAZ.UseVisualStyleBackColor = true;
            this.SortAZ.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 29);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Loads a list of creatures");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Location = new System.Drawing.Point(263, 58);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(230, 321);
            this.gbxSearchSave.TabIndex = 1;
            this.gbxSearchSave.TabStop = false;
            this.gbxSearchSave.Text = "Search and Save";
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.ItemHeight = 16;
            this.lbxSearchResults.Location = new System.Drawing.Point(6, 61);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(204, 244);
            this.lbxSearchResults.TabIndex = 4;
            this.ttpToolTips.SetToolTip(this.lbxSearchResults, "Displays a list of creatures");
            this.lbxSearchResults.SelectedIndexChanged += new System.EventHandler(this.LbxSearchResults_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search creature list");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 24);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(125, 22);
            this.tbxSearch.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(512, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(512, 178);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 17);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age: ";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(512, 225);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(57, 17);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "Owner: ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(571, 128);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(132, 22);
            this.tbxName.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.tbxName, "Name of selected creature");
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(571, 173);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.ReadOnly = true;
            this.tbxAge.Size = new System.Drawing.Size(132, 22);
            this.tbxAge.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxAge, "Age of selected creature");
            // 
            // tbxOwner
            // 
            this.tbxOwner.Location = new System.Drawing.Point(571, 220);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.ReadOnly = true;
            this.tbxOwner.Size = new System.Drawing.Size(132, 22);
            this.tbxOwner.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxOwner, "Owner of selected creature");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Save selected creature");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAndSortToolStripMenuItem,
            this.saveAndSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadAndSortToolStripMenuItem
            // 
            this.loadAndSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.loadAndSortToolStripMenuItem.Name = "loadAndSortToolStripMenuItem";
            this.loadAndSortToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.loadAndSortToolStripMenuItem.Text = "Load and Sort";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sortAZToolStripMenuItem.Text = "Sort AZ";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sortZAToolStripMenuItem.Text = "Sort ZA";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.SortZA_Click);
            // 
            // saveAndSearchToolStripMenuItem
            // 
            this.saveAndSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.saveAndSearchToolStripMenuItem.Name = "saveAndSearchToolStripMenuItem";
            this.saveAndSearchToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.saveAndSearchToolStripMenuItem.Text = "Save and Search";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 382);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(720, 26);
            this.stsStatus.TabIndex = 10;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(50, 20);
            this.tslStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 408);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxOwner);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbxSearchSave);
            this.Controls.Add(this.gbxLoadSort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLoadSort.ResumeLayout(false);
            this.gbxSearchSave.ResumeLayout(false);
            this.gbxSearchSave.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoadSort;
        private System.Windows.Forms.GroupBox gbxSearchSave;
        private System.Windows.Forms.Button SortZA;
        private System.Windows.Forms.Button SortAZ;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxCreatures;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxOwner;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadAndSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
    }
}

