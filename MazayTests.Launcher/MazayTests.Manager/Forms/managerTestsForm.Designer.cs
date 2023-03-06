
namespace MazayTests.Manager
{
    partial class ManagerTestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerTestsForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TestScrollbar = new MazayTests.Manager.CustomScrollbar();
            this.MenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteTestButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.CancelMenu = new System.Windows.Forms.Button();
            this.TestTable = new System.Windows.Forms.TableLayoutPanel();
            this.LogoLable = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Search = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.BasisCollectionPanel = new System.Windows.Forms.Panel();
            this.CollectionScrollbar = new MazayTests.Manager.CustomScrollbar();
            this.CollectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonConrolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.BasisCollectionPanel.SuspendLayout();
            this.CollectionTable.SuspendLayout();
            this.ButtonConrolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TestScrollbar
            // 
            this.TestScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestScrollbar.AutoScroll = true;
            this.TestScrollbar.AutoSize = true;
            this.TestScrollbar.ChannelColor = System.Drawing.Color.White;
            this.TestScrollbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestScrollbar.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("TestScrollbar.DownArrowImage")));
            this.TestScrollbar.LargeChange = 5;
            this.TestScrollbar.Location = new System.Drawing.Point(1112, 0);
            this.TestScrollbar.Margin = new System.Windows.Forms.Padding(0);
            this.TestScrollbar.Maximum = 100;
            this.TestScrollbar.Minimum = 0;
            this.TestScrollbar.MinimumSize = new System.Drawing.Size(22, 561);
            this.TestScrollbar.Name = "TestScrollbar";
            this.TestScrollbar.Size = new System.Drawing.Size(22, 561);
            this.TestScrollbar.SmallChange = 1;
            this.TestScrollbar.TabIndex = 20;
            this.TestScrollbar.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("TestScrollbar.ThumbMiddleImage")));
            this.TestScrollbar.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("TestScrollbar.UpArrowImage")));
            this.TestScrollbar.Value = 0;
            this.TestScrollbar.Visible = false;
            this.TestScrollbar.Scroll += new System.EventHandler(this.TestScrollbar_Scroll);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MenuPanel.ColumnCount = 4;
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuPanel.Controls.Add(this.DeleteTestButton, 0, 0);
            this.MenuPanel.Controls.Add(this.Start, 1, 0);
            this.MenuPanel.Controls.Add(this.Settings, 2, 0);
            this.MenuPanel.Controls.Add(this.CancelMenu, 6, 0);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPanel.Location = new System.Drawing.Point(353, 163);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.RowCount = 1;
            this.MenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.MenuPanel.Size = new System.Drawing.Size(728, 221);
            this.MenuPanel.TabIndex = 16;
            this.MenuPanel.Visible = false;
            // 
            // DeleteTestButton
            // 
            this.DeleteTestButton.BackColor = System.Drawing.Color.White;
            this.DeleteTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteTestButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.DeleteTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTestButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteTestButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteTestButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteTestButton.Location = new System.Drawing.Point(1, 1);
            this.DeleteTestButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteTestButton.Name = "DeleteTestButton";
            this.DeleteTestButton.Size = new System.Drawing.Size(180, 281);
            this.DeleteTestButton.TabIndex = 10;
            this.DeleteTestButton.Text = "-";
            this.DeleteTestButton.UseVisualStyleBackColor = false;
            this.DeleteTestButton.Click += new System.EventHandler(this.DeleteTest_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.AliceBlue;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(182, 1);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(180, 281);
            this.Start.TabIndex = 9;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.OpenTest);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(363, 1);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(180, 281);
            this.Settings.TabIndex = 1;
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // CancelMenu
            // 
            this.CancelMenu.AutoSize = true;
            this.CancelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CancelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelMenu.ForeColor = System.Drawing.Color.Black;
            this.CancelMenu.Location = new System.Drawing.Point(544, 1);
            this.CancelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.CancelMenu.Name = "CancelMenu";
            this.CancelMenu.Size = new System.Drawing.Size(183, 281);
            this.CancelMenu.TabIndex = 11;
            this.CancelMenu.Text = "X";
            this.CancelMenu.UseVisualStyleBackColor = true;
            this.CancelMenu.Click += new System.EventHandler(this.CancelMenu_Click);
            // 
            // TestTable
            // 
            this.TestTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TestTable.ColumnCount = 1;
            this.TestTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TestTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestTable.ForeColor = System.Drawing.Color.White;
            this.TestTable.Location = new System.Drawing.Point(317, 0);
            this.TestTable.Margin = new System.Windows.Forms.Padding(0);
            this.TestTable.MinimumSize = new System.Drawing.Size(795, 561);
            this.TestTable.Name = "TestTable";
            this.TestTable.RowCount = 1;
            this.TestTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TestTable.Size = new System.Drawing.Size(817, 561);
            this.TestTable.TabIndex = 18;
            // 
            // LogoLable
            // 
            this.LogoLable.AutoSize = true;
            this.LogoLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoLable.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoLable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogoLable.Location = new System.Drawing.Point(3, 0);
            this.LogoLable.Name = "LogoLable";
            this.LogoLable.Size = new System.Drawing.Size(311, 85);
            this.LogoLable.TabIndex = 0;
            this.LogoLable.Text = "[LOGO]";
            this.LogoLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchPanel.Controls.Add(this.Search);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.SearchPanel.Location = new System.Drawing.Point(3, 88);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(311, 29);
            this.SearchPanel.TabIndex = 18;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(285, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(23, 23);
            this.Search.TabIndex = 19;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchTextBox.Location = new System.Drawing.Point(9, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(270, 23);
            this.SearchTextBox.TabIndex = 20;
            this.SearchTextBox.Text = "поиск";
            // 
            // BasisCollectionPanel
            // 
            this.BasisCollectionPanel.Controls.Add(this.CollectionScrollbar);
            this.BasisCollectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasisCollectionPanel.Location = new System.Drawing.Point(0, 153);
            this.BasisCollectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BasisCollectionPanel.Name = "BasisCollectionPanel";
            this.BasisCollectionPanel.Size = new System.Drawing.Size(317, 408);
            this.BasisCollectionPanel.TabIndex = 23;
            // 
            // CollectionScrollbar
            // 
            this.CollectionScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionScrollbar.AutoScroll = true;
            this.CollectionScrollbar.AutoSize = true;
            this.CollectionScrollbar.ChannelColor = System.Drawing.Color.White;
            this.CollectionScrollbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollectionScrollbar.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("CollectionScrollbar.DownArrowImage")));
            this.CollectionScrollbar.LargeChange = 5;
            this.CollectionScrollbar.Location = new System.Drawing.Point(300, 0);
            this.CollectionScrollbar.Margin = new System.Windows.Forms.Padding(0);
            this.CollectionScrollbar.Maximum = 100;
            this.CollectionScrollbar.Minimum = 0;
            this.CollectionScrollbar.MinimumSize = new System.Drawing.Size(15, 92);
            this.CollectionScrollbar.Name = "CollectionScrollbar";
            this.CollectionScrollbar.Size = new System.Drawing.Size(17, 408);
            this.CollectionScrollbar.SmallChange = 1;
            this.CollectionScrollbar.TabIndex = 23;
            this.CollectionScrollbar.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("CollectionScrollbar.ThumbMiddleImage")));
            this.CollectionScrollbar.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("CollectionScrollbar.UpArrowImage")));
            this.CollectionScrollbar.Value = 0;
            this.CollectionScrollbar.Visible = false;
            this.CollectionScrollbar.Scroll += new System.EventHandler(this.CollectionScrollbar_Scroll);
            // 
            // CollectionTable
            // 
            this.CollectionTable.AutoSize = true;
            this.CollectionTable.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CollectionTable.ColumnCount = 1;
            this.CollectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CollectionTable.Controls.Add(this.BasisCollectionPanel, 0, 3);
            this.CollectionTable.Controls.Add(this.SearchPanel, 0, 1);
            this.CollectionTable.Controls.Add(this.LogoLable, 0, 0);
            this.CollectionTable.Controls.Add(this.ButtonConrolsPanel, 0, 2);
            this.CollectionTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.CollectionTable.Location = new System.Drawing.Point(0, 0);
            this.CollectionTable.Name = "CollectionTable";
            this.CollectionTable.RowCount = 4;
            this.CollectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CollectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CollectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.CollectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.CollectionTable.Size = new System.Drawing.Size(317, 561);
            this.CollectionTable.TabIndex = 14;
            // 
            // ButtonConrolsPanel
            // 
            this.ButtonConrolsPanel.Controls.Add(this.AddBut);
            this.ButtonConrolsPanel.Controls.Add(this.DeleteBut);
            this.ButtonConrolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonConrolsPanel.Location = new System.Drawing.Point(0, 120);
            this.ButtonConrolsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonConrolsPanel.Name = "ButtonConrolsPanel";
            this.ButtonConrolsPanel.Size = new System.Drawing.Size(317, 33);
            this.ButtonConrolsPanel.TabIndex = 24;
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.White;
            this.AddBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBut.ForeColor = System.Drawing.Color.White;
            this.AddBut.Image = ((System.Drawing.Image)(resources.GetObject("AddBut.Image")));
            this.AddBut.Location = new System.Drawing.Point(0, 0);
            this.AddBut.Margin = new System.Windows.Forms.Padding(0);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(33, 33);
            this.AddBut.TabIndex = 0;
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddCollection_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.BackColor = System.Drawing.Color.White;
            this.DeleteBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBut.ForeColor = System.Drawing.Color.White;
            this.DeleteBut.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBut.Image")));
            this.DeleteBut.Location = new System.Drawing.Point(33, 0);
            this.DeleteBut.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(33, 33);
            this.DeleteBut.TabIndex = 1;
            this.DeleteBut.UseVisualStyleBackColor = false;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteCollection_Click);
            // 
            // ManagerTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.TestScrollbar);
            this.Controls.Add(this.TestTable);
            this.Controls.Add(this.CollectionTable);
            this.Controls.Add(this.MenuPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "ManagerTestsForm";
            this.Text = "ManagerTestsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerTestsForm_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.BasisCollectionPanel.ResumeLayout(false);
            this.BasisCollectionPanel.PerformLayout();
            this.CollectionTable.ResumeLayout(false);
            this.CollectionTable.PerformLayout();
            this.ButtonConrolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView testsPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteCollection;
        private System.Windows.Forms.Button DeleteTest;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MazayTests.Manager.CustomScrollbar TestScrollbar;
        private System.Windows.Forms.TableLayoutPanel TestTable;
        private System.Windows.Forms.TableLayoutPanel MenuPanel;
        private System.Windows.Forms.Button DeleteTestButton;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button CancelMenu;
        private System.Windows.Forms.TableLayoutPanel CollectionTable;
        private System.Windows.Forms.Panel BasisCollectionPanel;
        private MazayTests.Manager.CustomScrollbar CollectionScrollbar;
        private System.Windows.Forms.FlowLayoutPanel SearchPanel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label LogoLable;
        private System.Windows.Forms.FlowLayoutPanel ButtonConrolsPanel;
  
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button DeleteBut;
    }
}