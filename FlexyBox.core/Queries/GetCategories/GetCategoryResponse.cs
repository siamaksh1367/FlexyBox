using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetCategories
{
    public class GetCategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GetCategoryResponse(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }



    public class GetCategoryResponseMappingProfile : Profile
    {
        public GetCategoryResponseMappingProfile()
        {
            CreateMap<Category, GetCategoryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
