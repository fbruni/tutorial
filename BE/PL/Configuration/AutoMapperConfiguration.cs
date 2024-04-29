using AutoMapper;
using BLL.Models;
using DAL.Entity;

namespace PL.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration() { 
            CreateMap<Book, BookModel>().ReverseMap();  
        }
    }
}
