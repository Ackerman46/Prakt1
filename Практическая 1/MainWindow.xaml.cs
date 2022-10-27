using System.Windows;
using System.Windows.Controls;
using Lib_12;

namespace Prakt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            userN.Focus();
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TaskApp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Агеев ИСП-31\nВариант 12\nЗадание: Найти сумму n целых, случайных чисел, распределенных в диапазоне от 0 до n.\nВывести на экран на одной строке сгенерированные числа, на другой строке результат");
        }

        private void userN_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (userN.Text != "")
            {
                int.TryParse(userN.Text, out int n);
                resultBox.Text = $"Сумма: {LibArr.SumOfNumbers(out string genNumbers, n)}\n" + genNumbers;
            }
            else
            {
                resultBox.Clear();
            }
        }
    }
}
