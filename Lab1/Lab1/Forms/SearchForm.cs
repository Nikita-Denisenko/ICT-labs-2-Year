namespace Lab1.Forms
{
    public partial class SearchForm : Form
    {
        public string SearchText =>
            textBoxSearch.Text.Trim();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(
            object? sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                    SearchText))
            {
                MessageBox.Show(
                    "Enter text to search.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxSearch.Focus();

                return;
            }

            DialogResult =
                DialogResult.OK;

            Close();
        }

        private void buttonCancel_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }
    }
}