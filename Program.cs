using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            ticTacToe();
        }

        static void ticTacToe()
        {
            string[,] boxes = { { "0", "1", "2" }, { "3", "4", "5" }, { "6", "7", "8" } };
            int count = 0;
            bool x = true;
            bool madeMove;
            string team = "x";
            string wining_team = "";
            while (count < 9 && wining_team == "")
            {
                render(boxes);
                Console.Write(team + " make your move:");
                string input = Console.ReadLine();
                madeMove = makeMove(boxes, input, team);
                wining_team = checkIfWin(boxes, team);
                if (madeMove)
                {
                    x = !x;
                    count++;
                    if (x)
                    {
                        team = "x";
                    }
                    else
                    {
                        team = "o";
                    }
                }
            }
            render(boxes);
            if (wining_team != "")
            {
                Console.WriteLine(wining_team + " Wins!");
            }
            else
            {
                Console.WriteLine("its a tie");
            }
            Console.ReadLine();
        }

        static bool makeMove(string[,] arr, string input, string team)
        {

            int i = 10;
            int j = 10;
            switch (input)
            {
                case "0":
                    j = 0;
                    i = 0;
                    break;
                case "1":
                    j = 1;
                    i = 0;
                    break;
                case "2":
                    j = 2;
                    i = 0;
                    break;
                case "3":
                    j = 0;
                    i = 1;
                    break;
                case "4":
                    j = 1;
                    i = 1;
                    break;
                case "5":
                    j = 2;
                    i = 1;
                    break;
                case "6":
                    j = 0;
                    i = 2;
                    break;
                case "7":
                    j = 1;
                    i = 2;
                    break;
                case "8":
                    j = 2;
                    i = 2;
                    break;
            }
            if (i < 10 && int.TryParse(arr[i, j], out int d))
            {
                arr[i, j] = team;
                return true;
            }
            else
            {
                Console.WriteLine("cant change this index");
                return false;
            }
        }

        static string checkIfWin(string[,] arr, string team)
        {
            string win = "";

            if (arr[0, 0] == team && arr[0, 1] == team && arr[0, 2] == team)
            {
                win = team;
            }
            else if (arr[0, 0] == team && arr[1, 0] == team && arr[2, 0] == team)
            {
                win = team;
            }
            else
                   if (arr[1, 0] == team && arr[1, 1] == team && arr[1, 2] == team)
            {
                win = team;
            }
            else
                   if (arr[0, 1] == team && arr[1, 1] == team && arr[2, 1] == team)
            {
                win = team;
            }
            else
                   if (arr[2, 0] == team && arr[2, 1] == team && arr[2, 2] == team)
            {
                win = team;
            }
            else
                   if (arr[0, 2] == team && arr[1, 2] == team && arr[2, 2] == team)
            {
                win = team;
            }
            else
                   if (arr[0, 0] == team && arr[1, 1] == team && arr[2, 2] == team)
            {
                win = team;
            }
            else
                   if (arr[0, 2] == team && arr[1, 1] == team && arr[2, 0] == team)
            {
                win = team;
            }
            return win;
        }

        static void render(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j] + " | ");
                }
                Console.WriteLine("");
                Console.WriteLine("-------------");
            }
        }
    }
}
