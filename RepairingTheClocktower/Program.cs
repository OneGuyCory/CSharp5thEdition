Console.Write("Insert a number: ");
int num = Convert.ToInt32(Console.ReadLine());

/*if ( num % 2 == 0)
{
    Console.WriteLine("Tick");
} else
{
    Console.WriteLine("Tock");
}*/

string textToDisplay = num % 2 == 0 ? "Tick" : "Tock";
Console.Write(textToDisplay);

/*int score = 75;

string textToDisplay = score > 70 ? "You passed" : "you failed";
Console.WriteLine(textToDisplay);*/