using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        int TTotalOrderCount();
        int TActiceOrderCount();
        decimal TLastOrderPrice();
        decimal TTodayTotalPrice();
    }
}
