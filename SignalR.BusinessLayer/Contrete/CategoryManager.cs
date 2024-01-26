using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Contrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public int TActiveCategoriyCount()
		{
			return _categoryDal.ActiveCategoriyCount();
		}

		public void TAdd(Category entity)
		{
			_categoryDal.Add(entity);
		}

		public int TCategorieCount()
		{
			return _categoryDal.CategorieCount();
		}

		public void TDelete(Category entity)
		{
			_categoryDal.Delete(entity);
		}

		public Category TGetByID(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> TGetListAll()
		{
			return _categoryDal.GetListAll();
		}

		public int TPasiveCategoriyCount()
		{
			return _categoryDal.PasiveCategoriyCount();
		}

		public void TUpdate(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}
