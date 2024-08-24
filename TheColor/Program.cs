Color staticColor = Color.Blue;
Color userColor = new Color(10,200,160);

Console.WriteLine($"Red Value = {userColor.RedValue} Green Value = {userColor.GreenValue} Blue Value = {userColor.BlueValue}");
Console.WriteLine($"Red Value = {staticColor.RedValue} Green Value = {staticColor.GreenValue} Blue Value = {staticColor.BlueValue}");


class Color
{
    public int RedValue { get; set; }
    public int GreenValue { get; set; }
    public int BlueValue { get; set; }

    public Color(int red, int green, int blue)
    {
        RedValue = red;
        GreenValue = green;
        BlueValue = blue;
    }   

    public Color()
    {
        RedValue = 0;
        GreenValue = 0;
        BlueValue = 0;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

}