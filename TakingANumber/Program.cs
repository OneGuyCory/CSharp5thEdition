int AskForNumber(string text)
{
    Console.WriteLine(text);
    int response = Convert.ToInt32(Console.ReadLine());

    return response;
}

int AskForNumberInRange(string text, int min, int max)
{
    int num = 0;

    do
    {
        Console.WriteLine(text);
        num = Convert.ToInt32(Console.ReadLine());
    }
    while (num < min || num > max);
    return num;
}

int rangeCheck = AskForNumberInRange("Pick a number between 10 and 20 ", 10, 20);