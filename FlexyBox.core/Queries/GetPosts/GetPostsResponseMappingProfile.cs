using AutoMapper;
using FlexyBox.core.Queries.GetPost;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetPosts
{
    public class GetPostsResponseMappingProfile : Profile
    {
        public GetPostsResponseMappingProfile()
        {
            CreateMap<Post, GetPostResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(tag => tag.Name).ToList()))
                .ForMember(dest => dest.CommentsCount, opt => opt.MapFrom(src => src.Comments.Count))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

        }
    }

}
