using Lab1.Models;
using Lab1.Services;

namespace Lab1.Forms
{
    public partial class OrganizerForm : Form
    {
        private readonly OrganizerService _organizerService;
        private readonly FileService _fileService;

        private OrganizerEvent? _selectedEvent;
        private EventCategory? _selectedCategory;
        private string? _searchText;

        private bool _sortAscending = true;

        public OrganizerForm()
        {
            InitializeComponent();

            _organizerService = new OrganizerService();
            _fileService = new FileService();

            _fileService.EnsureDefaultFileExists();

            LoadDefaultData();

            InitializeCategories();
            InitializeContextMenu();
            InitializeIcons();
            CreateAddButton();

            KeyPreview = true;
            KeyDown += OrganizerForm_KeyDown;

            UpdateSortButton();
            UpdateSearchButton();
            UpdateList();
        }

        private void LoadDefaultData()
        {
            try
            {
                List<OrganizerEvent> events =
                    _fileService.Load(
                        _fileService.DefaultFilePath);

                foreach (OrganizerEvent organizerEvent in events)
                {
                    _organizerService.Add(organizerEvent);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"Error while loading data:\n{exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InitializeCategories()
        {
            comboBoxCategory.Items.Clear();

            comboBoxCategory.Items.Add("All");
            comboBoxCategory.Items.Add(EventCategory.Memo);
            comboBoxCategory.Items.Add(EventCategory.Meeting);
            comboBoxCategory.Items.Add(EventCategory.Task);

            comboBoxCategory.SelectedIndex = 0;
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem editItem =
                new ToolStripMenuItem("Edit");

            ToolStripMenuItem removeItem =
                new ToolStripMenuItem("Remove");

            editItem.Click += EditSelectedEvent;
            removeItem.Click += RemoveSelectedEvent;

            contextMenuStrip.Items.Add(editItem);
            contextMenuStrip.Items.Add(removeItem);

            listViewEvents.ContextMenuStrip = contextMenuStrip;
        }

        private void InitializeIcons()
        {
            imageList = new ImageList
            {
                ImageSize = new Size(24, 24),
                ColorDepth = ColorDepth.Depth32Bit,
                TransparentColor = Color.Transparent
            };

            imageList.Images.Add(
                "Memo",
                CreateCategoryIcon(Color.SteelBlue));

            imageList.Images.Add(
                "Meeting",
                CreateCategoryIcon(Color.SeaGreen));

            imageList.Images.Add(
                "Task",
                CreateCategoryIcon(Color.DarkOrange));

            listViewEvents.SmallImageList = imageList;
        }

        private Bitmap CreateCategoryIcon(Color color)
        {
            Bitmap bitmap = new Bitmap(24, 24);

            using Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Transparent);

            using SolidBrush brush = new SolidBrush(color);

            graphics.FillRoundedRectangle(
                brush,
                2,
                2,
                20,
                20,
                5);

            using Pen pen = new Pen(
                Color.White,
                2);

            graphics.DrawLine(
                pen,
                7,
                8,
                17,
                8);

            graphics.DrawLine(
                pen,
                7,
                12,
                17,
                12);

            graphics.DrawLine(
                pen,
                7,
                16,
                14,
                16);

            return bitmap;
        }

        private void CreateAddButton()
        {
            Button buttonAdd =
                new Button
                {
                    Name = "buttonAddProgrammatically",
                    Text = "Add",
                    Width = 110,
                    Height = 40,
                    Margin = new Padding(8, 4, 0, 4),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(45, 125, 210),
                    ForeColor = Color.White,
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Anchor = AnchorStyles.Right
                };

            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.Click += AddEvent;

            flowLayoutPanelBottom.Controls.Add(buttonAdd);

            flowLayoutPanelBottom.Controls.SetChildIndex(
                buttonAdd,
                0);
        }

        private void AddEvent(
            object? sender,
            EventArgs e)
        {
            using EventForm eventForm = new EventForm();

            if (eventForm.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (eventForm.Result == null)
            {
                return;
            }

            _organizerService.Add(eventForm.Result);

            SaveDefaultData();
            UpdateList();
        }

        private void EditSelectedEvent(
            object? sender,
            EventArgs e)
        {
            if (_selectedEvent == null)
            {
                return;
            }

            OrganizerEvent oldEvent = _selectedEvent;

            using EventForm eventForm =
                new EventForm(oldEvent);

            if (eventForm.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (eventForm.Result == null)
            {
                return;
            }

            _organizerService.Remove(oldEvent);
            _organizerService.Add(eventForm.Result);

            _selectedEvent = eventForm.Result;

            SaveDefaultData();
            UpdateList();
        }

        private void RemoveSelectedEvent(
            object? sender,
            EventArgs e)
        {
            if (_selectedEvent == null)
            {
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    $"Are you sure you want to delete the record " +
                    $"<{_selectedEvent.Date:dd.MM.yyyy} / " +
                    $"{_selectedEvent.Time:hh\\:mm} / " +
                    $"{_selectedEvent.Description}>?",
                    "Delete record",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            _organizerService.Remove(_selectedEvent);

            _selectedEvent = null;

            SaveDefaultData();
            UpdateList();
        }

        private void listViewEvents_MouseDown(
            object? sender,
            MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            ListViewHitTestInfo hit =
                listViewEvents.HitTest(e.Location);

            if (hit.Item == null)
            {
                _selectedEvent = null;
                return;
            }

            listViewEvents.SelectedItems.Clear();
            hit.Item.Selected = true;

            _selectedEvent =
                hit.Item.Tag as OrganizerEvent;
        }

        private void listViewEvents_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0)
            {
                _selectedEvent = null;
                return;
            }

            _selectedEvent =
                listViewEvents
                    .SelectedItems[0]
                    .Tag as OrganizerEvent;
        }

        private void comboBoxCategory_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex <= 0)
            {
                _selectedCategory = null;
                labelFilter.Text = "All events";
            }
            else
            {
                _selectedCategory =
                    (EventCategory)
                    comboBoxCategory.SelectedItem!;

                labelFilter.Text =
                    $"{_selectedCategory} events";
            }

            UpdateList();
        }

        private void buttonFind_Click(
            object? sender,
            EventArgs e)
        {
            using SearchForm searchForm =
                new SearchForm();

            if (searchForm.ShowDialog(this) !=
                DialogResult.OK)
            {
                return;
            }

            string searchText =
                searchForm.SearchText.Trim();

            _searchText =
                string.IsNullOrWhiteSpace(searchText)
                    ? null
                    : searchText;

            UpdateSearchButton();
            UpdateList();
        }

        private void buttonClearSearch_Click(
            object? sender,
            EventArgs e)
        {
            _searchText = null;

            UpdateSearchButton();
            UpdateList();
        }

        private void buttonSort_Click(
            object? sender,
            EventArgs e)
        {
            _sortAscending = !_sortAscending;

            UpdateSortButton();
            UpdateList();
        }

        private void UpdateSortButton()
        {
            buttonSort.Text =
                _sortAscending
                    ? "Time ↑"
                    : "Time ↓";

            buttonSort.AccessibleName =
                _sortAscending
                    ? "Sort by time ascending"
                    : "Sort by time descending";
        }

        private void UpdateSearchButton()
        {
            bool hasSearch =
                !string.IsNullOrWhiteSpace(_searchText);

            buttonClearSearch.Visible = hasSearch;

            if (hasSearch)
            {
                labelSearch.Text =
                    $"Search: \"{_searchText}\"";
            }
            else
            {
                labelSearch.Text = "No search";
            }
        }

        private void UpdateList()
        {
            listViewEvents.BeginUpdate();

            try
            {
                listViewEvents.Items.Clear();

                List<OrganizerEvent> events =
                    _organizerService.GetEvents(
                        _selectedCategory,
                        _searchText,
                        _sortAscending);

                foreach (OrganizerEvent organizerEvent in events)
                {
                    ListViewItem item =
                        new ListViewItem(
                            organizerEvent.Date.ToString(
                                "dd.MM.yyyy"));

                    item.SubItems.Add(
                        organizerEvent.Time.ToString(
                            @"hh\:mm"));

                    item.SubItems.Add(
                        organizerEvent.Description);

                    item.SubItems.Add(
                        organizerEvent.Category
                            .ToString()
                            .ToLower());

                    item.Tag = organizerEvent;

                    item.ImageKey =
                        organizerEvent.Category
                            .ToString();

                    listViewEvents.Items.Add(item);
                }

                labelCount.Text =
                    $"Events: {events.Count}";
            }
            finally
            {
                listViewEvents.EndUpdate();
            }
        }

        private void OrganizerForm_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveEvents();

                e.SuppressKeyPress = true;
                return;
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                OpenEvents();

                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectedEvent(
                    this,
                    EventArgs.Empty);

                e.SuppressKeyPress = true;
            }
        }

        private void SaveEvents()
        {
            using SaveFileDialog dialog =
                new SaveFileDialog
                {
                    Filter =
                        "JSON files (*.json)|*.json|" +
                        "All files (*.*)|*.*",

                    DefaultExt = "json",

                    FileName = "organizer.json"
                };

            if (dialog.ShowDialog(this) !=
                DialogResult.OK)
            {
                return;
            }

            try
            {
                _fileService.Save(
                    dialog.FileName,
                    _organizerService.Events);

                MessageBox.Show(
                    "Events saved successfully.",
                    "Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"Error while saving file:\n{exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OpenEvents()
        {
            using OpenFileDialog dialog =
                new OpenFileDialog
                {
                    Filter =
                        "JSON files (*.json)|*.json|" +
                        "All files (*.*)|*.*"
                };

            if (dialog.ShowDialog(this) !=
                DialogResult.OK)
            {
                return;
            }

            try
            {
                List<OrganizerEvent> events =
                    _fileService.Load(dialog.FileName);

                _organizerService.Clear();

                foreach (OrganizerEvent organizerEvent in events)
                {
                    _organizerService.Add(organizerEvent);
                }

                _selectedEvent = null;
                _searchText = null;

                UpdateSearchButton();
                UpdateList();

                MessageBox.Show(
                    "Events loaded successfully.",
                    "Open",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"Error while opening file:\n{exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveDefaultData()
        {
            try
            {
                _fileService.Save(
                    _fileService.DefaultFilePath,
                    _organizerService.Events);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"Error while saving application data:\n{exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OrganizerForm_Load(
            object sender,
            EventArgs e)
        {
        }
    }

    internal static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(
            this Graphics graphics,
            Brush brush,
            int x,
            int y,
            int width,
            int height,
            int radius)
        {
            using System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(
                x,
                y,
                radius,
                radius,
                180,
                90);

            path.AddArc(
                x + width - radius,
                y,
                radius,
                radius,
                270,
                90);

            path.AddArc(
                x + width - radius,
                y + height - radius,
                radius,
                radius,
                0,
                90);

            path.AddArc(
                x,
                y + height - radius,
                radius,
                radius,
                90,
                90);

            path.CloseFigure();

            graphics.FillPath(brush, path);
        }
    }
}