Console.Write("Insert an x value: ");
int xVal = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert a y value: ");
int yVal  = Convert.ToInt32(Console.ReadLine());

if (xVal == 0)
{
    if (yVal == 0)
    {
        Console.WriteLine("The enemy is here!");
    }
    else if (yVal > 0)
    {
        Console.WriteLine("The enemy is to the North!");
    }
    else
    {
        Console.WriteLine("The enemy is to the South!");
    }
}
else if (xVal < 0)
{
    if (yVal > 0)
    {
        Console.WriteLine("The enemy is to the Northwest!");
    } else if (yVal == 0)
    {
        Console.WriteLine("The enemy is to the West!");
    } else if (yVal < 0)
    {
        Console.WriteLine("The enemy is to the Southwest!");
    }
}
else if (xVal > 0)
{
    if (yVal > 0)
    {
        Console.WriteLine("The enemy is to the Northeast!");
    } else if (yVal == 0)
    {
        Console.WriteLine("The enemy is to the East!");
    } else if (yVal < 0)
    {
        Console.WriteLine("The enemy is to the Southeast!");
    }
}