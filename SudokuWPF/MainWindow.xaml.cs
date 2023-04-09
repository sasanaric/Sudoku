using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace SudokuWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int selectedCellRow;
        private int selectedCellColumn;
        private Random rand = new Random();
        // private int[,] firstSudokuArray = new int[9,9];
        private int[,] sudokuArray = new int[9,9];
        private int[,] solvedSudokuArray = new int[9,9];
        private int n=9;
        private int srn=3;
        private int k=40;
        private Stopwatch stopwatch = new Stopwatch();
        private DispatcherTimer timer = new DispatcherTimer();
        private int mistakes;
        private bool isGameSolved;
        private bool creatingGame;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnCellClick(object sender, RoutedEventArgs e)
        {
            TextBox lastTextBox = getTextBoxFromGrid(selectedCellRow, selectedCellColumn);
            lastTextBox.Background = Brushes.White;
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Background = Brushes.LightSkyBlue;
                Border border = (Border) textBox.Parent;
                selectedCellRow = Grid.GetRow(border);
                selectedCellColumn = Grid.GetColumn(border);
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox!=null){textBox.Text = "";
                if (char.IsDigit(e.Text, 0) && textBox.Text.Length >= 1)
                {
                    e.Handled = true;
                    return;
                }
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);}
        }
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                object a =button.Content;
                TextBox textBox = getTextBoxFromGrid(selectedCellRow, selectedCellColumn);
                textBox.Text = a.ToString();
                
            }
        }

        private void checkTextBox()
        {
            if (!creatingGame)
            {
                TextBox textBox = getTextBoxFromGrid(selectedCellRow, selectedCellColumn);
                if (textBox.Text != "")
                {
                    if (!isGameSolved && sudokuArray[selectedCellRow, selectedCellColumn] != solvedSudokuArray[selectedCellRow, selectedCellColumn])
                    {
                        textBox.Foreground = Brushes.Red;
                        mistakes++;
                        TextBlockMistakes.Text = $"{mistakes}/3";
                        if (mistakes == 3)
                        {
                            ButtonSolve.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                        }
                    }
                    else
                    {
                        textBox.Foreground = Brushes.Black;
                    }
                }
            }
            
        }
        private TextBox getTextBoxFromGrid(int row, int column)
        {
            Border cell = SudokuGrid.Children
                .OfType<Border>()
                .FirstOrDefault(b => Grid.GetRow(b) == row && Grid.GetColumn(b) == column);
            if(cell!=null)
            {
                TextBox textBox = (TextBox)cell.Child;
                return textBox;
            }

            return new TextBox();
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            ButtonNewGame.Focus();
            TextBox lastTextBox = getTextBoxFromGrid(selectedCellRow, selectedCellColumn);
            lastTextBox.Background = Brushes.White;
            creatingGame = true;
            // firstSudokuArray = new int[9, 9];
            sudokuArray = new int[9, 9];
            solvedSudokuArray = new int[9, 9];
            mistakes = 0;
            isGameSolved = false;
            TextBlockMistakes.Text = "0/3";
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    TextBox textBox = getTextBoxFromGrid(row, column);
                    textBox.Text = "";
                }
            }
            fillValues();
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (sudokuArray[row, column] != 0)
                    {
                        TextBox textBox = getTextBoxFromGrid(row, column);
                        textBox.Text = sudokuArray[row, column].ToString();
                    }
                }
            }
            stopwatch.Reset();
            stopwatch.Start();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            creatingGame = false;
        }

        private void SolveGame(object sender, RoutedEventArgs args)
        {
            isGameSolved = true;
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    TextBox textBox = getTextBoxFromGrid(row, column);
                    textBox.Text = solvedSudokuArray[row, column].ToString();
                    textBox.Foreground = Brushes.Black;
                }
            }
            stopwatch.Stop();
            timer.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            TextBlockTime.Text = string.Format("{0:00}:{1:00}", elapsedTime.Minutes, elapsedTime.Seconds);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text != "")
                {
                    int num = int.Parse(textBox.Text);
                    sudokuArray[selectedCellRow, selectedCellColumn] = num;
                    checkTextBox();
                }
            }
        }
        public void fillValues()
        {
            fillDiagonal();
            fillRemaining(0, srn);
            Array.Copy(sudokuArray,solvedSudokuArray,81);
            removeKDigits();
        }
    
        void fillDiagonal()
        {
            for (int i = 0; i<n; i=i+srn)
                fillBox(i, i);
        }
        bool unUsedInBox(int rowStart, int colStart, int num)
        {
            for (int i = 0; i<srn; i++)
                for (int j = 0; j<srn; j++)
                    if (sudokuArray[rowStart+i,colStart+j]==num)
                        return false;
     
            return true;
        }
     
        // Fill a 3 x 3 matrix.
        void fillBox(int row,int col)
        {
            int num;
            for (int i=0; i<srn; i++)
            {
                for (int j=0; j<srn; j++)
                {
                    do
                    {
                        num = randomGenerator(n);
                    }
                    while (!unUsedInBox(row, col, num));
     
                    sudokuArray[row+i,col+j] = num;
                }
            }
        }
 
    // Random generator
        int randomGenerator(int num)
        {
            return (int) Math.Floor(rand.NextDouble()*num+1);
        }
     
        // Check if safe to put in cell
        bool CheckIfSafe(int i,int j,int num)
        {
            return (unUsedInRow(i, num) &&
                    unUsedInCol(j, num) &&
                    unUsedInBox(i-i%srn, j-j%srn, num));
        }
     
        // check in the row for existence
        bool unUsedInRow(int i,int num)
        {
            for (int j = 0; j<n; j++)
               if (sudokuArray[i,j] == num)
                    return false;
            return true;
        }
        
        bool unUsedInCol(int j,int num)
        {
            for (int i = 0; i<n; i++)
                if (sudokuArray[i,j] == num)
                    return false;
            return true;
        }

        bool fillRemaining(int i, int j)
        {
            if (j>=n && i<n-1)
            {
                i++;
                j = 0;
            }
            if (i>=n && j>=n)
                return true;
     
            if (i < srn)
            {
                if (j < srn)
                    j = srn;
            }
            else if (i < n-srn)
            {
                if (j==(i/srn)*srn)
                    j+=srn;
            }
            else
            {
                if (j == n-srn)
                {
                    i++;
                    j = 0;
                    if (i>=n)
                        return true;
                }
            }
     
            for (int num = 1; num<=n; num++)
            {
                if (CheckIfSafe(i, j, num))
                {
                    sudokuArray[i,j] = num;
                    if (fillRemaining(i, j+1))
                        return true;
     
                    sudokuArray[i,j] = 0;
                }
            }
            return false;
        }
        public void removeKDigits()
        {
            int count = k;
            while (count != 0)
            {
                int cellId = randomGenerator(n*n)-1;
                int i = (cellId/n);
                int j = cellId%n;
                if (j != 0)
                    j--;
                if (sudokuArray[i,j] != 0)
                {
                    count--;
                    sudokuArray[i,j] = 0;
                }
            }
        }
    }
}