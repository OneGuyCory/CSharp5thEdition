
//creates new arrow object by calling get arrow class
Arrow arrow = GetArrow();
Console.WriteLine($"Your arrow costs {arrow.GetCost()} gold");


//calls methods to get all arrow info and returns arrow
Arrow GetArrow()
{
    ArrowheadType arrowheadType = GetArrowheadType();
    FletchingType fletchingType = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowheadType, fletchingType, length);
}
//asks for and gets arrow type
ArrowheadType GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => ArrowheadType.Steel,
        "wood" => ArrowheadType.Wood,
        "obsidian" => ArrowheadType.Obsidian
    };
}
//asks for and gets fletching type
FletchingType GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => FletchingType.Plastic,
        "turkey feather" => FletchingType.Turkey,
        "goose feather" => FletchingType.Goose
    };
}

//asks for and gets length of the arrow, makes sure length is between 60 and 100

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}

class Arrow
{
    public ArrowheadType ArrowheadType { get; }
    public FletchingType FletchingType { get; }
    public float Length { get; }

    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
    {
        ArrowheadType = arrowheadType;
        FletchingType = fletchingType;
        Length = length;
    }
    // sets cost of all arrow parts based on what is selected
    public float GetCost()
    {
        float arrowheadCost = ArrowheadType switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Wood => 3,
            ArrowheadType.Obsidian => 5
        };

        float fletchingCost = FletchingType switch
        {
            FletchingType.Plastic => 10,
            FletchingType.Turkey => 5,
            FletchingType.Goose => 3
        };

        

        float shaftCost = 0.05f * Length;

        return arrowheadCost + fletchingCost + shaftCost;

    }

}

enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, Turkey, Goose }