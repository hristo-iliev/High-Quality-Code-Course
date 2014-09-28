namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {    
        public static void Main(string[] аргументи)
        {
            const int MaxMines = 35;

            string commandInput = string.Empty;
            char[,] field = CreateField();
            char[,] mines = SetMines();
            int counter = 0;
            bool isMine = false;
            List<Score> bestScores = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool startGame = true;
            bool endGame = false;

            do
            {
                if (startGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawField(field);
                    startGame = false;
                }

                Console.Write("Daj red i kolona : ");
                commandInput = Console.ReadLine().Trim();
                if (commandInput.Length >= 3)
                {
                    if (int.TryParse(commandInput[0].ToString(), out row) &&
                    int.TryParse(commandInput[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        commandInput = "turn";
                    }
                }

                switch (commandInput)
                {
                    case "top":
                        RankingTable(bestScores);
                        break;
                    case "restart":
                        field = CreateField();
                        mines = SetMines();
                        DrawField(field);
                        isMine = false;
                        startGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                NextTurn(field, mines, row, col);
                                counter++;
                            }

                            if (MaxMines == counter)
                            {
                                endGame = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isMine)
                {
                    DrawField(mines);
                    Console.Write(
                        "\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ",
                        counter);

                    string niknejm = Console.ReadLine();
                    Score t = new Score(niknejm, counter);
                    if (bestScores.Count < 5)
                    {
                        bestScores.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < bestScores.Count; i++)
                        {
                            if (bestScores[i].Points < t.Points)
                            {
                                bestScores.Insert(i, t);
                                bestScores.RemoveAt(bestScores.Count - 1);
                                break;
                            }
                        }
                    }

                    bestScores.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    bestScores.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    RankingTable(bestScores);

                    field = CreateField();
                    mines = SetMines();
                    counter = 0;
                    isMine = false;
                    startGame = true;
                }

                if (endGame)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawField(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Score currentScore = new Score(name, counter);
                    bestScores.Add(currentScore);
                    RankingTable(bestScores);
                    field = CreateField();
                    mines = SetMines();
                    counter = 0;
                    endGame = false;
                    startGame = true;
                }
            }
            while (commandInput != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void RankingTable(List<Score> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} kutii",
                        i + 1,
                        points[i].Name,
                        points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void NextTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = MinesCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < rows + cols)
            {
                Random random = new Random();
                int minePosition = random.Next(50);
                if (!mines.Contains(minePosition))
                {
                    mines.Add(minePosition);
                }
            }

            foreach (int index in mines)
            {
                int column = index / cols;
                int row = index % cols;
                if (row == 0 && index != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playField[column, row - 1] = '*';
            }

            return playField;
        }

        private static void CalculatingField(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char cellCount = MinesCount(field, i, j);
                        field[i, j] = cellCount;
                    }
                }
            }
        }

        private static char MinesCount(char[,] mines, int rowIndex, int colIndex)
        {
            int count = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (rowIndex - 1 >= 0)
            {
                if (mines[rowIndex - 1, colIndex] == '*')
                {
                    count++;
                }
            }

            if (rowIndex + 1 < rows)
            {
                if (mines[rowIndex + 1, colIndex] == '*')
                {
                    count++;
                }
            }

            if (colIndex - 1 >= 0)
            {
                if (mines[rowIndex, colIndex - 1] == '*')
                {
                    count++;
                }
            }

            if (colIndex + 1 < cols)
            {
                if (mines[rowIndex, colIndex + 1] == '*')
                {
                    count++;
                }
            }

            if ((rowIndex - 1 >= 0) && (colIndex - 1 >= 0))
            {
                if (mines[rowIndex - 1, colIndex - 1] == '*')
                {
                    count++;
                }
            }

            if ((rowIndex - 1 >= 0) && (colIndex + 1 < cols))
            {
                if (mines[rowIndex - 1, colIndex + 1] == '*')
                {
                    count++;
                }
            }

            if ((rowIndex + 1 < rows) && (colIndex - 1 >= 0))
            {
                if (mines[rowIndex + 1, colIndex - 1] == '*')
                {
                    count++;
                }
            }

            if ((rowIndex + 1 < rows) && (colIndex + 1 < cols))
            {
                if (mines[rowIndex + 1, colIndex + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

        public class Score
        {          
            public Score() 
            { 
            }

            public Score(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name { get; set; }

            public int Points { get; set; }
        }
    }
}
