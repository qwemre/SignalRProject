using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;
		private readonly IMapper _mapper;

		public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
		{
			_testimonialService = testimonialService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult TestimoniallList()
		{
			var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
		{
			Testimonial testimonial = new Testimonial()
			{
				Comment = createTestimonialDto.Comment,
				ImageUrl = createTestimonialDto.ImageUrl,
				Name = createTestimonialDto.Name,
				Status = createTestimonialDto.Status,
				Title = createTestimonialDto.Title
			};
			_testimonialService.TAdd(testimonial);
			return Ok("referans eklendi");
		}
		[HttpDelete("{id}")]

		public IActionResult DeleteTestimonial(int id)
		{
			var value = _testimonialService.TGetByID(id);
			_testimonialService.TDelete(value);
			return Ok("Referans silindi");
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
		{
			Testimonial testimonial = new Testimonial()
			{
				Comment = updateTestimonialDto.Comment,
				ImageUrl = updateTestimonialDto.ImageUrl,
				Name = updateTestimonialDto.Name,
				Status = updateTestimonialDto.Status,
				Title = updateTestimonialDto.Title,
				TestimonialID = updateTestimonialDto.TestimonialID
			};
			_testimonialService.TUpdate(testimonial);
			return Ok("Referans güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var value = _testimonialService.TGetByID(id);
			return Ok(value);
		}
	}
}
