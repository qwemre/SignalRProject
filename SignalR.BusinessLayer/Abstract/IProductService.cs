using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();
        int TProductCountByCategoryNameHamburger();
        int TProductCountByCategoryNameDrink();
        decimal TProductPriceAwg();
        string TProductNameByPriceMax();
        string TProductNameByPriceMin();

        decimal TProductAvgPriceByHamburger();
    }
}
