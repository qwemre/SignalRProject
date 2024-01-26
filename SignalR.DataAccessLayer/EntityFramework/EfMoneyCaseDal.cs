using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
	{
		public EfMoneyCaseDal(SignalRContect context) : base(context)
		{
		}

		public decimal TotalMoneyCaseAmount()
		{
			using var context = new SignalRContect();
			return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
		}
	}
}
