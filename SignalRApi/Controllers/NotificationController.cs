using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		private readonly INotifivationService _notifivationService;

		public NotificationController(INotifivationService notifivationService)
		{
			_notifivationService = notifivationService;
		}
		[HttpGet]
		public IActionResult NotificationList()
		{
			return Ok(_notifivationService.TGetListAll());

		}

		[HttpGet("NotificationCountByStatusFalse")]
		public IActionResult NotificationCountByStatusFalse()
		{
			return Ok(_notifivationService.TNotificationCountByStatusFalse());

		}

		[HttpGet("GetAllNotificationByFalse")]
		public IActionResult GetAllNotificationByFalse()
		{
			return Ok(_notifivationService.TGetAllNotificationByFalse());

		}
		[HttpPost]
		public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
		{
			Notification notification = new Notification()
			{
				Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				Description = createNotificationDto.Description,
				Icon = createNotificationDto.Icon,
				status = false,
				Type = createNotificationDto.Type,
			};

			_notifivationService.TAdd(notification);
			return Ok("Ekleme işlemi başarılı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteNotification(int id)
		{
			var value = _notifivationService.TGetByID(id);
			_notifivationService.TDelete(value);
			return Ok("Bildirim silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetNotification(int id)
		{
			var value = _notifivationService.TGetByID(id);
			return Ok(value);

		}

		[HttpPut]
		public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
		{
			Notification notification = new Notification()
			{
				NotificationID = updateNotificationDto.NotificationID,
				Date = updateNotificationDto.Date,
				Description = updateNotificationDto.Description,
				Icon = updateNotificationDto.Icon,
				status = updateNotificationDto.status,
				Type = updateNotificationDto.Type,
			};

			_notifivationService.TUpdate(notification);
			return Ok("Güncelleme işlemi başarılı");
		}
		[HttpGet("NotificationStatusChangeToFalse/{id}")]
		public IActionResult NotificationStatusChangeToFalse(int id)
		{
			_notifivationService.TNotificationStatusChangeToFalse(id);
			return Ok("Güncelleme yapıldı");
		}

		[HttpGet("NotificationStatusChangeToTrue/{id}")]
		public IActionResult NotificationStatusChangeToTrue(int id)
		{
			_notifivationService.TNotificationStatusChangeToTrue(id);
			return Ok("Güncelleme yapıldı");
		}

	}
}
