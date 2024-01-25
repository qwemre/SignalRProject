using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

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
	}
}
