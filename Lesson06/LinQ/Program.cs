//declare list
List<int> numbers = new List<int>();

//get total numbers
Console.Write("Enter total numbers: ");
int total = Convert.ToInt32(Console.ReadLine());

//input each number to list
for (int i=1; i<=total; i++)
{
    Console.Write("Enter number " + i + ": ");
    int n = Convert.ToInt32(Console.ReadLine());
    numbers.Add(n);
}

//display result
Console.WriteLine("Max: " + numbers.Max());
Console.WriteLine("Min: " + numbers.Min());
Console.WriteLine("Average: " + numbers.Average());
