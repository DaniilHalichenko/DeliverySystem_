using System;
using DeliverySystem;
using DeliverySystem_;


namespace DeliverySystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Delivery System ===");

            Order order = new Order(1000);
            PrintOrder(order);

            Console.WriteLine("\nApplying 15% discount...");
            order.ApplyDiscount(15);
            PrintOrder(order);

            Console.WriteLine("\nChanging status to Shipped...");
            order.ChangeStatus(OrderStatus.Shipped);
            PrintOrder(order);

            Console.WriteLine("\nChanging status to Delivered...");
            order.ChangeStatus(OrderStatus.Delivered);
            PrintOrder(order);

            Console.WriteLine("\nIs order delivered?");
            Console.WriteLine(order.IsDelivered() ? "Yes" : "No");
        }

        static void PrintOrder(Order order)
        {
            Console.WriteLine($"Price: {order.Price}");
            Console.WriteLine($"Status: {order.Status}");
        }
    }
}