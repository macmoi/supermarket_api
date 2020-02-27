using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using supermarket_api.Domain.Services;
using supermarket_api.Domain.Models;
using supermarket_api.Dtos;
using AutoMapper;

namespace supermarket_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<IEnumerable<CategoryDto>> Get()
        {
            IEnumerable<Category> categories = await _categoryService.ListAsync();
            var mCategories =_mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
            return mCategories;
        }
    }
}