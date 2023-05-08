using System.Collections.Generic;
using T2207A;

public class Program
{
    public static void Main(String[] args)
    {
        int choice = 0;
        do
        {
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProducts();
                    break;
                case 3:
                    DeleteProduct();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);

    }
    static List<Product> products = new List<Product>();
    public static void AddProduct()
    {
        Console.Write("Enter product ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Product product = new Product { Id = id, Name = name, Price = price };
        products.Add(product);
        Console.WriteLine("Product added successfully");
    }
    public static void DisplayProducts()
    {
        Console.WriteLine("{0,-10} {1,-20} {2,-10}", "ID", "Name", "Price");
        foreach (Product product in products)
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10}", product.Id, product.Name,  product.Price);
        }
    }
    public static void DeleteProduct()
    {
        Console.Write("Enter product ID to delete: ");
        string id = Console.ReadLine();

        Product product = products.Find(p => p.Id == id);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted successfully");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}