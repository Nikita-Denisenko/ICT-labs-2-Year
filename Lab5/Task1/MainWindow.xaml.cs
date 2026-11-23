using System;
using System.Text;
using System.Windows;

namespace WpfLab
{
    public partial class MainWindow : Window
    {
        private const int Rows = 5;
        private const int Columns = 7;

        private readonly Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            int[,] matrix = new int[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = _random.Next(-20, 101);
                }
            }

            // Сохранение исходной матрицы
            OriginalMatrixTextBox.Text = PrintMatrix(matrix);

            for (int i = 0; i < Rows; i++)
            {
                int minIndex = 0;

                for (int j = 1; j < Columns; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }

                matrix[i, minIndex] = 50;
            }

            ResultMatrixTextBox.Text = PrintMatrix(matrix);
        }

        private string PrintMatrix(int[,] matrix)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result.Append($"{matrix[i, j],5}");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
