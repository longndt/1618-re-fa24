//example 1
//declare a dictionary <key, value>
var capitals = new Dictionary<string, string>();
//set value for items in dictionary
capitals["Vietnam"] = "Hanoi";
capitals["Thailand"] = "Bangkok";
capitals["United States"] = "Washington";
//display items in dictionary
Console.WriteLine(capitals["Vietnam"]);

//example 2
var grades = new Dictionary<string, double>();
grades["Minh"] = 7.5;
grades["Hoa"] = 8.9;
grades["Tuan"] = 6.7;
foreach (var grade in grades)
{
    Console.WriteLine(grade);
}

//example 3
Dictionary<string, string> clubs = new Dictionary<string, string>()
{
    { "Manchester United", "England" },
    { "Real Madrid", "Spain" },
    { "Barcelona", "Spain" }
};  
foreach (KeyValuePair<string, string> club in clubs)
{
    Console.WriteLine(club.Key + " - " + club.Value);
}

//sorted dictionary
SortedDictionary<int, string> students = new SortedDictionary<int, string>()
{
    { 3, "Hai Anh" },
    { 1, "Tuan Minh" },
    { 2, "Phuong Linh" }
};
foreach (var student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("---------------");
//add both key + value
students.Add(5, "Duc Tuan");  
students.Add(4, "Ha Duong");
foreach (var student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("---------------");
//remove by key
students.Remove(3);
students.Remove(2);
foreach (var student in students)
{
    Console.WriteLine(student);
}