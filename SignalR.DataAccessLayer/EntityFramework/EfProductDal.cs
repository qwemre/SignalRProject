﻿using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContect context) : base(context)
		{
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new SignalRContect();
			var values = context.Products.Include(x => x.Category).ToList();
			return values;
		}

		public int ProductCount()
		{
			using var context = new SignalRContect();
			return context.Products.Count();
		}

		public int ProductCountByCategoryNameDrink()
		{
			using var context = new SignalRContect();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new SignalRContect();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
		}

		public string ProductNameByPriceMax()
		{
			using var context = new SignalRContect();
			return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
		}

		public string ProductNameByPriceMin()
		{
			using var context = new SignalRContect();
			return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
		}

		public decimal ProductPriceAwg()
		{
			using var context = new SignalRContect();
			return context.Products.Average(x => x.Price);
		}

		public decimal ProductAvgPriceByHamburger()
		{
			using var context = new SignalRContect();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);

		}
	}
}
