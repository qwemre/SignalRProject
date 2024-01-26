using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(SignalRContect context) : base(context)
		{
		}

		public int ActiceOrderCount()
		{
			using var context = new SignalRContect();
			return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
		}

		public decimal LastOrderPrice()
		{
			using var context = new SignalRContect();
			return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();

		}

		public decimal TodayTotalPrice()
		{
			return 0;
		}

		public int TotalOrderCount()
		{
			using var context = new SignalRContect();
			return context.Orders.Count();
		}
	}
}
