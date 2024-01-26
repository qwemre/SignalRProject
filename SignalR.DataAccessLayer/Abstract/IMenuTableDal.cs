using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IMenuTableDal : IGenericDal<MenuTable>
	{
		int MenuTableCount();
	}
}
