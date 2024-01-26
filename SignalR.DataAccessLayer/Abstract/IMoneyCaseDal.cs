using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IMoneyCaseDal : IGenericDal<MoneyCase>
	{
		decimal TotalMoneyCaseAmount();

	}
}
