using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(SignalRContect context) : base(context)
		{
		}

		public int ActiveCategoriyCount()
		{
			using var context = new SignalRContect();
			return context.Categories.Where(x => x.Status == true).Count();
		}

		public int CategorieCount()
		{
			using var context = new SignalRContect();
			return context.Categories.Count();
		}

		public int PasiveCategoriyCount()
		{
			using var context = new SignalRContect();
			return context.Categories.Where(x => x.Status == false).Count();

		}
	}
}
