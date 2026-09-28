namespace Lab1.Forms
{
    partial class OrganizerForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private FlowLayoutPanel topPanel;
        private FlowLayoutPanel flowLayoutPanelBottom;

        private Label labelFilter;
        private ComboBox comboBoxCategory;

        private Label labelSearch;

        private ListView listViewEvents;
        private ColumnHeader columnDate;
        private ColumnHeader columnTime;
        private ColumnHeader columnDescription;
        private ColumnHeader columnCategory;

        private Button buttonFind;
        private Button buttonClearSearch;
        private Button buttonSort;

        private Label labelCount;

        private ContextMenuStrip contextMenuStrip;
        private ImageList imageList;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainLayout = new TableLayoutPanel();
            topPanel = new FlowLayoutPanel();
            labelFilter = new Label();
            comboBoxCategory = new ComboBox();
            labelSearch = new Label();
            listViewEvents = new ListView();
            columnDate = new ColumnHeader();
            columnTime = new ColumnHeader();
            columnDescription = new ColumnHeader();
            columnCategory = new ColumnHeader();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonSort = new Button();
            buttonClearSearch = new Button();
            buttonFind = new Button();
            labelCount = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            imageList = new ImageList(components);
            mainLayout.SuspendLayout();
            topPanel.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(topPanel, 0, 0);
            mainLayout.Controls.Add(listViewEvents, 0, 1);
            mainLayout.Controls.Add(flowLayoutPanelBottom, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(14);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            mainLayout.Size = new Size(1000, 650);
            mainLayout.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(labelFilter);
            topPanel.Controls.Add(comboBoxCategory);
            topPanel.Controls.Add(labelSearch);
            topPanel.Dock = DockStyle.Fill;
            topPanel.Location = new Point(17, 17);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(5);
            topPanel.Size = new Size(966, 46);
            topPanel.TabIndex = 0;
            topPanel.WrapContents = false;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelFilter.Location = new Point(10, 16);
            labelFilter.Margin = new Padding(5, 11, 8, 0);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(72, 19);
            labelFilter.TabIndex = 0;
            labelFilter.Text = "Category";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(90, 11);
            comboBoxCategory.Margin = new Padding(0, 6, 20, 0);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 25);
            comboBoxCategory.TabIndex = 1;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelSearch.ForeColor = Color.DimGray;
            labelSearch.Location = new Point(265, 17);
            labelSearch.Margin = new Padding(5, 12, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(59, 15);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "No search";
            // 
            // listViewEvents
            // 
            listViewEvents.BackColor = Color.White;
            listViewEvents.BorderStyle = BorderStyle.FixedSingle;
            listViewEvents.Columns.AddRange(new ColumnHeader[] { columnDate, columnTime, columnDescription, columnCategory });
            listViewEvents.Dock = DockStyle.Fill;
            listViewEvents.Font = new Font("Segoe UI", 10F);
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;
            listViewEvents.Location = new Point(17, 69);
            listViewEvents.MultiSelect = false;
            listViewEvents.Name = "listViewEvents";
            listViewEvents.ShowItemToolTips = true;
            listViewEvents.Size = new Size(966, 506);
            listViewEvents.TabIndex = 2;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.View = View.Details;
            listViewEvents.SelectedIndexChanged += listViewEvents_SelectedIndexChanged;
            listViewEvents.MouseDown += listViewEvents_MouseDown;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 130;
            // 
            // columnTime
            // 
            columnTime.Text = "Time";
            columnTime.Width = 100;
            // 
            // columnDescription
            // 
            columnDescription.Text = "Description";
            columnDescription.Width = 480;
            // 
            // columnCategory
            // 
            columnCategory.Text = "Category";
            columnCategory.Width = 130;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(buttonSort);
            flowLayoutPanelBottom.Controls.Add(buttonClearSearch);
            flowLayoutPanelBottom.Controls.Add(buttonFind);
            flowLayoutPanelBottom.Controls.Add(labelCount);
            flowLayoutPanelBottom.Dock = DockStyle.Fill;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(17, 581);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(5);
            flowLayoutPanelBottom.Size = new Size(966, 52);
            flowLayoutPanelBottom.TabIndex = 3;
            flowLayoutPanelBottom.WrapContents = false;
            // 
            // buttonSort
            // 
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSort.Location = new Point(846, 9);
            buttonSort.Margin = new Padding(6, 4, 0, 4);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(110, 40);
            buttonSort.TabIndex = 0;
            buttonSort.Text = "Time ↑";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonClearSearch
            // 
            buttonClearSearch.FlatStyle = FlatStyle.Flat;
            buttonClearSearch.Location = new Point(725, 9);
            buttonClearSearch.Margin = new Padding(6, 4, 0, 4);
            buttonClearSearch.Name = "buttonClearSearch";
            buttonClearSearch.Size = new Size(115, 40);
            buttonClearSearch.TabIndex = 1;
            buttonClearSearch.Text = "Clear search";
            buttonClearSearch.Visible = false;
            buttonClearSearch.Click += buttonClearSearch_Click;
            // 
            // buttonFind
            // 
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Location = new Point(609, 9);
            buttonFind.Margin = new Padding(6, 4, 0, 4);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(110, 40);
            buttonFind.TabIndex = 2;
            buttonFind.Text = "Find";
            buttonFind.Click += buttonFind_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.DimGray;
            labelCount.Location = new Point(546, 19);
            labelCount.Margin = new Padding(15, 14, 0, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(57, 15);
            labelCount.TabIndex = 3;
            labelCount.Text = "Events: 0";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(61, 4);
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(24, 24);
            imageList.TransparentColor = Color.Transparent;
            // 
            // OrganizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1000, 650);
            Controls.Add(mainLayout);
            KeyPreview = true;
            MinimumSize = new Size(750, 500);
            Name = "OrganizerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizer";
            Load += OrganizerForm_Load;
            mainLayout.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }
    }
}