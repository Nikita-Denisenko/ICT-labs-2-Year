namespace Lab1.Forms
{
    partial class EventForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanel;
        private Label labelDate;
        private Label labelTime;
        private Label labelDescription;
        private Label labelCategory;
        private MonthCalendar monthCalendar;
        private DateTimePicker dateTimePickerTime;
        private TextBox textBoxDescription;
        private ComboBox comboBoxCategory;
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
            labelDate = new Label();
            monthCalendar = new MonthCalendar();
            labelTime = new Label();
            dateTimePickerTime = new DateTimePicker();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
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
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelDate, 0, 0);
            tableLayoutPanel.Controls.Add(monthCalendar, 1, 0);
            tableLayoutPanel.Controls.Add(labelTime, 0, 1);
            tableLayoutPanel.Controls.Add(dateTimePickerTime, 1, 1);
            tableLayoutPanel.Controls.Add(labelDescription, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 2);
            tableLayoutPanel.Controls.Add(labelCategory, 0, 3);
            tableLayoutPanel.Controls.Add(comboBoxCategory, 1, 3);
            tableLayoutPanel.Controls.Add(buttonPanel, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(600, 420);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Fill;
            labelDate.Location = new Point(23, 20);
            labelDate.Name = "labelDate";
            labelDate.Padding = new Padding(0, 5, 10, 0);
            labelDate.Size = new Size(114, 200);
            labelDate.TabIndex = 0;
            labelDate.Text = "Date:";
            labelDate.TextAlign = ContentAlignment.TopRight;
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(2, 1);
            monthCalendar.Dock = DockStyle.Fill;
            monthCalendar.Location = new Point(149, 29);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 1;
            // 
            // labelTime
            // 
            labelTime.Dock = DockStyle.Fill;
            labelTime.Location = new Point(23, 220);
            labelTime.Name = "labelTime";
            labelTime.Padding = new Padding(0, 0, 10, 0);
            labelTime.Size = new Size(114, 45);
            labelTime.TabIndex = 2;
            labelTime.Text = "Time:";
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Dock = DockStyle.Fill;
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(143, 223);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(434, 23);
            dateTimePickerTime.TabIndex = 3;
            // 
            // labelDescription
            // 
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Location = new Point(23, 265);
            labelDescription.Name = "labelDescription";
            labelDescription.Padding = new Padding(0, 0, 10, 0);
            labelDescription.Size = new Size(114, 45);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description:";
            labelDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(143, 268);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(434, 23);
            textBoxDescription.TabIndex = 5;
            // 
            // labelCategory
            // 
            labelCategory.Dock = DockStyle.Fill;
            labelCategory.Location = new Point(23, 310);
            labelCategory.Name = "labelCategory";
            labelCategory.Padding = new Padding(0, 0, 10, 0);
            labelCategory.Size = new Size(114, 45);
            labelCategory.TabIndex = 6;
            labelCategory.Text = "Category:";
            labelCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Dock = DockStyle.Fill;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Location = new Point(143, 313);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(434, 23);
            comboBoxCategory.TabIndex = 7;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(buttonCancel);
            buttonPanel.Controls.Add(buttonOk);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonPanel.Location = new Point(143, 358);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(434, 39);
            buttonPanel.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(331, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 35);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(225, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 35);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // EventForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(600, 420);
            Controls.Add(tableLayoutPanel);
            MinimumSize = new Size(550, 400);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add event";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}