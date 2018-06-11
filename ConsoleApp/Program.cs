using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var result = orderService.CalculatePrice(price => price * 0.80);
            
            Console.WriteLine($"Discount Price:{result}");
        }
    }
}