//khai báo trước, gán giá trị sau
string vn;
vn = "Vietnam";

//khai báo và gán giá trị cùng lúc
string hn = "Hanoi";

//in giá trị của string
//nối string và biến, dùng dấu +
Console.WriteLine(hn + " is the capital of " + vn);

string country, capital;
Console.Write("Enter country: ");
country = Console.ReadLine();
Console.Write("Enter capital: ");
capital = Console.ReadLine();
Console.WriteLine(capital + " is the capital of " + country);