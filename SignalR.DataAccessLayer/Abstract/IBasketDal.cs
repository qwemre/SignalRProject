using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IBasketDal : IGenericDal<Basket>
	{
		List<Basket> GetBasketByMenuTableNumber(int id);
	}
}
