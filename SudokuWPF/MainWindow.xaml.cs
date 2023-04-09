using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SudokuWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCellClick(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check if the TextBox is not null
            if (textBox != null)
            {
                // Set the text of the TextBox to some value, e.g. "1"
                textBox.Text = "1";
            }
        }

        private void TextBoxKeyboard(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}