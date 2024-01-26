using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
	public interface IMenuTableService : IGenericService<MenuTable>
	{
		int TMenuTableCount();
	}
}
