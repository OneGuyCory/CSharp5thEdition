(SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");

(SoupType, MainIngredient, Seasoning) GetSoup()
{
    SoupType type = GetSoupType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}

SoupType GetSoupType()
{
    Console.Write("Please select a soup type. Soup, stew, or gumbo: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo
    };
}

MainIngredient GetMainIngredient()
{
    Console.Write("Please select a main ingredient. Mushroom, Chicken, Carrot, or Potato: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "mushrooms" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrot,
        "potatoes" => MainIngredient.Potato
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Please select a seasoning. Spicy, Salty, or Sweet: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}


enum SoupType { Soup, Stew, Gumbo };
enum MainIngredient { Mushroom, Chicken, Carrot, Potato };
enum Seasoning { Spicy, Salty, Sweet };