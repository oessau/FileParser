namespace FileParser
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProbes = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxProbe = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxGroup = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelSearch = new System.Windows.Forms.ToolStripLabel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.toolStripProbes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(501, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matLabToolStripMenuItem,
            this.cassToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.graphToolStripMenuItem.Text = "AddGraph";
            // 
            // matLabToolStripMenuItem
            // 
            this.matLabToolStripMenuItem.Name = "matLabToolStripMenuItem";
            this.matLabToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.matLabToolStripMenuItem.Text = "MatLab *.txt";
            this.matLabToolStripMenuItem.Visible = false;
            this.matLabToolStripMenuItem.Click += new System.EventHandler(this.matLabToolStripMenuItem_Click);
            // 
            // cassToolStripMenuItem
            // 
            this.cassToolStripMenuItem.Name = "cassToolStripMenuItem";
            this.cassToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cassToolStripMenuItem.Text = "Cassiopeia *.cass";
            this.cassToolStripMenuItem.Click += new System.EventHandler(this.cassToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.removeAllToolStripMenuItem.Text = "RemoveAll";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripErrorLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 428);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(501, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripErrorLabel
            // 
            this.toolStripErrorLabel.Name = "toolStripErrorLabel";
            this.toolStripErrorLabel.Size = new System.Drawing.Size(486, 17);
            this.toolStripErrorLabel.Spring = true;
            // 
            // toolStripProbes
            // 
            this.toolStripProbes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxProbe,
            this.toolStripComboBoxGroup,
            this.toolStripSeparator1,
            this.toolStripTextBoxSearch,
            this.toolStripLabelSearch});
            this.toolStripProbes.Location = new System.Drawing.Point(0, 24);
            this.toolStripProbes.Name = "toolStripProbes";
            this.toolStripProbes.Size = new System.Drawing.Size(501, 25);
            this.toolStripProbes.TabIndex = 3;
            this.toolStripProbes.Text = "toolStrip1";
            this.toolStripProbes.Visible = false;
            // 
            // toolStripComboBoxProbe
            // 
            this.toolStripComboBoxProbe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxProbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxProbe.Name = "toolStripComboBoxProbe";
            this.toolStripComboBoxProbe.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxProbe.ToolTipText = "Serial";
            this.toolStripComboBoxProbe.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxProbe_SelectedIndexChanged);
            // 
            // toolStripComboBoxGroup
            // 
            this.toolStripComboBoxGroup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxGroup.Name = "toolStripComboBoxGroup";
            this.toolStripComboBoxGroup.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxGroup.ToolTipText = "Group";
            this.toolStripComboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxGroup_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripTextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearch.ToolTipText = "Search by Serial Number";
            this.toolStripTextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearch_KeyDown);
            // 
            // toolStripLabelSearch
            // 
            this.toolStripLabelSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSearch.Name = "toolStripLabelSearch";
            this.toolStripLabelSearch.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabelSearch.Text = "Search:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 24);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(501, 404);
            this.zedGraphControl1.TabIndex = 4;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.toolStripProbes);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(517, 489);
            this.Name = "FormMain";
            this.Text = "Graph Comparator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripProbes.ResumeLayout(false);
            this.toolStripProbes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cassToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripErrorLabel;
        private System.Windows.Forms.ToolStrip toolStripProbes;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxProbe;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxGroup;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch;
    }
}

