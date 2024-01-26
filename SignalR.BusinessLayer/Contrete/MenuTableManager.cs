﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Contrete
{
	public class MenuTableManager : IMenuTableService
	{
		private readonly IMenuTableDal _menuTableDal;

		public MenuTableManager(IMenuTableDal menuTableDal)
		{
			_menuTableDal = menuTableDal;
		}

		public void TAdd(MenuTable entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(MenuTable entity)
		{
			throw new NotImplementedException();
		}

		public MenuTable TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<MenuTable> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public int TMenuTableCount()
		{
			return _menuTableDal.MenuTableCount();
		}

		public void TUpdate(MenuTable entity)
		{
			throw new NotImplementedException();
		}
	}
}
