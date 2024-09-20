//prompt user to input array size
int total;
do
{
    Console.Write("Enter student quantity (3-15): ");
    total = Convert.ToInt32(Console.ReadLine());
} while (total < 3 || total > 15);

//initialize array and assign length (size)
string[] students = new string[total];

//assign value to each element in array
for (int i = 0; i < total; i++)
{
    Console.Write("Enter name of student " + (i+1) + ": ");
    students[i] = Console.ReadLine();
}

//display elements in array
foreach (var student in students)
    Console.WriteLine(student);
