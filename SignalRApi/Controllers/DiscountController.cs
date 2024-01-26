using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiscountController : ControllerBase
	{
		private readonly IDiscountService _discountService;
		private readonly IMapper _mapper;

		public DiscountController(IDiscountService discountService, IMapper mapper)
		{
			_discountService = discountService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult DiscountList()
		{
			var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
		{
			Discount discount = new Discount()
			{
				Amount = createDiscountDto.Amount,
				Description = createDiscountDto.Description,
				ImageUrl = createDiscountDto.ImageUrl,
				Title = createDiscountDto.Title

			};
			_discountService.TAdd(discount);
			return Ok("İndirim Bilgisi Eklendi");
		}
		[HttpDelete("{id}")]

		public IActionResult DeleteDiscount(int id)
		{
			var value = _discountService.TGetByID(id);
			_discountService.TDelete(value);
			return Ok("İndirim Bilgisi Silindi");
		}
		[HttpPut]
		public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
		{
			Discount discount = new Discount()
			{
				Amount = updateDiscountDto.Amount,
				Description = updateDiscountDto.Description,
				ImageUrl = updateDiscountDto.ImageUrl,
				Title = updateDiscountDto.Title,
				DiscountID = updateDiscountDto.DiscountID
			};
			_discountService.TUpdate(discount);
			return Ok("İndirim Bilgisi Güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetDiscount(int id)
		{
			var value = _discountService.TGetByID(id);
			return Ok(value);
		}

	}
}
