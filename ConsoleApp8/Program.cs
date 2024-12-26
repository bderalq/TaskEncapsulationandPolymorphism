
using ConsoleApp8;

Product product = new Product();

Console.WriteLine("How many products do you want to enter ? ");
int count = Convert.ToInt32(Console.ReadLine());

string name;
bool stock;
double price, quantity, total;
for (int i = 1; i <= count; i++)
{ 
    Console.WriteLine("Enter Product Name ");
    name = Console.ReadLine();

    Console.WriteLine("Enter Product Price = ");
    price = Convert.ToDouble((Console.ReadLine()));

    Console.WriteLine("Enter Quantity = ");
    quantity = Convert.ToDouble((Console.ReadLine()));

    total = price * quantity;

    Console.WriteLine("Is the product in stock or out of stock (true / false)");
    stock = Convert.ToBoolean((Console.ReadLine()));

    product.AddProducts(name, quantity, price, total, stock);
}

product.GetProducts();
Console.WriteLine($"Total items entered = " + count);
product.GetStock();

