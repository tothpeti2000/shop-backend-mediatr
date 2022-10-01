using Application.Features.Category;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, GetAllCategoriesResponse.CategoryDto>();
            CreateMap<Category, GetTopCategoriesResponse.TopCategory>();
        }
    }
}
