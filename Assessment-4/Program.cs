using EcommerceDomain;
using EcommerceData;
using Microsoft.EntityFrameworkCore;

EcommerceDbContext context = new EcommerceDbContext();

using (EcommerceDbContext contextDb = new EcommerceDbContext) 
{
    //ensure db is created
    contextDb.Database.EnsureCreated();
}


var user = new User { Name = "john_doe", UserName = "john@example.com" };
var product1 = new Product { ProductId = 1, Name = "Product A", Price = 10 };
var product2 = new Product { ProductId = 2, Name = "Product B", Price = 15 };

var order = new Order
{
    OrderId = 1,
    User = user,
    Products = new List<Product> { product1, product2 },
    OrderDate = DateTime.Now
};

var shipment = new Shipment { ShipmentId = 1, Order = order, ShipmentDate = DateTime.Now.AddDays(1) };
var payment = new Payment { PaymentId = 1, Order = order, Amount = 26.48m, PaymentDate = DateTime.Now.AddHours(2) };

var cart = new Cart { CartId = 1, User = user, Products = new List<Product> { product1 } };

//Add users 
//void AddUsers() 
//{
//    context.Users.Add(
//       new User { Name="Arthur Waheire", UserName="Waheire"}
//        );
//    //context.SaveChanges();
//}

////Add products
//void AddProdcuts()
//{
//    context.Products.AddRange(
//       new Product { Name = "Dell laptop", Price = 400000 },
//        new Product { Name = "Dell Mouse", Price = 4000 },
//         new Product { Name = "Dell Monitor", Price = 30330 },
//          new Product { Name = "Dell Keyboard", Price = 1000 }

//        );
//    //context.SaveChanges();
//}
//Add orders
//void AddOrders()
//{
//    context.Orders.Add(
//       new Order { Name = "Oder 1" , User = User, Products = new List},
//        );
//    //context.SaveChanges();
//}
////add shipment
//void AddShipment()
//{
//    context.Shipments.AddRange(
//       new Shipment { Name = "Shipment 1" },
//       new Shipment { Name = "Shipment 2" },
//       new Shipment { Name = "Shipment 3" },
//       new Shipment { Name = "Shipment 4" }
//        );
//    //context.SaveChanges();
//}

////add payment
//void AddPayment()
//{
//    context.Payments.AddRange(
//       new Payment { Amount= 9038333, PaymentDate = DateTime.Now.AddHours(2) },
//       new Payment { Amount = 90334333, PaymentDate = DateTime.Now.AddHours(3) },
//        new Payment { Amount = 92112333, PaymentDate = DateTime.Now.AddHours(4) },
//        );
//    //context.SaveChanges();
//}
////add cart
//void AddCart()
//{
//    context.Payments.AddRange(
//       new Payment { Amount = 9038333, PaymentDate = DateTime.Now.AddHours(2) },
//       new Payment { Amount = 90334333, PaymentDate = DateTime.Now.AddHours(3) },
//        new Payment { Amount = 92112333, PaymentDate = DateTime.Now.AddHours(4) },
//        );
//    //context.SaveChanges();
//}
