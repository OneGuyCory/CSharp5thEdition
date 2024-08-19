int[] nums = new int[5];
int[] numsCopy = new int[5];

for (int i = 0; i < nums.Length; i++)
{
    Console.Write("Please enter a number: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

for (int i = 0; i < nums.Length; i++)
{
    numsCopy[i] = nums[i];
}

for (int i = 0; i < numsCopy.Length; i++)
{
    Console.WriteLine(numsCopy[i]);
}