using Encapsulation;

Mobile iphone = new Mobile("Apple", "iPhone 16", 2000);
Mobile samsung = new Mobile("Samsung", "Galaxy S24", 1500);

Console.WriteLine("Mobile 1");
Console.WriteLine(iphone.getModel());
Console.WriteLine(iphone.displayPrice());
Console.WriteLine("Discount price 50%");
iphone.setPrice(1000);
Console.WriteLine("New price: " + iphone.displayPrice());
iphone.showDetail();
Console.WriteLine("Mobile 2");
samsung.showDetail();
