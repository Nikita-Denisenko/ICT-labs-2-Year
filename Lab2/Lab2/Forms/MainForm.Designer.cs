namespace Lab2.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer? components = null;

        private MenuStrip menuStrip;
        private ToolStrip toolStrip;

        private SplitContainer mainSplitContainer;
        private SplitContainer rightSplitContainer;

        private TreeView treeViewDirectories;
        private ListView listViewFiles;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFiles;

        private StatusStrip statusStrip;

        private ToolStripStatusLabel toolStripStatusLabelSize;
        private ToolStripStatusLabel toolStripStatusLabelSelected;

        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuExit;

        private ToolStripMenuItem menuSettings;
        private ToolStripMenuItem menuFont;
        private ToolStripMenuItem menuColor;

        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuAbout;

        private ToolStripButton toolOpen;
        private ToolStripButton toolSave;
        private ToolStripButton toolExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuSettings = new ToolStripMenuItem();
            menuFont = new ToolStripMenuItem();
            menuColor = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();

            toolStrip = new ToolStrip();
            toolOpen = new ToolStripButton();
            toolSave = new ToolStripButton();
            toolExit = new ToolStripButton();

            mainSplitContainer = new SplitContainer();
            treeViewDirectories = new TreeView();

            rightSplitContainer = new SplitContainer();
            listViewFiles = new ListView();

            chartFiles =
                new System.Windows.Forms.DataVisualization.Charting.Chart();

            statusStrip = new StatusStrip();
            toolStripStatusLabelSize = new ToolStripStatusLabel();
            toolStripStatusLabelSelected = new ToolStripStatusLabel();

            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)rightSplitContainer).BeginInit();
            rightSplitContainer.Panel1.SuspendLayout();
            rightSplitContainer.Panel2.SuspendLayout();
            rightSplitContainer.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)chartFiles).BeginInit();

            statusStrip.SuspendLayout();
            SuspendLayout();

            // menuStrip
            menuStrip.Items.AddRange(
                new ToolStripItem[]
                {
                    menuFile,
                    menuSettings,
                    menuHelp
                });

            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1200, 24);
            menuStrip.TabIndex = 3;

            // menuFile
            menuFile.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    menuOpen,
                    menuSave,
                    menuExit
                });

            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";

            // menuOpen
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(112, 22);
            menuOpen.Text = "Open...";

            // menuSave
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(112, 22);
            menuSave.Text = "Save...";

            // menuExit
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(112, 22);
            menuExit.Text = "Exit";

            // menuSettings
            menuSettings.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    menuFont,
                    menuColor
                });

            menuSettings.Name = "menuSettings";
            menuSettings.Size = new Size(61, 20);
            menuSettings.Text = "Settings";

            // menuFont
            menuFont.Name = "menuFont";
            menuFont.Size = new Size(112, 22);
            menuFont.Text = "Font...";

            // menuColor
            menuColor.Name = "menuColor";
            menuColor.Size = new Size(112, 22);
            menuColor.Text = "Color...";

            // menuHelp
            menuHelp.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    menuAbout
                });

            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 20);
            menuHelp.Text = "Help";

            // menuAbout
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(100, 22);
            menuAbout.Text = "About";

            // toolStrip
            toolStrip.Items.AddRange(
                new ToolStripItem[]
                {
                    toolOpen,
                    toolSave,
                    toolExit
                });

            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1200, 25);
            toolStrip.TabIndex = 2;

            // toolOpen
            toolOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(40, 22);
            toolOpen.Text = "Open";
            toolOpen.ToolTipText = "Открыть директорию";

            // toolSave
            toolSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(35, 22);
            toolSave.Text = "Save";
            toolSave.ToolTipText = "Сохранить структуру директории";

            // toolExit
            toolExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolExit.Name = "toolExit";
            toolExit.Size = new Size(29, 22);
            toolExit.Text = "Exit";
            toolExit.ToolTipText = "Выход";

            // mainSplitContainer
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 49);
            mainSplitContainer.Name = "mainSplitContainer";
            mainSplitContainer.Orientation = Orientation.Vertical;

            // mainSplitContainer.Panel1
            mainSplitContainer.Panel1.Controls.Add(
                treeViewDirectories);

            mainSplitContainer.Panel1MinSize = 220;

            // mainSplitContainer.Panel2
            mainSplitContainer.Panel2.Controls.Add(
                rightSplitContainer);

            mainSplitContainer.Panel2MinSize = 500;

            mainSplitContainer.Size = new Size(1200, 729);
            mainSplitContainer.SplitterDistance = 350;
            mainSplitContainer.SplitterWidth = 6;
            mainSplitContainer.TabIndex = 0;

            // treeViewDirectories
            treeViewDirectories.Dock = DockStyle.Fill;
            treeViewDirectories.HideSelection = false;
            treeViewDirectories.Location = new Point(0, 0);
            treeViewDirectories.Name = "treeViewDirectories";
            treeViewDirectories.Size = new Size(350, 729);
            treeViewDirectories.TabIndex = 0;

            // rightSplitContainer
            rightSplitContainer.Dock = DockStyle.Fill;
            rightSplitContainer.Location = new Point(0, 0);
            rightSplitContainer.Name = "rightSplitContainer";
            rightSplitContainer.Orientation = Orientation.Horizontal;

            // rightSplitContainer.Panel1
            rightSplitContainer.Panel1.Controls.Add(
                listViewFiles);

            rightSplitContainer.Panel1MinSize = 180;

            // rightSplitContainer.Panel2
            rightSplitContainer.Panel2.Controls.Add(
                chartFiles);

            rightSplitContainer.Panel2MinSize = 250;

            rightSplitContainer.Size = new Size(844, 729);
            rightSplitContainer.SplitterDistance = 400;
            rightSplitContainer.SplitterWidth = 6;
            rightSplitContainer.TabIndex = 0;

            // listViewFiles
            listViewFiles.Dock = DockStyle.Fill;
            listViewFiles.Location = new Point(0, 0);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(844, 400);
            listViewFiles.TabIndex = 0;
            listViewFiles.UseCompatibleStateImageBehavior = false;

            // chartFiles
            chartFiles.Dock = DockStyle.Fill;
            chartFiles.Location = new Point(0, 0);
            chartFiles.Name = "chartFiles";
            chartFiles.Size = new Size(844, 323);
            chartFiles.TabIndex = 0;

            // statusStrip
            statusStrip.Items.AddRange(
                new ToolStripItem[]
                {
                    toolStripStatusLabelSize,
                    toolStripStatusLabelSelected
                });

            statusStrip.Dock = DockStyle.Bottom;
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1200, 22);
            statusStrip.TabIndex = 1;

            // toolStripStatusLabelSize
            toolStripStatusLabelSize.Name =
                "toolStripStatusLabelSize";

            toolStripStatusLabelSize.Size =
                new Size(592, 17);

            toolStripStatusLabelSize.Spring = true;

            toolStripStatusLabelSize.Text =
                "Общий размер: 0 Б";

            toolStripStatusLabelSize.TextAlign =
                ContentAlignment.MiddleLeft;

            // toolStripStatusLabelSelected
            toolStripStatusLabelSelected.Name =
                "toolStripStatusLabelSelected";

            toolStripStatusLabelSelected.Size =
                new Size(592, 17);

            toolStripStatusLabelSelected.Spring = true;

            toolStripStatusLabelSelected.Text =
                "Выбрано файлов: 0 из 0";

            toolStripStatusLabelSelected.TextAlign =
                ContentAlignment.MiddleRight;

            // MainForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1200, 800);

            Controls.Add(mainSplitContainer);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);

            MainMenuStrip = menuStrip;

            MinimumSize = new Size(900, 650);

            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обозреватель директорий";

            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();

            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();

            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                mainSplitContainer).EndInit();

            mainSplitContainer.ResumeLayout(false);

            rightSplitContainer.Panel1.ResumeLayout(false);
            rightSplitContainer.Panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                rightSplitContainer).EndInit();

            rightSplitContainer.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                chartFiles).EndInit();

            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
