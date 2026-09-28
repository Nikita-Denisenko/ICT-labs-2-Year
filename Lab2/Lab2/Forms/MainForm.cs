using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using Lab2.Models;
using Lab2.Services;

namespace Lab2.Forms
{
    public partial class MainForm : Form
    {
        private readonly FileSystemService _fileSystemService;
        private readonly TreeTextService _treeTextService;

        private string? _currentDirectory;
        private List<FileItem> _currentFiles = new();

        private readonly Color _imageFileColor = Color.LightGreen;
        private readonly Color _officeFileColor = Color.LightBlue;
        private readonly Color _archiveFileColor = Color.Khaki;
        private readonly Color _executableFileColor = Color.Plum;

        public MainForm()
        {
            InitializeComponent();

            _fileSystemService = new FileSystemService();
            _treeTextService = new TreeTextService();

            ConfigureListView();
            ConfigureChart();
            ConfigureEvents();
        }

        private void ConfigureListView()
        {
            listViewFiles.View = View.Details;
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.CheckBoxes = true;
            listViewFiles.MultiSelect = true;

            listViewFiles.Columns.Clear();

            listViewFiles.Columns.Add(
                "Имя",
                240);

            listViewFiles.Columns.Add(
                "Размер",
                110);

            listViewFiles.Columns.Add(
                "Тип",
                120);

            listViewFiles.Columns.Add(
                "Путь",
                450);
        }

        private void ConfigureChart()
        {
            chartFiles.Series.Clear();
            chartFiles.ChartAreas.Clear();
            chartFiles.Titles.Clear();

            var chartArea = new ChartArea("MainArea");

            chartArea.AxisX.Title = "Размер файла";
            chartArea.AxisY.Title = "Количество файлов";

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 1;

            chartFiles.ChartAreas.Add(chartArea);

            var series = new Series("Количество")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY("Малые", 0);
            series.Points.AddXY("Средние", 0);
            series.Points.AddXY("Большие", 0);

            chartFiles.Series.Add(series);

            chartFiles.Titles.Add(
                "Количество файлов по размеру");
        }

        private void ConfigureEvents()
        {
            treeViewDirectories.AfterSelect +=
                TreeViewDirectories_AfterSelect;

            listViewFiles.ItemChecked +=
                ListViewFiles_ItemChecked;

            menuOpen.Click +=
                MenuOpen_Click;

            menuSave.Click +=
                MenuSave_Click;

            menuExit.Click +=
                MenuExit_Click;

            menuFont.Click +=
                MenuFont_Click;

            menuColor.Click +=
                MenuColor_Click;

            menuAbout.Click +=
                MenuAbout_Click;

            toolOpen.Click +=
                MenuOpen_Click;

            toolSave.Click +=
                MenuSave_Click;

            toolExit.Click +=
                MenuExit_Click;
        }

        private void MenuOpen_Click(
            object? sender,
            EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            dialog.Description =
                "Выберите директорию для просмотра";

            dialog.UseDescriptionForTitle = true;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadDirectory(dialog.SelectedPath);
        }

        private void LoadDirectory(string directoryPath)
        {
            _currentDirectory = directoryPath;

            treeViewDirectories.BeginUpdate();

            try
            {
                treeViewDirectories.Nodes.Clear();

                TreeNode rootNode =
                    CreateDirectoryNode(directoryPath);

                treeViewDirectories.Nodes.Add(rootNode);

                rootNode.Expand();
            }
            finally
            {
                treeViewDirectories.EndUpdate();
            }

            ShowFiles(directoryPath);
        }

        private TreeNode CreateDirectoryNode(
            string directoryPath)
        {
            var directoryInfo =
                new DirectoryInfo(directoryPath);

            var node = new TreeNode(
                directoryInfo.Name);

            node.Tag = directoryPath;

            foreach (string directory in
                     _fileSystemService.GetDirectories(directoryPath))
            {
                node.Nodes.Add(
                    CreateDirectoryNode(directory));
            }

            foreach (FileItem file in
                     _fileSystemService.GetFiles(directoryPath))
            {
                var fileNode = new TreeNode(file.Name)
                {
                    Tag = file.FullPath
                };

                node.Nodes.Add(fileNode);
            }

            return node;
        }

        private void TreeViewDirectories_AfterSelect(
            object? sender,
            TreeViewEventArgs e)
        {
            if (e.Node.Tag is not string path)
            {
                return;
            }

            if (!Directory.Exists(path))
            {
                return;
            }

            ShowFiles(path);
        }

        private void ShowFiles(string directoryPath)
        {
            _currentFiles =
                _fileSystemService.GetFiles(directoryPath);

            listViewFiles.BeginUpdate();

            try
            {
                listViewFiles.Items.Clear();

                foreach (FileItem file in _currentFiles)
                {
                    var item = new ListViewItem(file.Name);

                    item.SubItems.Add(
                        _fileSystemService.FormatSize(file.Size));

                    item.SubItems.Add(
                        GetExtension(file.Name));

                    item.SubItems.Add(
                        file.FullPath);

                    item.Tag = file;

                    item.Checked = true;

                    ApplyFileColor(
                        item,
                        file);

                    listViewFiles.Items.Add(item);
                }
            }
            finally
            {
                listViewFiles.EndUpdate();
            }

            UpdateStatus(directoryPath);
            UpdateChart();
        }

        private static string GetExtension(string fileName)
        {
            string extension =
                Path.GetExtension(fileName);

            if (string.IsNullOrWhiteSpace(extension))
            {
                return "Без расширения";
            }

            return extension.ToLowerInvariant();
        }

        private void ApplyFileColor(
            ListViewItem item,
            FileItem file)
        {
            string extension =
                GetExtension(file.Name);

            if (extension is
                ".png" or
                ".jpg" or
                ".jpeg" or
                ".bmp" or
                ".gif")
            {
                item.BackColor = _imageFileColor;
                return;
            }

            if (extension is
                ".doc" or
                ".docx" or
                ".xls" or
                ".xlsx" or
                ".ppt" or
                ".pptx" or
                ".pdf" or
                ".txt")
            {
                item.BackColor = _officeFileColor;
                return;
            }

            if (extension is
                ".zip" or
                ".rar" or
                ".7z")
            {
                item.BackColor = _archiveFileColor;
                return;
            }

            if (extension is
                ".exe" or
                ".dll")
            {
                item.BackColor = _executableFileColor;
            }
        }

        private void ListViewFiles_ItemChecked(
            object? sender,
            ItemCheckedEventArgs e)
        {
            if (!IsHandleCreated)
            {
                return;
            }

            UpdateChart();
            UpdateSelectedStatus();
        }

        private void UpdateChart()
        {
            if (chartFiles.Series.Count == 0)
            {
                return;
            }

            int small = 0;
            int medium = 0;
            int large = 0;

            foreach (ListViewItem item in listViewFiles.Items)
            {
                if (!item.Checked)
                {
                    continue;
                }

                if (item.Tag is not FileItem file)
                {
                    continue;
                }

                switch (file.Category)
                {
                    case FileSizeCategory.Small:
                        small++;
                        break;

                    case FileSizeCategory.Medium:
                        medium++;
                        break;

                    case FileSizeCategory.Large:
                        large++;
                        break;
                }
            }

            Series series = chartFiles.Series[0];

            series.Points[0].YValues[0] = small;
            series.Points[1].YValues[0] = medium;
            series.Points[2].YValues[0] = large;

            chartFiles.Invalidate();
        }

        private void UpdateStatus(string directoryPath)
        {
            long totalSize =
                _fileSystemService.GetDirectorySize(
                    directoryPath);

            toolStripStatusLabelSize.Text =
                $"Общий размер: {_fileSystemService.FormatSize(totalSize)}";

            UpdateSelectedStatus();
        }

        private void UpdateSelectedStatus()
        {
            int selectedCount =
                listViewFiles.Items
                    .Cast<ListViewItem>()
                    .Count(item => item.Checked);

            int totalCount =
                listViewFiles.Items.Count;

            toolStripStatusLabelSelected.Text =
                $"Выбрано файлов: {selectedCount} из {totalCount}";
        }

        private void MenuSave_Click(
            object? sender,
            EventArgs e)
        {
            if (treeViewDirectories.Nodes.Count == 0)
            {
                MessageBox.Show(
                    "Сначала откройте директорию.",
                    "Сохранение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using var dialog = new SaveFileDialog();

            dialog.Title =
                "Сохранить структуру директории";

            dialog.Filter =
                "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            dialog.FileName =
                "directory_structure.txt";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string text =
                _treeTextService.BuildText(
                    treeViewDirectories.Nodes[0]);

            File.WriteAllText(
                dialog.FileName,
                text);

            MessageBox.Show(
                "Структура директории успешно сохранена.",
                "Сохранение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MenuFont_Click(
            object? sender,
            EventArgs e)
        {
            using var dialog = new FontDialog();

            dialog.Font =
                listViewFiles.Font;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            listViewFiles.Font =
                dialog.Font;
        }

        private void MenuColor_Click(
            object? sender,
            EventArgs e)
        {
            using var dialog = new ColorDialog();

            dialog.Color =
                listViewFiles.ForeColor;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            listViewFiles.ForeColor =
                dialog.Color;
        }

        private void MenuExit_Click(
            object? sender,
            EventArgs e)
        {
            Close();
        }

        private void MenuAbout_Click(
            object? sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Оконное приложение «Обозреватель директорий»\n\n" +
                "Лабораторная работа №2\n" +
                "Вариант 2\n\n" +
                "График: количество файлов в каждой группе по размеру.\n\n" +
                "Малые: менее 1 МБ\n" +
                "Средние: от 1 до 10 МБ\n" +
                "Большие: более 10 МБ",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}