using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntitiyLayer.Entities;
namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		private readonly IMessageService _messageService;

		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}
		[HttpGet]
		public IActionResult MessageList()
		{
			var values = _messageService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			Message message = new Message()
			{
				NameSurname = createMessageDto.NameSurname,
				Subject = createMessageDto.Subject,
				Email = createMessageDto.Email,
				MessageContent = createMessageDto.MessageContent,
				MessageSendDate = DateTime.Now,
				Phone = createMessageDto.Phone,
				Status = false
				
			};
			_messageService.TAdd(message);
			return Ok("Mesaj başarılı bi şekilde gönderildi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			_messageService.TDelete(value);
			return Ok("Mesaj başarıyla silindi");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			Message message = new Message()
			{
				MessageID=updateMessageDto.MessageID,
				NameSurname = updateMessageDto.NameSurname,
				Subject = updateMessageDto.Subject,
				Email = updateMessageDto.Email,
				MessageContent = updateMessageDto.MessageContent,
				MessageSendDate = updateMessageDto.MessageSendDate,
				Phone = updateMessageDto.Phone,
				Status = updateMessageDto.Status
			};
			_messageService.TUpdate(message);
			return Ok("Mesaj  güncellendi");
		}

		[HttpGet("{id}")]
		public IActionResult GetMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			return Ok(value);

		}
	}
}
