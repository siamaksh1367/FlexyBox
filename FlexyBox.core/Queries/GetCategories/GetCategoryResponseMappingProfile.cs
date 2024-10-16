﻿using AutoMapper;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Queries.GetCategories
{
    public class GetCategoryResponseMappingProfile : Profile
    {
        public GetCategoryResponseMappingProfile()
        {
            CreateMap<Category, GetCategoryResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
