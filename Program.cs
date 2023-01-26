
using osenums.Entities;
using osenums.Entities.Enums;

Order order = new()
{
  Id =1080, 
  Moment = DateTime.Now, 
  Status = OrderStatus.PendingPayment
};

System.Console.WriteLine(order);

//Convert type enum to type String
string txt = OrderStatus.PendingPayment.ToString();
System.Console.WriteLine(txt);
//Convert type string to type Enum
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
System.Console.WriteLine(os);