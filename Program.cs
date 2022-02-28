using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static bool inputCorrect = true;
        static char[,] playField = { { '1', '2','3'},
                              { '4', '5','6'},
                              { '7', '8','9'} };
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            DrawBoard();
            #region
            //to check the winning condition
            char[] playerChar = { 'X', 'O' };
            foreach (var item in playerChar)
            {
                if (((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 0] == item) && (playField[1, 1] == item) && (playField[2, 0] == item)) ||
                    ((playField[2, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item)) ||
                    ((playField[0, 2] == item) && (playField[1, 1] == item) && (playField[2, 0] == item)) )
                   
                {
                    if(item=='X')
                    {
                        Console.WriteLine("player 2 has won");
                        break;
                    }
                    else if(item =='O')
                    {
                        Console.WriteLine("player 1 has won");
                        break;
                    }
                    

                }
            }
            #endregion

            #region
            // this region is to check the field is occupied or not
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DrawBoard();
                do
                {
                    Console.WriteLine("\n player {0} choose the field", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("enter number between 1 to 9");
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("please use another field");
                        inputCorrect = false;
                    }


                } while (!inputCorrect);
            } while (true);
            #endregion
            Console.ReadLine();
        }
        #region
        // enter X or O region
        private static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if(player==2)
                playerSign = 'O';
            do
            {
                if (player == 2)
                {
                    player = 1;
                }
                else if (player == 1)
                {
                    player = 2;
                }
                       switch (input)
                        {
                            case 1: playField[0, 0] = playerSign; break;
                            case 2: playField[0, 1] = playerSign; break;
                            case 3: playField[0, 2] = playerSign; break;
                            case 4: playField[1, 0] = playerSign; break;
                            case 5: playField[1, 1] = playerSign; break;
                            case 6: playField[1, 2] = playerSign; break;
                            case 7: playField[2, 0] = playerSign; break;
                            case 8: playField[2, 1] = playerSign; break;
                            case 9: playField[2, 2] = playerSign; break;
                        }
                        break;
            } while (true);

        }
        #endregion

        //this is draw board
        #region
        // this region is for draw board
        private static void DrawBoard()
        {
            //this is a methodf to draw 3*3 board
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ",playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
        }
        #endregion

        // check
    

    }
}
