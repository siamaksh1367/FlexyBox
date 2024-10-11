using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreatePost
{
    public class CreatePostCommand : ICommand<CreatePostResponse>
    {
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public List<string> Tags { get; set; }
        public int CategoryId { get; set; }
        public CreatePostCommand(string title, byte[] content, List<string> tags, int categoryId)
        {
            Title = title;
            Content = content;
            Tags = tags;
            CategoryId = categoryId;
        }
    }
    public class CreatePostCommandMappingProfile : Profile
    {
        public CreatePostCommandMappingProfile()
        {
            CreateMap<CreatePostCommand, Post>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.ContentKey, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.LastEdited, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Tags, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore());
        }
    }
}
