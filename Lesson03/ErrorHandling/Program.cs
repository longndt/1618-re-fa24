//validate both input range & format (type)

public class ErrorHandling
{
    public static double handleError()
    {
        double grade = 0;
        do
        {
            try
            {
                Console.Write("Enter grade (0-10): ");
                grade = double.Parse(Console.ReadLine());
                if (grade < 0 || grade > 10)
                {
                    Console.WriteLine("Wrong value. Input again.");
                }
            } catch (FormatException)
            {
                Console.WriteLine("Wrong format. Input again.");
            }
        } while (grade < 0 || grade > 10);
        return grade;
    }

    public static void Main()
    {
        double x = handleError();
        Console.WriteLine("Grade: " + x);
    }
}

