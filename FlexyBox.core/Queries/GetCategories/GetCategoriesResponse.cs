﻿using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetCategories
{
    public record GetCategoriesResponse(int Id, string Name, string Description);


    public class GetCategoriesResponseMappingProfile : Profile
    {
        public GetCategoriesResponseMappingProfile()
        {
            CreateMap<Category, GetCategoriesResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
