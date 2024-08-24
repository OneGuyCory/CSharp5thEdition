int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int manticoreDistance;
string dash = "-----------------------------------------------------------";


manticoreDistance = AskForNumberInRange("Player 1, how far away from the city do you want to station the manticore? ", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityHealth > 0 && manticoreHealth > 0)
{
    
    Console.WriteLine(dash);
    CurrentStatus();

    int damage = RoundDamage(round);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Cyan;
    ShotStatus(cannonRange, manticoreDistance);

    if (cannonRange == manticoreDistance)
    {
        manticoreHealth -= damage;
    }
    cityHealth--;
    round++;
}

bool won = cityHealth > 0;
DisplayWinner(won);


//gets manticore distance within a range
int AskForNumberInRange(string text, int min, int max)
{
    do
    {
        Console.Write(text);
        manticoreDistance = Convert.ToInt32(Console.ReadLine());
    }
    while (manticoreDistance < min ||  manticoreDistance > max);
    return manticoreDistance;
}

//determines damage done based on round number
int RoundDamage(int round)
{
    if (round % 15 == 0) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    else return 1;
}

//shows status
void CurrentStatus()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"The cannon is expected to deal {RoundDamage(round)} damage this round.");
}

//determines if shot was a miss or hit based on manticore distance and cannon range
void ShotStatus(int cannonRange, int manticoreDistance)
{
    if (cannonRange > manticoreDistance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    } else if (cannonRange < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    } else if (cannonRange == manticoreDistance)
    {
        Console.WriteLine("That was a DIRECT HIT!");
    }
}

void DisplayWinner(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The manticore has been destroyed! The city of Consolas has been saved!");
    } else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city have been destroyed! The Manticore is victorious.");
    }

 }
