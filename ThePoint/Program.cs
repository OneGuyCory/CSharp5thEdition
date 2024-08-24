Point test = new Point(-4, 0);
Console.WriteLine($"({test.XCoord},{test.YCoord})");

class Point
{
    public int XCoord { get; }
    public int YCoord { get; }

   public Point(int xcoord, int ycoord)
    {
        XCoord = xcoord;
        YCoord = ycoord;
    }

    public Point()
    {
        XCoord = 0;
        YCoord = 0;
    }

}
