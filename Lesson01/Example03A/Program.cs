/* Problem
 * 9-10: Distinction
 * 8-9: Merit
 * 5-8: Pass
 * 0-5: Fail
 * Solution: if + else if + else
 */

Console.Write("Enter grade: ");
double grade = double.Parse(Console.ReadLine());

//if : first case
//if else : middle case(s)
//else: last case

if (grade >= 9 && grade <= 10)
    Console.WriteLine("Distinction");
else if (grade >= 8 && grade < 9)
    Console.WriteLine("Merit");
else if (grade >= 5 && grade < 8)
    Console.WriteLine("Pass");
else if (grade >= 0 && grade < 5)
    Console.WriteLine("Failed");
else
    Console.WriteLine("Invalid grade");