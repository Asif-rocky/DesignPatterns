using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;
        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder(string orderDetails)
        {
            // Logic to place the order
            Console.WriteLine($"Order placed: {orderDetails}");

            // Notify the user about the order
            _notificationService.SendNotification($"Your order has been placed: {orderDetails}");
        }
    }
}
