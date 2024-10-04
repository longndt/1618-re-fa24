//get total students
Console.Write("Enter total students: ");
int total = Convert.ToInt32(Console.ReadLine());

//create dictionary to store student grades
var students = new SortedDictionary<string, double>();

//input student grades
for (int i=1; i<=total; i++)
{
    //get student info
    Console.WriteLine("Student " + i);
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter grade: ");
    double grade = double.Parse(Console.ReadLine());
    //add student info to dictionary
    students.Add(name, grade);
}

//show result
foreach (var student in students)
{
    Console.WriteLine(student.Key + " - " + student.Value);
}