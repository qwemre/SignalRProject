using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SignalRContect context) : base(context)
		{
		}
	}
}
