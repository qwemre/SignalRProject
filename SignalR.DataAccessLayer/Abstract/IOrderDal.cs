using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IOrderDal : IGenericDal<Order>
	{
		int TotalOrderCount();
		int ActiceOrderCount();

		decimal LastOrderPrice();

		decimal TodayTotalPrice();
	}
}
