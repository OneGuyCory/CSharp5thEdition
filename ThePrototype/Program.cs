int num;
int numGuess;
do
{
    Console.Write("Pilot, enter a number between 0 and 100: ");
    num = Convert.ToInt32(Console.ReadLine());
}
while (num > 100 || num < 0);
Console.Clear();

do
{
    Console.Write("Hunter, guess the number: ");
    numGuess = Convert.ToInt32(Console.ReadLine());

    if (numGuess > num)
    {
        Console.WriteLine($"{numGuess} is too high.");
    } else if (numGuess < num)
    {
        Console.WriteLine($"{numGuess} is too low.");
    } else if (numGuess == num)
    {
        Console.WriteLine("You guessed the number!");
    }

}
while (numGuess != num);
