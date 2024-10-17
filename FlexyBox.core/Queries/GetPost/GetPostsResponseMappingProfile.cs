using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetPost
{
    public class GetPostsResponseMappingProfile : Profile
    {
        public GetPostsResponseMappingProfile()
        {
            CreateMap<Post, GetPostResponse>()
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.ContentKey.ToString()))
            .ForMember(dest => dest.CommentsCount, opt => opt.MapFrom(src => src.Comments.Count))
            .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(tag => tag.Name).ToList()))
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.Image, opt => opt.Ignore())
            .ForMember(dest => dest.UserName, opt => opt.Ignore());

        }
    }
}
