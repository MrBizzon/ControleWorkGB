string[] CreatArray;
int number;

Console.Write("Enter the size of the array: ");
number = Convert.ToInt32(Console.ReadLine());
CreatArray = new string[number];
Console.WriteLine("Enter any numbers, words, or symbols: ");

for (int i = 0; i < CreatArray.Length; i++)
{
    Console.Write($"Input {i + 1}: ");
    CreatArray[i] = Console.ReadLine();
}

Console.Write("The condition is met for the following lines:  ");
for (int i = 0; i < CreatArray.Length; i++)
{
    if (CreatArray[i].Length <= 3)
    {
        Console.Write("{0} ", string.Join(",", CreatArray[i]));
    }
}
