using AutoMapper;
using supermarket_api.Domain.Models;
using supermarket_api.Dtos;

namespace supermarket_api.Mapping
{
    public class ModelToDtoProfile : Profile
    {
        public ModelToDtoProfile()
        {
            // This creates a Map from Category entity to CategoryDto Transfer Object
            CreateMap<Category,CategoryDto>();
        }
    }
}