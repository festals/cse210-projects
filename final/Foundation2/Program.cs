using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       
        Address addr1 = new Address("296 Cooper St.", "Orlando", "FL 32839", "USA");

        Customer cust1 = new Customer("Mariana Sanchez",addr1);

        Product prod1 = new Product("Moutwash", "54C12", 5.99f, 3);
        Product prod2 = new Product("Brush", "25JF", 7.59f, 2);
        Product prod3 = new Product("Towel", "35F8K", 2.25f, 1);

        List<Product> products1 = new List<Product>{prod1,prod2,prod3};

        Order ord1 = new Order(products1, cust1);

        // display the packing label, 
        // the shipping label,
        // and the total price of the order,
        Console.WriteLine(ord1.DisplayPackingLabel());
        Console.WriteLine(ord1.DisplayShippingLabel());
        ord1.DisplayTotalCost();


        Console.WriteLine();
        Console.WriteLine();

        Address addr2 = new Address("1 Princeton St.", "Port-Cartier", "QC G5B 9S0", "Canada");

        Customer cust2 = new Customer("Boris Flinch",addr2);

        Product prod4 = new Product("Toilett Paper", "5FG", 2.20f, 4);
        Product prod5 = new Product("Body Wash", "256T", 4.10f, 3);
        Product prod6 = new Product("Sunscreen", "54HJ5", 8.50f, 1);

        List<Product> products2 = new List<Product>{prod4,prod5,prod6};

        Order ord2 = new Order(products2, cust2);

        // display the packing label, 
        // the shipping label,
        // and the total price of the order,
        Console.WriteLine(ord2.DisplayPackingLabel());
        Console.WriteLine(ord2.DisplayShippingLabel());
        ord2.DisplayTotalCost();






       


    }
}