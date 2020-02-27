using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleGame
{
    public class Board
    {
        public static void PrintBoard(Player player, Collectible collectible)
        {
            Console.Write("\n\n\n");

            Console.WriteLine("                __________");
            for (int row = 1; row <=10; row++)
            {
                Console.Write("               |");
                for (int col = 1; col <= 10; col++)
                {
                    Coordinate boardCoordinate = Coordinate.NewCoord(col, row);
                    if (boardCoordinate.XCoord == player.PlayerPosition.XCoord && boardCoordinate.YCoord == player.PlayerPosition.YCoord)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (boardCoordinate.XCoord == collectible.CollectiblePosition.XCoord && boardCoordinate.YCoord == collectible.CollectiblePosition.YCoord)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("|");
            }
            Console.WriteLine("                ==========\n");
            Console.WriteLine($"          Collectibles found: {player.CollectibleCount}.");
        }
    }
}
