// loop through 1 - 100
// every 3 cranks = fire
// every 5 cranks = electric
// every combined = combined
int x = 1;

while (x <= 100)
{
    
    if (x % 15 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{x}: Electric and Fire");
    
    } else if (x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{x}: Electric");
    } else if (x % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{x}: Fire ");
    } else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{x}: Normal");
    }
    x++;
}
