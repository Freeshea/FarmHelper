using FarmHelper.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FarmHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FarmViewModel farmViewModel = new FarmViewModel();
            this.DataContext = farmViewModel;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            string currentText = textBox.Text;

            Regex regex = new Regex("[^0-9.]+"); // Only numbers and '.'

            if(e.Text == "." && currentText.Contains('.'))
            {
                e.Handled = true; // Only one '.'
            }
            else
            {
                e.Handled = regex.IsMatch(e.Text);
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                e.Handled = true; // Prevent space character
            }
        }
    }
}