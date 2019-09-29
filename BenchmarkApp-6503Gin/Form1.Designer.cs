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
            this.lbxStaff = new System.Windows.Forms.ListBox();
            this.SortZA = new System.Windows.Forms.Button();
            this.SortAZ = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxSearchSave = new System.Windows.Forms.GroupBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbxStaffID = new System.Windows.Forms.TextBox();
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDOB = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.gbxLoadSort.SuspendLayout();
            this.gbxSearchSave.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadSort
            // 
            this.gbxLoadSort.Controls.Add(this.lbxStaff);
            this.gbxLoadSort.Controls.Add(this.SortZA);
            this.gbxLoadSort.Controls.Add(this.SortAZ);
            this.gbxLoadSort.Controls.Add(this.btnLoad);
            this.gbxLoadSort.Location = new System.Drawing.Point(27, 58);
            this.gbxLoadSort.Name = "gbxLoadSort";
            this.gbxLoadSort.Size = new System.Drawing.Size(252, 321);
            this.gbxLoadSort.TabIndex = 0;
            this.gbxLoadSort.TabStop = false;
            this.gbxLoadSort.Text = "Load and Sort";
            // 
            // lbxStaff
            // 
            this.lbxStaff.FormattingEnabled = true;
            this.lbxStaff.ItemHeight = 16;
            this.lbxStaff.Location = new System.Drawing.Point(11, 61);
            this.lbxStaff.Name = "lbxStaff";
            this.lbxStaff.Size = new System.Drawing.Size(235, 244);
            this.lbxStaff.TabIndex = 3;
            this.ttpToolTips.SetToolTip(this.lbxStaff, "Displays a list of creatures");
            // 
            // SortZA
            // 
            this.SortZA.Location = new System.Drawing.Point(180, 21);
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
            this.SortAZ.Location = new System.Drawing.Point(95, 21);
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
            this.btnLoad.Location = new System.Drawing.Point(11, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 29);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Loads a list of staff");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // gbxSearchSave
            // 
            this.gbxSearchSave.Controls.Add(this.lbxSearchResults);
            this.gbxSearchSave.Controls.Add(this.btnSearch);
            this.gbxSearchSave.Controls.Add(this.tbxSearch);
            this.gbxSearchSave.Location = new System.Drawing.Point(285, 58);
            this.gbxSearchSave.Name = "gbxSearchSave";
            this.gbxSearchSave.Size = new System.Drawing.Size(420, 321);
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
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(504, 161);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(58, 17);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.Location = new System.Drawing.Point(563, 156);
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.ReadOnly = true;
            this.tbxStaffID.Size = new System.Drawing.Size(132, 22);
            this.tbxStaffID.TabIndex = 6;
            this.ttpToolTips.SetToolTip(this.tbxStaffID, "Age of selected creature");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(586, 316);
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
            this.menuStrip1.Size = new System.Drawing.Size(717, 28);
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.sortAZToolStripMenuItem.Text = "Sort AZ";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.SortAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
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
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
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
            this.stsStatus.Size = new System.Drawing.Size(717, 26);
            this.stsStatus.TabIndex = 10;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(50, 20);
            this.tslStatus.Text = "Ready";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(563, 117);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(132, 22);
            this.tbxName.TabIndex = 16;
            this.ttpToolTips.SetToolTip(this.tbxName, "Age of selected creature");
            // 
            // tbxDOB
            // 
            this.tbxDOB.Location = new System.Drawing.Point(563, 194);
            this.tbxDOB.Name = "tbxDOB";
            this.tbxDOB.ReadOnly = true;
            this.tbxDOB.Size = new System.Drawing.Size(132, 22);
            this.tbxDOB.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxDOB, "Owner of selected creature");
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(563, 232);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(132, 22);
            this.tbxEmail.TabIndex = 22;
            this.ttpToolTips.SetToolTip(this.tbxEmail, "Age of selected creature");
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(563, 271);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.ReadOnly = true;
            this.tbxSalary.Size = new System.Drawing.Size(132, 22);
            this.tbxSalary.TabIndex = 19;
            this.ttpToolTips.SetToolTip(this.tbxSalary, "Age of selected creature");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(504, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(504, 199);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(42, 17);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "DOB:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(504, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(504, 276);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 17);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 408);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxDOB);
            this.Controls.Add(this.tbxStaffID);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblStaffID);
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
        private System.Windows.Forms.ListBox lbxStaff;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbxStaffID;
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
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox tbxDOB;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Label lblSalary;
    }
}

