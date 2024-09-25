//declare list 
List<string> products = new List<string>();

//get total (size) list
Console.Write("Enter total product: ");
int total = Convert.ToInt32(Console.ReadLine());

//get list items
for (int i=0; i<total; i++)
{
    Console.Write("Enter name of product " + (i + 1) + ": ");
    products.Add(Console.ReadLine());
}

//sort list item
products.Sort();

//display list items
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine((i + 1) + ". "  + products[i]);
}
