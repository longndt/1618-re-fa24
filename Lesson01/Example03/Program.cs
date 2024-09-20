using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 5)
        {
            Console.WriteLine("Passed");
            Console.WriteLine("Congratulations !");
        }
        else {  //grade < 5
            Console.WriteLine("Failed");
        }
    }
}