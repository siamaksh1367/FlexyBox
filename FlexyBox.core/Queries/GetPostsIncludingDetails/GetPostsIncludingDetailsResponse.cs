using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetPostsIncludingDetails
{
    public class GetPostsIncludingDetailsResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int CommentsCount { get; set; }
        public List<string> Tags { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }
        public string UserName { get; set; }
    }


    public class GetPostsIncludingDetailsResponseMappingProfiel : Profile
    {
        public GetPostsIncludingDetailsResponseMappingProfiel()
        {
            CreateMap<Post, GetPostsIncludingDetailsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(tag => tag.Name).ToList()))
                .ForMember(dest => dest.CommentsCount, opt => opt.MapFrom(src => src.Comments.Count))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

        }
    }

}
