using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyOneSourceAssessment
{
    class Program
    {
        static ShoppingCart cart1 = new ShoppingCart();
        static ShoppingCart cart2 = new ShoppingCart();
        static ShoppingCart cart3 = new ShoppingCart();

        static void Main(string[] args)
        {
            LoadCarts();

            Console.WriteLine("Your Receipt -- Each item's price contains tax:\n");

            CheckoutAndPrintReceipt(cart1);

            CheckoutAndPrintReceipt(cart2);

            CheckoutAndPrintReceipt(cart3);

            Console.ReadKey();
        }
        static void CheckoutAndPrintReceipt(ShoppingCart cart)
        {
            Receipt receipt = new Receipt(cart);
            receipt.Print();
            Console.WriteLine();
        }
        static void LoadCarts()
        {
            cart1.Items.Add(new Book { Name = "Book", Price = 12.49M });
            cart1.Items.Add(new EntertainmentItem { Name = "Music CD",  Price = 14.99M });
            cart1.Items.Add(new Candy { Name = "Chocolate Bar", Price = 0.85M });

            cart2.Items.Add(new FoodItem { Name = "Box of Chocolates", Imported = true, Price = 10.00M });
            cart2.Items.Add(new HygieneItem { Name = "Bottle of Perfume", Imported = true, Price = 47.50M });

            cart3.Items.Add(new HygieneItem { Name = "Bottle of Perfume", Imported = true, Price = 27.99M });
            cart3.Items.Add(new HygieneItem { Name = "Bottle of Perfume", Price = 18.99M });
            cart3.Items.Add(new MedicalItem { Name = "Packet of Headache Pills", Price = 9.75M });
            cart3.Items.Add(new Candy { Name = "Box of Chocolates", Imported = true, Price = 11.25M });
        }


    }
}
