using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleGame
{
    public static class MoveLogic
    {

        public static string GetDirection()
        {

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    return "u";
                case ConsoleKey.DownArrow:
                    return "d";                 
                case ConsoleKey.LeftArrow:
                    return "l";
                case ConsoleKey.RightArrow:
                    return "r";
                default:
                    return "n";
            }
          
        }
        public static Coordinate UpdatePosition(Player oldPosition, string direction)
        {
            Coordinate newPosition = new Coordinate();
            switch(direction)
            { 
                case "u":
                    if (oldPosition.PlayerPosition.YCoord == 1)
                    {
                        return oldPosition.PlayerPosition;
                    }
                    else
                    {
                        newPosition.XCoord = oldPosition.PlayerPosition.XCoord;
                        newPosition.YCoord = oldPosition.PlayerPosition.YCoord - 1;
                        return newPosition;
                    }
                    
                case "d":
                    if (oldPosition.PlayerPosition.YCoord == 10)
                    {
                        return oldPosition.PlayerPosition;
                    }
                    else
                    {
                        newPosition.XCoord = oldPosition.PlayerPosition.XCoord;
                        newPosition.YCoord = oldPosition.PlayerPosition.YCoord + 1;
                        return newPosition;
                    }

                case "l":
                    if (oldPosition.PlayerPosition.XCoord == 1)
                    {
                        return oldPosition.PlayerPosition;
                    }
                    else
                    {
                        newPosition.XCoord = oldPosition.PlayerPosition.XCoord - 1;
                        newPosition.YCoord = oldPosition.PlayerPosition.YCoord;
                        return newPosition;
                    }

                case "r":
                    if (oldPosition.PlayerPosition.XCoord == 10)
                    {
                        return oldPosition.PlayerPosition;
                    }
                    else
                    {
                        newPosition.XCoord = oldPosition.PlayerPosition.XCoord + 1;
                        newPosition.YCoord = oldPosition.PlayerPosition.YCoord;
                        return newPosition;
                    }
                case "n":
                    return oldPosition.PlayerPosition;

                default:
                    return oldPosition.PlayerPosition;

            }
        }
       
    }
}
