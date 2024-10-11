using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetCategories
{
    public class GetCategoriesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GetCategoriesResponse(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }



    public class GetCategoriesResponseMappingProfile : Profile
    {
        public GetCategoriesResponseMappingProfile()
        {
            CreateMap<Category, GetCategoriesResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
