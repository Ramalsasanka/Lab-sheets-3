using System;

public class Product
{
    
    private int productId;
    private string productName;
    private double price;
    private int quantityInStock;

    public Product(int productId, string productName, double price, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantityInStock = quantityInStock;
    }

   
    public void AddProduct(int quantity)
    {
        quantityInStock += quantity;
        Console.WriteLine($"{quantity} {productName}(s) added to inventory. New quantity in stock: {quantityInStock}");
    }

    
    public void BuyProduct(int quantity)
    {
        if (quantity > quantityInStock)
        {
            Console.WriteLine("Insufficient quantity in stock.");
            return;
        }

        quantityInStock -= quantity;
        Console.WriteLine($"{quantity} {productName}(s) bought. Remaining quantity in stock: {quantityInStock}");
    }

    
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Quantity in Stock: {quantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Product laptop = new Product(101, "Laptop", 800, 10);

        laptop.DisplayProductDetails();

        
    }
}