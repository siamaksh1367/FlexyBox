using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace FlexyBox.core.Commands.CreatePost
{
    public class CreatePostCommand : ICommand<CreatePostResponse>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<int> Tags { get; set; }
        public int CategoryId { get; set; }
        public IBrowserFile Image { get; set; }
        public CreatePostCommand(string title, string content, List<int> tags, int categoryId, IBrowserFile image)
        {
            Title = title;
            Content = content;
            Tags = tags;
            CategoryId = categoryId;
            Image = image;
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
