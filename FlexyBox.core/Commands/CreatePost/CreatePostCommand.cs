using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreatePost
{
    public record CreatePostCommand(string Title, byte[] Content, List<string> Tags, int CategoryId) : ICommand<CreatePostResponse>;
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
