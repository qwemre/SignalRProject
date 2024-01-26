using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfSliderDal : GenericRepository<Slider>, ISliderDal
	{
		public EfSliderDal(SignalRContect context) : base(context)
		{
		}
	}
}
