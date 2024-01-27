using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}
		[HttpGet]
		public IActionResult BookingList()
		{
			var values = _bookingService.TGetListAll();
			return Ok(values);

		}
		[HttpPost]

		public IActionResult CreateBooking(CreateBookingDto bookingDto)
		{
			Booking booking = new Booking()
			{

				Name = bookingDto.Name,
				Mail = bookingDto.Mail,
				PersonCount = bookingDto.PersonCount,
				Phone = bookingDto.Phone,
				Date = bookingDto.Date,
				Description = bookingDto.Description,

			};
			_bookingService.TAdd(booking);
			return Ok("Rezervasyon yapıldı");
		}
		[HttpDelete("{id}")]

		public IActionResult DeleteBooking(int id)
		{
			var value = _bookingService.TGetByID(id);
			_bookingService.TDelete(value);
			return Ok("Rezervasyon silindi");
		}
		[HttpPut]
		public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
		{
			Booking booking = new Booking()
			{
				BookingID = updateBookingDto.BookingID,
				Name = updateBookingDto.Name,
				Mail = updateBookingDto.Mail,
				PersonCount = updateBookingDto.PersonCount,
				Phone = updateBookingDto.Phone,
				Date = updateBookingDto.Date,
				Description = updateBookingDto.Description	
			};
			_bookingService.TUpdate(booking);
			return Ok("Rezervasyon güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var value = _bookingService.TGetByID(id);
			return Ok(value);
		}

		[HttpGet("BookingStatusApproved/{id}")]
		public IActionResult BookingStatusApproved(int id)
		{
			_bookingService.TBookingStatusApproved(id);
			return Ok("Rezervasyon açıklaması değiştirildi");
		}
		[HttpGet("BookingStatusCancelled/{id}")]
		public IActionResult BookingStatusCancelled(int id)
		{
			_bookingService.TBookingStatusCancelled(id);
			return Ok("Rezervasyon açıklaması değiştirildi");

		}
	}
}
