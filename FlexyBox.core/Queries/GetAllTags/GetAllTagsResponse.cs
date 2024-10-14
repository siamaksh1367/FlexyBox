using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.SearchTag
{
    public class GetAllTagsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetAllTagsResponseMappingProfile : Profile
    {
        public GetAllTagsResponseMappingProfile()
        {
            CreateMap<Tag, GetAllTagsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}