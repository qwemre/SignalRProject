using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
	public interface IMoneyCaseService : IGenericService<MoneyCase>
	{
		decimal TTotalMoneyCaseAmount();

	}
}
