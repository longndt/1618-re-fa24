/* 
 * menu based program
 * Student Management System
 * 1. Add student
 * 2. Remove student
 * 3. Display student list
 * 4. Exit program
 */

int choice = 0;  //0 : initial value
List<string> students = new List<string>();
string name;

while (choice != 6)  //use "while" loop to repeat program
{
    //1. display program menu
    Console.WriteLine("Student Management System");
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. Remove student");
    Console.WriteLine("3. Display student list");
    Console.WriteLine("4. Search student");
    Console.WriteLine("5. Sort student list");
    Console.WriteLine("6. Exit program");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    //2. run menu choice
    switch(choice)
    {
        case 1:
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            students.Add(name);
            break;
        case 2:
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            students.Remove(name);
            break;
        case 3:
            foreach (var student in students)
                Console.WriteLine(student);
            break;
        case 4:
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            if (students.Contains(name))
                Console.WriteLine("Student found !");
            else
                Console.WriteLine("Student not found !");
            break;
        case 5:
            students.Sort();
            foreach (var student in students)
                Console.WriteLine(student);
            break;
        case 6:
            Console.WriteLine("Program exited. See you next time !");
            break;
        default:
            Console.WriteLine("Invalid choice !");
            break;
    }
}
