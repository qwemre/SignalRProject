using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntitiyLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = createCategoryDto.Status,
            };
            _categoryService.TAdd(category);
            return Ok("Kategori başarıyla eklenmiştir");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori başarıyla silinmiştir");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryID = updateCategoryDto.CategoryID,
                CategoryName = updateCategoryDto.CategoryName,
                Status = updateCategoryDto.Status,
            };
            _categoryService.TUpdate(category);
            return Ok("Kategori başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.TCategorieCount());
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_categoryService.TActiveCategoriyCount());
        }
        [HttpGet("PasiveCategoryCount")]
        public IActionResult PasiveCategoryCount()
        {
            return Ok(_categoryService.TPasiveCategoriyCount());
        }
    }
}
