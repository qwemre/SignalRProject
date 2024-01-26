﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntitiyLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasketController : ControllerBase
	{
		private readonly IBasketService _basketService;

		public BasketController(IBasketService basketService)
		{
			_basketService = basketService;
		}
		[HttpGet]
		public IActionResult GetBasketByMenuTableID(int id)
		{
			var values = _basketService.TGetBasketByMenuTableNumber(id);
			return Ok(values);
		}
		[HttpGet("BasketListByMenuTableWithProductName")]
		public IActionResult BasketListByMenuTableWithProductName(int id)
		{
			using var context = new SignalRContect();
			var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProducts
			{
				BasketID = z.BasketID,
				Count = z.Count,
				MenuTableID = z.MenuTableID,
				Price = z.Price,
				TotalPrice = z.TotalPrice,
				ProductName = z.Product.ProductName

			}).ToList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateBasket(CreateBasketDto createBasketDto)
		{
			using var contex = new SignalRContect();
			_basketService.TAdd(new Basket()
			{
				ProductID = createBasketDto.ProductID,
				Count = 1,
				MenuTableID = 4,
				Price = contex.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
				TotalPrice = 0,


			});
			return Ok();

		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBasket(int id)
		{
			var value = _basketService.TGetByID(id);
			_basketService.TDelete(value);
			return Ok("Spetteki Seçilen Ürün başarıyla Silindi");
		}
	}
}
