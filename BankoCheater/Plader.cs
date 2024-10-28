using System;
using System.Collections.Generic;
using System.Linq;

public class BingoBoard
{
    private int[,] board;
    private List<int> drawnNumbers;

    public BingoBoard(int[,] initialBoard)
    {
        board = initialBoard;
        drawnNumbers = new List<int>();
    }

    public void DrawNumber(int number)
    {
        drawnNumbers.Add(number);
    }

    public bool CheckForOneRow()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board.GetLength(1) == drawnNumbers.Count(n => board[i, n] == n))
            {
                return true; // A row is complete
            }
        }
        return false; // No complete row found
    }

    public bool CheckForTwoRows()
    {
        int completeRowCount = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board.GetLength(1) == drawnNumbers.Count(n => board[i, n] == n))
            {
                completeRowCount++;
            }
        }

        return completeRowCount >= 2; // Return true if there are two or more complete rows
    }

    public bool IsFull()
    {
        return board.Cast<int>().All(n => drawnNumbers.Contains(n)); // Check if all numbers are drawn
    }

    public void Print()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine(); // Extra line for spacing between boards
    }

    public bool Contains(int value)
    {
        return board.Cast<int>().Contains(value); // Check if the number is in the board
    }
}