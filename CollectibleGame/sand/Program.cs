using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.CursorVisible = false;
            Player player = new Player();
            Coordinate startCoord = Coordinate.NewCoord(1, 1);
            Collectible collectible = new Collectible();

            player.PlayerPosition = startCoord;

            collectible.CollectiblePosition = Collectible.GetCollectiblePosition(player);
            bool collectibleFound = false;
            

            Board.PrintBoard(player, collectible);
            while (true)
            {
                collectibleFound = false;
                string direction = MoveLogic.GetDirection();
                player.PlayerPosition = MoveLogic.UpdatePosition(player, direction);
                Console.Clear();
                if(player.PlayerPosition.XCoord == collectible.CollectiblePosition.XCoord && player.PlayerPosition.YCoord == collectible.CollectiblePosition.YCoord)
                {
                    player.CollectibleCount++;
                    collectibleFound = true;
                }
                if (collectibleFound == true)
                {
                    collectible.CollectiblePosition = Collectible.GetCollectiblePosition(player);
                }
                Board.PrintBoard(player, collectible);
            }

        }
    }
}

