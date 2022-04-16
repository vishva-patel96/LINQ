using System.Linq;

List<Customer> customers = new List<Customer>()
            {
                new Customer(){ID = Guid.NewGuid(), Age = 23, First = "Joe", Last = "Smith"},
                new Customer(){ID = Guid.NewGuid(), Age = 34, First = "Kevin", Last = "Costner"},
                new Customer(){ID = Guid.NewGuid(), Age = 23, First = "Sally", Last = "Smuthers"},
                new Customer(){ID = Guid.NewGuid(), Age = 56, First = "Mary", Last = "Jane"},
                new Customer(){ID = Guid.NewGuid(), Age = 48, First = "Jane", Last = "Kendall"},
                new Customer(){ID = Guid.NewGuid(), Age = 34, First = "Eve", Last = "Shrimp"},
                new Customer(){ID = Guid.NewGuid(), Age = 31, First = "Donna", Last = "Lynn"},
                new Customer(){ID = Guid.NewGuid(), Age = 21, First = "Sarah", Last = "Spicer"},
            };

List<Order> orders = new List<Order>()
            {
                new Order() {CustomerID = customers[0].ID, Description="Shoes", Price=150.23M, Quantity=1},
                new Order() {CustomerID = customers[0].ID, Description="Phone", Price=130.25M, Quantity=2},
                new Order() {CustomerID = customers[0].ID, Description="Jacket", Price=230.14M, Quantity=1},

                new Order() {CustomerID = customers[1].ID, Description="Phone", Price=130.25M, Quantity=1},
                new Order() {CustomerID = customers[1].ID, Description="Jacket", Price=230.14M, Quantity=2},
                new Order() {CustomerID = customers[1].ID, Description="Pants", Price=70.56M, Quantity=1},

                new Order() {CustomerID = customers[2].ID, Description="Jacket", Price=230.14M, Quantity=1},
                new Order() {CustomerID = customers[2].ID, Description="Pants", Price=70.56M, Quantity=3},
                new Order() {CustomerID = customers[2].ID, Description="Shirt", Price=49.99M, Quantity=1},

                new Order() {CustomerID = customers[3].ID, Description="Pants", Price=70.56M, Quantity=1},
                new Order() {CustomerID = customers[3].ID, Description="Shirt", Price=49.99M, Quantity=2},
                new Order() {CustomerID = customers[3].ID, Description="Scarf", Price=23.69M, Quantity=1},

                new Order() {CustomerID = customers[4].ID, Description="Shirt", Price=49.99M, Quantity=3},
                new Order() {CustomerID = customers[4].ID, Description="Scarf", Price=23.69M, Quantity=1},
                new Order() {CustomerID = customers[4].ID, Description="Car", Price=24200.15M, Quantity=1},

                new Order() {CustomerID = customers[5].ID, Description="Scarf", Price=23.69M, Quantity=2},
                new Order() {CustomerID = customers[5].ID, Description="Car", Price=24200.15M, Quantity=1},
                new Order() {CustomerID = customers[5].ID, Description="Computer", Price=650.00M, Quantity=1},

                new Order() {CustomerID = customers[6].ID, Description="Car", Price=24200.15M, Quantity=1},
                new Order() {CustomerID = customers[6].ID, Description="Computer", Price=650.00M, Quantity=1},
                new Order() {CustomerID = customers[6].ID, Description="Shoes", Price=150.23M, Quantity=1},

                new Order() {CustomerID = customers[7].ID, Description="Computer", Price=650.00M, Quantity=1},
                new Order() {CustomerID = customers[7].ID, Description="Jacket", Price=230.14M, Quantity=1},
                new Order() {CustomerID = customers[7].ID, Description="Pants", Price=70.56M, Quantity=1},

            };

 //Query 1
foreach(var customer in customers.OrderBy(c =>c.Last))
{
    Console.WriteLine(customer.First + " " + customer.Last);
    foreach(var order in orders.OrderByDescending(p => p.Price))
    {

        Console.WriteLine(order.Price + " "+order.Description +" "+ order.Quantity);
    }
    orders.Count();
    Console.WriteLine($"Total orders {orders.Count}");
}



