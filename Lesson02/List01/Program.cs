//declare and initialize list
List<int> numbers = new List<int>(); //dynamic size

//add elements to list
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

//display elements in list
Console.WriteLine("Initial list: " + String.Join(" - ", numbers));

//remove element from list
numbers.Remove(20);
numbers.Remove(40);

//display elements in list
Console.WriteLine("Current list: " + String.Join(" - ", numbers));