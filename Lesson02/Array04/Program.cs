Console.Write("Enter student names (separate by spaces): ");
string names = Console.ReadLine();

string[] students = names.Split();

//Console.WriteLine("Total students: " + students.Length);

int total = 0;
Console.WriteLine("Student List: ");
foreach (string s in students)
{
    Console.WriteLine(s);
    total++; //total = total + 1
}

Console.WriteLine("Total students: " + total);
