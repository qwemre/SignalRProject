﻿using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
	public interface IBasketService : IGenericService<Basket>
	{
		List<Basket> TGetBasketByMenuTableNumber(int id);

	}
}
