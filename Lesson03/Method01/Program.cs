public class Method01
{
    //must declare as static
    static int a = 10;
    static int b = 20;

    private static void Add()
    {
        a += b; //a = a + b
    }

    //declare method 
    //default access modifier (scope) : public
    static void Hello()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("C# Method");
        Console.WriteLine("1618 - Programming");
        Console.WriteLine("Fall 2024 Semester");
    }

    public static void Main()
    {
        Console.WriteLine("Initial value of variable a = " + a);
        Add();
        Console.WriteLine("Current value of variable a = " + a);
        //call (invoke) method
        for (int i=1; i<=100; i++)
        {
            Hello();
        }
    }
}


