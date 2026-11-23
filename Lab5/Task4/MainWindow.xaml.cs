using System.Windows;

namespace WpfLab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadTemperatureTable();
        }

        private void LoadTemperatureTable()
        {
            var temperatures = Enumerable
                .Range(0, 21)
                .Select(step => new TemperatureRow(
                    step * 5,
                    step * 5 * 1.8m + 32m))
                .ToList();

            TemperatureDataGrid.ItemsSource = temperatures;
        }

        private sealed record TemperatureRow(int Celsius, decimal Fahrenheit);
    }
}