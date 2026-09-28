namespace Lab1.Forms
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanel;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private FlowLayoutPanel buttonPanel;
        private Button buttonOk;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonPanel = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonOk = new Button();
            tableLayoutPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelSearch, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxSearch, 1, 0);
            tableLayoutPanel.Controls.Add(buttonPanel, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(500, 160);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.Dock = DockStyle.Fill;
            labelSearch.Location = new Point(23, 20);
            labelSearch.Name = "labelSearch";
            labelSearch.Padding = new Padding(0, 0, 10, 0);
            labelSearch.Size = new Size(94, 45);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Text:";
            labelSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Location = new Point(123, 23);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(354, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(buttonCancel);
            buttonPanel.Controls.Add(buttonOk);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonPanel.Location = new Point(123, 68);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(354, 69);
            buttonPanel.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(261, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 35);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(165, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(90, 35);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Find";
            buttonOk.Click += buttonOk_Click;
            // 
            // SearchForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(500, 160);
            Controls.Add(tableLayoutPanel);
            MinimumSize = new Size(400, 140);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find event";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
