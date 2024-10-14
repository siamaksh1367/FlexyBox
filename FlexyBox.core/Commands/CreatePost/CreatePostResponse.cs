using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreatePost
{
    public class CreatePostResponse
    {
        public DateTime LastEdited { get; internal set; }
        public string Title { get; internal set; }
        public IEnumerable<string> Tags { get; internal set; }
        public string CategoryName { get; internal set; }
        public int Id { get; internal set; }
        public string Content { get; internal set; }
    }

    public class CreatePostResponseMappingProfile : Profile
    {
        public CreatePostResponseMappingProfile()
        {
            CreateMap<Post, CreatePostResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.LastEdited, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(x => x.Name)));

        }
    }
}
