using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface ICategoryDal : IGenericDal<Category>
	{
		public int CategorieCount();
		public int ActiveCategoriyCount();
		public int PasiveCategoriyCount();
	}
}
