namespace CollectibleGame
{
    public class Coordinate
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public static Coordinate NewCoord(int x, int y)
        {
            Coordinate coordinate = new Coordinate
            {
                XCoord = x,
                YCoord = y
            };

            return coordinate;
        }
    }
}