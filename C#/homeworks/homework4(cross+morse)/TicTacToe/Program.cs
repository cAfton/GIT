using System.ComponentModel.Design;
using System.Drawing;

namespace TicTacToe
{
    namespace Game
    {
        public class GameGo
        {
            public static bool isWin(List<List<Cell>> table, char playerSymbol)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (table[i][0].Symbol == table[i][1].Symbol && table[i][0].Symbol == table[i][2].Symbol && table[i][0].isChose && table[i][0].Symbol == playerSymbol) 
                    {
                        return true;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (table[0][i].Symbol == table[1][i].Symbol && table[0][i].Symbol == table[2][i].Symbol && table[0][i].isChose && table[2][i].Symbol == playerSymbol) 
                    {
                        return true;
                    }
                }

                if (table[0][0].Symbol == table[2][2].Symbol && table[0][0].Symbol == table[1][1].Symbol && table[0][0].Symbol == playerSymbol)
                {
                    return true;
                }
                if (table[0][2].Symbol == table[1][1].Symbol && table[1][1].Symbol == table[2][0].Symbol && table[2][0].Symbol == playerSymbol)
                {
                    return true;
                }
                return false;
            }
            public static void PrintTable(List<List<Cell>> table)
            {
                Console.WriteLine(" \\x       1       2       3    \ny ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"      * * * * * * * * * * * * *\n\n{i + 1}     ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"*   {table[i][j].Symbol}   ");
                    }
                    Console.Write("*\n\n");
                }
                Console.WriteLine("      * * * * * * * * * * * * *");

            }
        }
    }
    public class Cell
    {
        public char Symbol { get; set; }
        public bool isChose { get; set; }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Cell[,] temp = new Cell[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = new Cell { Symbol = ' ', isChose = false };
                }
            }

            List<List<Cell>> table = new List<List<Cell>>();
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                List<Cell> row = new List<Cell>();
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    row.Add(temp[i, j]);
                }
                table.Add(row);
            }

            Random random = new Random();
            int first = random.Next() % 2;

            char user = 'o', comp = 'x';
            int x, y;

            Console.WriteLine("Play with: \n1 - computer\n2 - friend");
            bool playWithComputer;

            string choose = Console.ReadLine();
            string user1Name = "", user2Name = "";

            if (choose == "1")
            {
                Console.Write("Enter player name: ");
                user1Name = Console.ReadLine();
                playWithComputer = true;
            }

            else if (choose == "2")
            {
                Console.Write("Enter player 1 name: ");
                user1Name = Console.ReadLine();
                Console.Write("Enter player 2 name: ");
                user2Name = Console.ReadLine();

                playWithComputer = false;
            }

            else
            {
                Console.WriteLine("error option");
                return;
            }


            if (playWithComputer)
            {
                if (first == 1)
                {
                    user = 'x';
                    comp = 'o';
                }
                else
                {
                    x = random.Next() % 3;
                    y = random.Next() % 3;
                    table[y][x].Symbol = comp;
                    table[y][x].isChose = true;
                }
            }
            

            /////////////////////////////////////////////////////////

            bool isContinued = true;
            while (isContinued)
            {
                Console.WriteLine($"You are {user1Name}({user})");
                Game.GameGo.PrintTable(table);

                #region isWin
                if (Game.GameGo.isWin(table, user))
                {
                    Console.WriteLine($"{user1Name} win!");
                    return;
                }
                else if (Game.GameGo.isWin(table, comp))
                {
                    Console.WriteLine("Computer win!");
                    return;
                }
                #endregion


                #region IsDraw
                bool Draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!table[i][j].isChose)
                        {
                            Draw = false;
                            break;
                        }
                    }
                }
                if (Draw)
                {
                    Console.WriteLine("Draw");
                    return;
                }
                #endregion


                #region Player
                Console.Write("Enter x: ");
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    x = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter y: ");
                try { 
                    
                    y = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    y = int.Parse(Console.ReadLine());
                }

                if ((x < 4 && x > 0) && (y < 4 && y > 0) && !(table[y - 1][ x - 1].isChose) )
                {
                    table[y - 1][ x - 1].Symbol = user;
                    table[y - 1][ x - 1].isChose = true;
                }
                else
                {
                    while (!(x < 4 && x > 0) || !(y < 4 && y > 0) || (table[y - 1][x - 1].isChose))
                    {
                        Console.WriteLine("Wrong input.");
                        Console.Write("Enter x: ");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Enter y: ");
                        y = int.Parse(Console.ReadLine());
                        if ((x < 4 && x > 0) && (y < 4 && y > 0) && !(table[y - 1][ x - 1].isChose))
                        {
                            table[y - 1][ x - 1].Symbol = user;
                            table[y - 1][ x - 1].isChose = true;
                            break;
                        }
                    } 
                }
                #endregion

                if (playWithComputer)
                {
                    #region Computer

                    do
                    {
                        x = random.Next() % 3;
                        y = random.Next() % 3;
                    } while (table[y][x].isChose);

                    table[y][x].Symbol = comp;
                    table[y][x].isChose = true;

                    #endregion
                }
                else
                {
                    #region Player2
                    Console.Clear();
                    if (Game.GameGo.isWin(table, user))
                    {
                        Console.WriteLine($"{user1Name} win!");
                        return;
                    }
                    else if (Game.GameGo.isWin(table, comp))
                    {
                        Console.WriteLine($"{user2Name} win!");
                        return;
                    }

                    Console.WriteLine($"You are {user2Name}({comp})");
                    Game.GameGo.PrintTable(table);
                    Console.Write("Enter x: ");
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter y: ");
                    try
                    {

                        y = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        y = int.Parse(Console.ReadLine());
                    }

                    if ((x < 4 && x > 0) && (y < 4 && y > 0) && !(table[y - 1][x - 1].isChose))
                    {
                        table[y - 1][x - 1].Symbol = comp;
                        table[y - 1][x - 1].isChose = true;
                    }
                    else
                    {
                        while (!(x < 4 && x > 0) || !(y < 4 && y > 0) || (table[y - 1][x - 1].isChose))
                        {
                            Console.WriteLine("Wrong input.");
                            Console.Write("Enter x: ");
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Enter y: ");
                            y = int.Parse(Console.ReadLine());
                            if ((x < 4 && x > 0) && (y < 4 && y > 0) && !(table[y - 1][x - 1].isChose))
                            {
                                table[y - 1][x - 1].Symbol = comp;
                                table[y - 1][x - 1].isChose = true;
                                break;
                            }
                        }
                    }
                    #endregion
                }

                Console.Clear();

            }
        }
    }
}
