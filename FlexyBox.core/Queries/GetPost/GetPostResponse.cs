using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetPost
{
    public class GetPostResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CommentsCount { get; set; }
        public Guid ContentKey { get; set; }
        public List<string> Tags { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }
        public string UserName { get; set; }
    }
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
