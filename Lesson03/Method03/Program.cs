public class SignOfInteger
{
    public static void Main ()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        PrintSign(x);
        Console.WriteLine(PrintResult(x));
    }

    public static void PrintSign(int n)
    {
        if (n > 0)
            Console.WriteLine(n + " is positive");
        else if (n < 0)
            Console.WriteLine(n + " is negative");
        else  //n = 0
            Console.WriteLine(n + " is zero");
    }

    public static string PrintResult(int n)
    {
        string result;
        if (n > 0)
            result = n + " là số nguyên dương";
        else if (n < 0)
            result = n + " là số nguyên âm";
        else
            result = n + " is số zero";
        return result;
    }
}