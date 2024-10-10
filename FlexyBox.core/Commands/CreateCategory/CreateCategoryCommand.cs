using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreateCategory
{
    public record CreateCategoryCommand(string Name, string Description) : ICommand<CreateCategoryResponse>;

    public class CreateCategoryCommandMappingProfile : Profile
    {
        public CreateCategoryCommandMappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}