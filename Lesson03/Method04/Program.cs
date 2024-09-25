/*
 * Problem: 
 * - Write a method that receives a grade between 2.00 and 6.00
 * - Write another method that prints the corresponding grade in words
 *  2.00 - 2.99 - "Fail"
    3.00 - 3.49 - "Poor"
    3.50 - 4.49 - "Good"
    4.50 - 5.49 - "Very good"
    5.50 - 6.00 - "Excellent"
 */

public class Grade
{
    public static void Main ()
    {
        double x = getInput();  //get input from keyboard
        printOutput(x);         //print output to console
    }

    public static double getInput()
    {
        double x = 0;
        do
        {
            Console.Write("Enter grade (2-6): ");
            x = Convert.ToDouble(Console.ReadLine());
        } while (x < 2.00 || x > 6.00);
        return x;
    }

    public static void printOutput (double x)
    {
        if (x >= 2.00 && x <= 2.99)
            Console.WriteLine("Fail");
        else if (x >= 3.00 && x <= 3.49)
            Console.WriteLine("Poor");
        else if (x >= 3.50 && x <= 4.49)
            Console.WriteLine("Good");
        else if (x >= 4.50 && x <= 5.49)
            Console.WriteLine("Very good");
        else
            Console.WriteLine("Excellent");
    }
}