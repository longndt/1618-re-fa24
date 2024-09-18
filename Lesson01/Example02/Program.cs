//input: Read
//output: Write

Console.Write("Enter your name: ");
//take input from user
string name = Console.ReadLine();
Console.Write("Enter your age: ");
//convert string to number
int age = Convert.ToInt32(Console.ReadLine());
//calculate birth year based on age
int currentYear = DateTime.Now.Year;
int birthYear = currentYear - age;
Console.Write("Enter your grade: ");
double grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hello " + name);
Console.WriteLine("You are " + age + " year old");
Console.WriteLine("You was born in " + birthYear);
Console.WriteLine("You GPA is " + grade);