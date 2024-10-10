using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreateCategory
{
    public record CreateCategoryResponse(int Id, string Name, string Description);

    public class CreateCategoryResponseMappingProfile : Profile
    {
        public CreateCategoryResponseMappingProfile()
        {
            CreateMap<Category, CreateCategoryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

        }
    }
}
