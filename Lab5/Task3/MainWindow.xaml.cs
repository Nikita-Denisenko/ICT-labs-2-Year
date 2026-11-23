using System.Globalization;
using System.Windows;

namespace WpfLab
{
    public partial class MainWindow : Window
    {
        private const decimal EuroRate = 100m;
        private const decimal DollarRate = 90m;
        private const decimal HryvniaRate = 2.5m;

        public MainWindow()
        {
            InitializeComponent();
            UpdateRateInfo();
        }

        private void CurrencyRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded)
                return;

            UpdateRateInfo();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (!TryParseAmount(AmountTextBox.Text, out var amount) || amount < 0)
            {
                MessageBox.Show(
                    "Введите корректную неотрицательную сумму.",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            var (rate, currency) = GetSelectedCurrency();
            var result = amount / rate;

            ResultTextBlock.Text = $"{result:N2} {currency}";
        }

        private void UpdateRateInfo()
        {
            var (rate, currency) = GetSelectedCurrency();

            RateInfoTextBlock.Text = $"Учебный курс: 1 {currency} = {rate} RUB";
        }

        private (decimal Rate, string Currency) GetSelectedCurrency()
        {
            if (EuroRadioButton.IsChecked == true)
                return (EuroRate, "EUR");

            if (DollarRadioButton.IsChecked == true)
                return (DollarRate, "USD");

            return (HryvniaRate, "UAH");
        }

        private static bool TryParseAmount(string value, out decimal amount)
        {
            return decimal.TryParse(
                       value,
                       NumberStyles.Number,
                       CultureInfo.CurrentCulture,
                       out amount)
                   || decimal.TryParse(
                       value,
                       NumberStyles.Number,
                       CultureInfo.InvariantCulture,
                       out amount);
        }
    }
}
