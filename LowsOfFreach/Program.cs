int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;

foreach (int index in array)
{
    total += index;
}

float average = (float)total / array.Length;
Console.WriteLine(average);

