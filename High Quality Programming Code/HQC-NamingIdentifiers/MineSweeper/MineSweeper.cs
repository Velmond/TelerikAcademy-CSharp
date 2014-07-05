// Task 04. Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”.
//          You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.

namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class MineSweeper
    {
        public static void Main(string[] args)
        {
            const int Max = 35;
            string command = string.Empty;
            char[,] field = GenerateField();
            char[,] bombs = GenerateBombs();
            int row = 0;
            int column = 0;
            int result = 0;
            List<Score> highScores = new List<Score>(6);
            bool isNewGame = true;
            bool isGameWon = false;
            bool hasExploaded = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawField(field);
                    isNewGame = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScores(highScores);
                        break;
                    case "restart":
                        field = GenerateField();
                        bombs = GenerateBombs();
                        DrawField(field);
                        hasExploaded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                PlayersTurn(field, bombs, row, column);
                                result++;
                            }

                            if (Max == result)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            hasExploaded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (hasExploaded)
                {
                    DrawField(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", result);
                    string playerName = Console.ReadLine();
                    Score highScore = new Score(playerName, result);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(highScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Points < highScore.Points)
                            {
                                highScores.Insert(i, highScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score firstScore, Score secondScore) => secondScore.Name.CompareTo(firstScore.Name));
                    highScores.Sort((Score firstScore, Score secondScore) => secondScore.Points.CompareTo(firstScore.Points));
                    HighScores(highScores);

                    field = GenerateField();
                    bombs = GenerateBombs();
                    result = 0;
                    hasExploaded = false;
                    isNewGame = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Score to4kii = new Score(imeee, result);
                    highScores.Add(to4kii);
                    HighScores(highScores);
                    field = GenerateField();
                    bombs = GenerateBombs();
                    result = 0;
                    isGameWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void HighScores(List<Score> points)
        {
            Console.WriteLine("\nTo4KI:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayersTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char surroundingBombsCount = CalculateSurroundingMines(bombs, row, column);
            bombs[row, column] = surroundingBombsCount;
            field[row, column] = surroundingBombsCount;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateField()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] GenerateBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();

            while (bombs.Count < 15)
            {
                Random random = new Random();
                int bombPosition = random.Next(50);

                if (!bombs.Contains(bombPosition))
                {
                    bombs.Add(bombPosition);
                }
            }

            foreach (int bomb in bombs)
            {
                int row = bomb / columns;
                int col = bomb % columns;

                if (col == 0 && bomb != 0)
                {
                    row--;
                    col = columns;
                }
                else
                {
                    col++;
                }

                field[row, col - 1] = '*';
            }

            return field;
        }

        private static void SurroundingMines(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char surroundingMines = CalculateSurroundingMines(field, i, j);
                        field[i, j] = surroundingMines;
                    }
                }
            }
        }

        private static char CalculateSurroundingMines(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < columns)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < columns))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < columns))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
