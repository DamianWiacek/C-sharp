using System;
using System.Collections.Generic;
using System.Linq;

public class Sudoku
{
    public static bool ValidateSolution(int[][] board)
    {
        int[][] sudoku = board;
        if (sudoku == null)
        {
            return false;
        }
        List<int> rows = new List<int>();
        List<int> columns = new List<int>();
        List<int> matrix = new List<int>();
        List<int> counter = new List<int>();
        int Valid = 0;
        foreach (var row in sudoku)
        {
            foreach (var number in row)
            {
                counter.Add(number);
            }
        }
        if (counter.Distinct().Count() == sudoku.Length)
        {
            Valid += sudoku.Length;
        }
        else if (counter.Count() != sudoku.Length * sudoku.Length)
        {
            return false;
        }
        else if (counter.Count() == 1)
        {
            return false;
        }

        for (int i = 0; i < sudoku.Length; i += (int)Math.Sqrt(sudoku.Length))
        {
            for (int j = 0; j < sudoku.Length; j += (int)Math.Sqrt(sudoku.Length))
            {
                for (int x = 0; x < (int)Math.Sqrt(sudoku.Length); x++)
                {
                    for (int y = 0; y < (int)Math.Sqrt(sudoku.Length); y++)
                    {
                        matrix.Add(sudoku[x + i][y + j]);
                    }
                }
                if (matrix.Distinct().Count() == sudoku.Length)
                {
                    Valid++;
                }
                matrix.RemoveAll(matrix => matrix > 0);
            }
        }

        for (int i = 0; i < sudoku.Length; i++)
        {
            rows.RemoveAll(rows => rows > 0);
            for (int j = 0; j < sudoku.Length; j++)
            {
                rows.Add(sudoku[i][j]);
            }
            if (rows.Distinct().Count() == sudoku.Length)
            {
                Valid++;
            }

        }
        for (int i = 0; i < sudoku.Length; i++)
        {
            columns.RemoveAll(columns => columns > 0);
            for (int j = 0; j < sudoku.Length; j++)
            {
                columns.Add(sudoku[j][i]);
            }
            if (columns.Distinct().Count() == sudoku.Length)
            {
                Valid++;
            }
        }
        if (Valid == sudoku.Length * 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}