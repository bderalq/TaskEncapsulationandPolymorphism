
using ConsoleApp8;

Product product = new Product();

List<Product> products = new List<Product>();

Console.WriteLine("How many products do you want to enter ? ");
int count = Convert.ToInt32(Console.ReadLine());

string name;
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

        product.SetQuantity(quantity, name, price, total);
        product.AddProducts(name, quantity, price, total);

}
product.GetProducts();
