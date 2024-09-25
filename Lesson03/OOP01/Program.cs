using OOP01;

//khởi tạo object cho class bằng constructor
Product mobile = new Product();
Product laptop = new Product("Macbook Pro 16", 1999.99, "Silver", 25, 2023);

//gọi hàm từ OOP class
mobile.setName("iPhone 16 Pro Max");
mobile.setPrice(1234.56);
Console.WriteLine("Mobile name: " + mobile.getName());
Console.WriteLine("Mobile price: $" + mobile.displayPrice());
Console.WriteLine("----------------------------");
laptop.displayProductDetail();