using OOP02;

Product product1 = new Product
{
    Name = "Ipad Pro 11",
    Price = 1111.11
};

Product product2 = new Product
{
    Name = "Apple Watch",
    Price = 345.6
};

Console.WriteLine("PRODUCT 1");
Console.WriteLine("Name: " + product1.Name);
Console.WriteLine("Price: $" + product1.Price);


Console.WriteLine("PRODUCT 2");
Console.WriteLine("Name: " + product2.Name);
Console.WriteLine("Price: $" + product2.Price);