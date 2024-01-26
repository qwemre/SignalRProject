using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public int TCategorieCount();
        public int TActiveCategoriyCount();
        public int TPasiveCategoriyCount();
    }
}
