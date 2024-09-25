public class Demo
{
    public static void Main()
    {
        welcome();
        hello("Tuan", 20);
        Console.WriteLine("Total : " + total());
        Console.WriteLine("Result : " + multiply(3, 6));
    }

    //1. hàm không có input (tham số - parameter) & output (giá trị trả về)
    public static void welcome()
    {
        Console.WriteLine("Welcome to Vietnam");
    }

    //2. hàm có input nhưng không có output
    public static void hello(string name, int age)
    {
        Console.WriteLine("Hello " + name + ". You are " + age + " year old");
    }

    //3. hàm không có input nhưng có output
    public static int total()
    {
        int a = 5;
        int b = 10;
        int c = a + b;
        return c;
    }

    //4. hàm vừa có input vừa có output
    public static int multiply (int x, int y)
    {
        return x * y;
    }
}