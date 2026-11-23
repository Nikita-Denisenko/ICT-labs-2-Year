using System;
using System.Globalization;
using System.Windows;

namespace WpfLab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            var culture = CultureInfo.CurrentCulture;

            if (!decimal.TryParse(AmountTextBox.Text, NumberStyles.Number, culture, out decimal amount) &&
                !decimal.TryParse(AmountTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out amount))
            {
                MessageBox.Show("Введите корректную сумму в рублях.", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!decimal.TryParse(RateTextBox.Text, NumberStyles.Number, culture, out decimal rate) &&
                !decimal.TryParse(RateTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out rate))
            {
                MessageBox.Show("Введите корректный курс доллара.", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (amount < 0 || rate <= 0)
            {
                MessageBox.Show("Сумма не может быть отрицательной, а курс должен быть больше нуля.",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            decimal result = amount / rate;

            ResultTextBlock.Text = $"{result:N2} USD";
        }
    }
}
