double grade;
do
{
    Console.Write("Enter your grade (0-10): ");
    grade = double.Parse(Console.ReadLine());
} while (grade < 0 || grade > 10);

Console.WriteLine("Your grade is " + grade);

