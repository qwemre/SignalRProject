using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfAboutDal : GenericRepository<About>, IAboutDal
	{
		public EfAboutDal(SignalRContect context) : base(context)
		{
		}
	}
}
