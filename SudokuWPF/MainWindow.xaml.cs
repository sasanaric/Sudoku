using System;
using System.Collections.Generic;
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
    /// </summary>
    public partial class MainWindow
    {
        private int selectedCellRow;
        private int selectedCellColumn;
        private Random rand = new Random();
        private int[,] sudokuArray;
        private int[,] solvedSudokuArray;
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
            whitePaint();
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                Border border = (Border) textBox.Parent;
                selectedCellRow = Grid.GetRow(border);
                selectedCellColumn = Grid.GetColumn(border);
                paintRowAndColumn();
                textBox.Background = Brushes.DodgerBlue;
            }
        }

        private void paintRowAndColumn()
        {
            foreach (Border cell in SudokuGrid.Children.OfType<Border>())
            {
                if (Grid.GetRow(cell).Equals(selectedCellRow) || Grid.GetColumn(cell).Equals(selectedCellColumn))
                {
                    TextBox textBox = (TextBox)cell.Child;
                    textBox.Background = Brushes.LightBlue;
                }
            }
        }
        private void whitePaint()
        {
            foreach (Border cell in SudokuGrid.Children.OfType<Border>())
            {
                TextBox textBox = (TextBox)cell.Child;
                textBox.Background = Brushes.White;
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
        
        private void checkTextBox()
        {
            TextBox textBox = getTextBoxFromGrid(selectedCellRow, selectedCellColumn);
            if (textBox.Text != "" && !isGameSolved)
            {
                if (sudokuArray[selectedCellRow, selectedCellColumn] != solvedSudokuArray[selectedCellRow, selectedCellColumn])
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
                    setFilledNumbers();
                    checkIfSolved();
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
            creatingGame = true;
            whitePaint();
            selectedCellRow = -1;
            selectedCellColumn = -1;
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
            setFilledNumbers();
        }

        private void checkIfSolved()
        {
            bool solved = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudokuArray[i, j] != solvedSudokuArray[i, j]) solved=false;
                }
            }

            if (solved)
            {
                stopwatch.Stop();
                timer.Stop();
                isGameSolved = true;
                MessageBox.Show("Cestitam! Rijesili ste sudoku.");
            }
        }
        private void setFilledNumbers()
        {
            int counter = 1;
            List<int> filledNumbers = getFilledNumbers();
            foreach (TextBox textBox in GridFilledNumbers.Children.OfType<TextBox>())
            {
                textBox.Text = $"{counter--}  {filledNumbers[counter]}/9";
                if (filledNumbers[counter] == 9)
                    textBox.Background = Brushes.MediumSeaGreen;
                else textBox.Background = Brushes.White;
                counter += 2;
            }
        }
        private List<int> getFilledNumbers()
        {
            List<int> filledNumbers = new List<int>();
            for (int number = 1; number <= 9; number++)
            {
                int counter = 0;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j<9; j++)
                    {
                        if (sudokuArray[i, j] == number)
                            counter++;
                    }
                }
                filledNumbers.Add(counter);
            }

            return filledNumbers;
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
            if(!creatingGame && !isGameSolved)
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
                    else
                    {
                        sudokuArray[selectedCellRow, selectedCellColumn] = 0;
                    }
                }
                
            }
            
        }
        void fillValues()
        {
            sudokuArray = new int[9, 9];
            solvedSudokuArray = new int[9, 9];
            fillCell(0, 0);
            Array.Copy(sudokuArray,solvedSudokuArray,81);
            removeKDigits();
        }

        bool fillCell(int row, int col)
        {
            if (col == 9)
            {
                row++;
                col = 0;
            }
            if (row == 9)
            {
                return true;
            }
            if (sudokuArray[row, col] != 0)
            {
                return fillCell(row, col + 1);
            }
            List<int> numbers = Enumerable.Range(1, 9).ToList();
            numbers = numbers.OrderBy(x => rand.Next()).ToList();
            foreach (int num in numbers)
            {
                if (CheckIfSafe(row, col, num))
                {
                    sudokuArray[row, col] = num;
                    
                    if (fillCell(row, col + 1))
                    {
                        return true;
                    }
                    // Backtrack if we couldn't fill the next cell
                    sudokuArray[row, col] = 0;
                }
            }
            // None of the numbers worked, so we need to backtrack
            return false;
        }

        bool unUsedInBox(int rowStart, int colStart, int num)
        {
            for (int i = 0; i<srn; i++)
                for (int j = 0; j<srn; j++)
                    if (sudokuArray[rowStart+i,colStart+j]==num)
                        return false;
     
            return true;
        }
        int randomGenerator(int num)
        {
            return rand.Next(num);
        }

        bool CheckIfSafe(int i,int j,int num)
        {
            return (unUsedInRow(i, num) &&
                    unUsedInCol(j, num) &&
                    unUsedInBox(i-i%srn, j-j%srn, num));
        }
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
        public void removeKDigits()
        {
            int count = k;
            while (count != 0)
            {
                int cellId = randomGenerator(n*n);
                int i = (cellId/n);
                int j = cellId%n;
                // if (j != 0)
                //     j--;
                if (sudokuArray[i,j] != 0)
                {
                    count--;
                    sudokuArray[i,j] = 0;
                }
            }
        }
    }
}