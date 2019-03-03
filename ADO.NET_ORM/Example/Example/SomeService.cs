using System;
using System.Linq;
using DAL.Context;

namespace Example
{
    public class SomeService
    {
        public void DoSmth()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();
                var customers = context.Customers.Include("Orders.OrderItems").ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Orders for customer {customer.Id} - {customer.Name}:");
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine($"Id: {order.Id}\nDate: {order.Date}\nItems:");
                        foreach (var orderItem in order.OrderItems)
                        {
                            var item = items.Single(i => i.Id == orderItem.ItemId);
                            Console.WriteLine($"\t{item.Id} - {item.Description} - ${item.Price}");
                        }
                    }
                }
            }
        }
    }
}