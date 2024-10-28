using System;
using System.Linq;




internal class Program
{
    private static void Main(string[] args)
    {

        int[,] BankoPlade1 = { { 1, 14, 42, 53, 83 }, { 15, 45, 56, 64, 87 }, { 19, 27, 39, 57, 78 } };
        int[,] BankoPlade2 = { { 2, 21, 43, 52, 82 }, { 4, 24, 37, 45, 74 }, { 7, 19, 25, 58, 69 } };
        int[,] BankoPlade3 = { { 1, 14, 20, 53, 60 }, { 7, 28, 36, 62, 83 }, { 9, 38, 47, 68, 78} };
        int[,] BankoPlade4 = { { 10, 20, 33, 50, 62 }, { 3, 21, 42, 54, 65 }, { 5, 26, 69, 77, 89 } };
        int[,] BankoPlade5 = { { 3, 10, 30, 55, 60 }, { 5, 43, 66, 71, 89 }, { 7, 27, 34, 48, 59 } };
        List<int> Talt = new List<int>();
        int BankoTal;

        string spilStatus = "1Row";
        do
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out BankoTal))
            {
                Talt.Add(BankoTal);
                Console.Clear();
                Console.WriteLine("1");
                PrintBoard(BankoPlade1);
                Console.WriteLine("2");
                PrintBoard(BankoPlade2);
                Console.WriteLine("3");
                PrintBoard(BankoPlade3);
                Console.WriteLine("4");
                PrintBoard(BankoPlade4);
                Console.WriteLine("5");
                PrintBoard(BankoPlade5);

                switch (spilStatus)
                {
                    case "1Row":
                        if (BankoRow(BankoPlade1, Talt))
                        {
                            Console.WriteLine($"Banko! Plade1 har fået én række!");
                            spilStatus = "2Row"; // Skift til at spille for to rækker
                        }
                        break;

                    case "2Row":
                        if (HasTwoCompleteRows(BankoPlade1, Talt))
                        {
                            Console.WriteLine($"Banko! Plade1 har fået to rækker!");
                            spilStatus = "fullBoard"; // Skift til at spille for fuld plade
                        }
                        break;

                    case "fullBoard":
                        if (IsBoardFull(BankoPlade1, Talt))
                        {
                            Console.WriteLine("BANKO!!! plade1 er fuld");
                            return; // Afslut spillet ved fuld plade
                        }
                        break;
                }
                switch (spilStatus)
                {
                    case "1Row":
                        if (BankoRow(BankoPlade2, Talt))
                        {
                            Console.WriteLine($"Banko! Plade2 har fået én række!");
                            spilStatus = "2Row"; // Skift til at spille for to rækker
                        }
                        break;

                    case "2Row":
                        if (HasTwoCompleteRows(BankoPlade2, Talt))
                        {
                            Console.WriteLine($"Banko! Plade2 har fået to rækker!");
                            spilStatus = "fullBoard"; // Skift til at spille for fuld plade
                        }
                        break;

                    case "fullBoard":
                        if (IsBoardFull(BankoPlade2, Talt))
                        {
                            return; // Afslut spillet ved fuld plade
                        }
                        break;
                }
                switch (spilStatus)
                {
                    case "1Row":
                        if (BankoRow(BankoPlade3, Talt))
                        {
                            Console.WriteLine($"Banko! Plade3 har fået én række!");
                            spilStatus = "2Row"; // Skift til at spille for to rækker
                        }
                        break;

                    case "2Row":
                        if (HasTwoCompleteRows(BankoPlade3, Talt))
                        {
                            Console.WriteLine($"Banko! Plade3 har fået to rækker!");
                            spilStatus = "fullBoard"; // Skift til at spille for fuld plade
                        }
                        break;

                    case "fullBoard":
                        if (IsBoardFull(BankoPlade3, Talt))
                        {
                            return; // Afslut spillet ved fuld plade
                        }
                        break;
                }
                switch (spilStatus)
                {
                    case "1Row":
                        if (BankoRow(BankoPlade4, Talt))
                        {
                            Console.WriteLine($"Banko! Plade4 har fået én række!");
                            spilStatus = "2Row"; // Skift til at spille for to rækker
                        }
                        break;

                    case "2Row":
                        if (HasTwoCompleteRows(BankoPlade4, Talt))
                        {
                            Console.WriteLine($"Banko! Plade4 har fået to rækker!");
                            spilStatus = "fullBoard"; // Skift til at spille for fuld plade
                        }
                        break;

                    case "fullBoard":
                        if (IsBoardFull(BankoPlade4, Talt))
                        {
                            return; // Afslut spillet ved fuld plade
                        }
                        break;
                }
                switch (spilStatus)
                {
                    case "1Row":
                        if (BankoRow(BankoPlade5, Talt))
                        {
                            Console.WriteLine($"Banko! Plade5 har fået én række!");
                            spilStatus = "2Row"; // Skift til at spille for to rækker
                        }
                        break;

                    case "2Row":
                        if (HasTwoCompleteRows(BankoPlade5, Talt))
                        {
                            Console.WriteLine($"Banko! Plade5 har fået to rækker!");
                            spilStatus = "fullBoard"; // Skift til at spille for fuld plade
                        }
                        break;

                    case "fullBoard":
                        if (IsBoardFull(BankoPlade5, Talt))
                        {
                            return; // Afslut spillet ved fuld plade
                        }
                        break;
                }
                if (BankoTal > 90 || BankoTal < 1)
                {
                    Console.WriteLine("skriv et tal i mellem 1 og 90");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }
                    continue;
                }
                else if (Contains(BankoPlade1, BankoTal))
                {
                    
                    Console.WriteLine($"{BankoTal} er på plade 1");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }
                    
                    continue;
                }
                else if (Contains(BankoPlade2, BankoTal))
                {

                    Console.WriteLine($"{BankoTal} er på plade 2");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }

                    continue;
                }
                else if (Contains(BankoPlade3, BankoTal))
                {

                    Console.WriteLine($"{BankoTal} er på plade 3");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }

                    continue;
                }
                else if (Contains(BankoPlade4, BankoTal))
                {

                    Console.WriteLine($"{BankoTal} er på plade 4");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }

                    continue;
                }
                else if (Contains(BankoPlade5, BankoTal))
                {

                    Console.WriteLine($"{BankoTal} er på plade 5");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }

                    continue;
                }
                else
                {
                    
                    Console.WriteLine($"{BankoTal} er ikke på nogle plader ");
                    foreach (var item in Talt)
                    {
                        Console.Write($"{item} ");
                    }
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Ugyldig indtastning. Prøv venligst igen.");
                continue;
            }
            static void PrintBoard(int[,] board)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write(board[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            static bool BankoRow(int[,] row, List<int> drawn)
            {
                for (int i = 0; i < row.GetLength(0); i++) // Check each row
                {
                    int countRow = 0;
                    for (int j = 0; j < row.GetLength(1); j++)
                    {
                        // Check if the current number is in the drawn list
                        if (drawn.Contains(row[i, j]))
                        {
                            countRow++;
                        }
                    }
                    if (countRow == row.GetLength(1)) // If all numbers in the row are drawn
                    {
                        return true; // A row is complete
                    }
                }
                return false; // No complete row found
            }
            static bool HasTwoCompleteRows(int[,] board, List<int> drawn)
            {
                int completeRowCount = 0; // Counter for complete rows

                for (int i = 0; i < board.GetLength(0); i++) // Check each row
                {
                    int countRow = 0; // Reset the count for each row
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        // Check if the current number is in the drawn list
                        if (drawn.Contains(board[i, j]))
                        {
                            countRow++;
                        }
                    }
                    // If all numbers in the row are drawn, increment the complete row count
                    if (countRow == board.GetLength(1))
                    {
                        completeRowCount++;
                    }
                }

                return completeRowCount >= 2; // Return true if there are two or more complete rows
            }
            static bool IsBoardFull(int[,] board, List<int> drawn)
            {
                for (int i = 0; i < board.GetLength(0); i++) // Iterate through each row
                {
                    for (int j = 0; j < board.GetLength(1); j++) // Iterate through each column
                    {
                        // Check if the current number is in the drawn list
                        if (!drawn.Contains(board[i, j]))
                        {
                            return false; // If any number is not drawn, the board is not full
                        }
                    }
                }
                return true; // All numbers are drawn; the board is full
            }

            static bool Contains(int[,] array, int value)
            {
                foreach (var item in array)
                {
                    if (item == value)
                    {

                        return true;
                    }
                }
                return false;
            }

        } while (true);
    }
}