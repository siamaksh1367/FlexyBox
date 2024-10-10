using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.UpdateCategory
{
    public record UpdateCategoryResponse(int Id, string Name, string Description);


    public class UpdateCategoryResponseMappingProfile : Profile
    {
        public UpdateCategoryResponseMappingProfile()
        {
            CreateMap<Category, UpdateCategoryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

        }
    }
}
