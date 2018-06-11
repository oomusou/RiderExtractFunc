using System;

namespace ConsoleApp
{
    public class OrderService
    {
        public double CalculatePrice(Func<double, double> discountStrategy)
        {
            var price = 1000.0;
            return discountStrategy(price);
        }
    }
}