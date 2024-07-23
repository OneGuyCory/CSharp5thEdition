// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many provinces do you have?");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you have?");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many estates do you have?");
int estates = Convert.ToInt32(Console.ReadLine());

provinces *= 6;
duchies *= 3;
estates *= 1;

int score = provinces + duchies + estates;