// See https://aka.ms/new-console-template for more information
using System;

namespace SudokuApp
{
    class Sudoku
    {
        static void Main(string[] args)
        {
            int boxRow = 5 - 5 % 3;
            int boxCol = 7 - 7 % 3;
            Console.WriteLine(boxRow);
            Console.WriteLine(boxCol);
            List<int> niz = new List<int>();
            int[,] sudokuGrid= getSudokuGrid();
            printSudokuGrid(sudokuGrid);
            List<(int, int)> coordinates = new List<(int, int)>
            {
                (0, 0),
                (0, 3),
                (0, 6),
                (1, 7),
                (2, 2),
                (2, 5),
                (3, 1),
                (3, 4),
                (3, 7),
                (4, 0),
                (4, 8),
                (5, 1),
                (5, 4),
                (5, 7),
                (6, 2),
                (6, 5),
                (7, 1),
                (8, 0),
                (8, 3),
                (8, 6)
            };
            FillSomeSpots(sudokuGrid, coordinates);
            printSudokuGrid(sudokuGrid);
        }

        static int[,] getSudokuGrid()
        {
            int[,] grid = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = 0;
                }
            }

            return grid;
        }

        static void printSudokuGrid(int[,] sudokuGrid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Console.Write(sudokuGrid[i, j]+"  ");
                    Console.WriteLine(
                        $"<Border Style=\"{{StaticResource CellBorder}}\" Grid.Row=\"{i}\" Grid.Column=\"{j}\"/>");
                }
                Console.WriteLine();
            }
        }
        static bool IsValid(int[,] grid, int row, int col, int num)
        {
            // Check row
            for (int i = 0; i < 9; i++)
            {
                if (grid[row, i] == num)
                {
                    return false;
                }
            }

            // Check column
            for (int i = 0; i < 9; i++)
            {
                if (grid[i, col] == num)
                {
                    return false;
                }
            }

            // Check 3x3 box
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (grid[i, j] == num)
                    {
                        return false;
                    }
                }
            }

            // Number is valid
            return true;
        }
        static bool SolveSudoku(int[,] grid)
        {
            // Find an empty cell
            int row = -1;
            int col = -1;
            bool isComplete = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        isComplete = false;
                        break;
                    }
                }
                if (!isComplete)
                {
                    break;
                }
            }

            // If no empty cell found, the puzzle is solved
            if (isComplete)
            {
                return true;
            }

            // Try numbers 1 to 9 for the empty cell
            for (int num = 1; num <= 9; num++)
            {
                if (IsValid(grid, row, col, num))
                {
                    grid[row, col] = num;
                    if (SolveSudoku(grid))
                    {
                        return true;
                    }
                    grid[row, col] = 0;
                }
            }

            // Backtrack
            return false;
        }
        static void FillSomeSpots(int[,] grid, List<(int, int)> coordinates)
        {
            Random random = new Random();
            foreach ((int row, int col) in coordinates)
            {
                int num = random.Next(1, 10);
                while (!IsValid(grid, row, col, num))
                {
                    num = random.Next(1, 10);
                }
                grid[row, col] = num;
            }
        }
    }
}