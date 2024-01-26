using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetProductsWithCategories();
		int ProductCount();
		int ProductCountByCategoryNameHamburger();
		int ProductCountByCategoryNameDrink();
		decimal ProductPriceAwg();
		string ProductNameByPriceMax();
		string ProductNameByPriceMin();

		decimal ProductAvgPriceByHamburger();



	}
}
