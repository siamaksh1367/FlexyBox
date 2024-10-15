using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.SearchTag
{

    public class GetTagsResponseMappingProfile : Profile
    {
        public GetTagsResponseMappingProfile()
        {
            CreateMap<Tag, GetTagsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}