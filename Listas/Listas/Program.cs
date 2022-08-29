using Projeto.Entities;
using Projeto.Entities.Enums;

Order order = new Order {
    id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order.Status);
order.id = 10;
Console.WriteLine(order.id);