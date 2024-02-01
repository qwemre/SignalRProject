﻿using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);

        List<Discount> GetListByStatusTrue();

    }
}
