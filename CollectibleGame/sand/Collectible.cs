using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleGame
{
    public class Collectible
    {
        public Coordinate CollectiblePosition { get; set; }


        public static Coordinate GetCollectiblePosition(Player player)
        {
            Random rng = new Random();
            Coordinate coordinate = new Coordinate();
            bool isOnPlayer = true;
            while (isOnPlayer == true)
            {
                coordinate.XCoord = rng.Next(1, 10);
                coordinate.YCoord = rng.Next(1, 10);

                if (coordinate.XCoord == player.PlayerPosition.XCoord && coordinate.YCoord == player.PlayerPosition.YCoord)
                {
                    isOnPlayer = true;
                }
                else
                {
                    isOnPlayer = false;
                }
            }
            return coordinate;
        }
    }
}
