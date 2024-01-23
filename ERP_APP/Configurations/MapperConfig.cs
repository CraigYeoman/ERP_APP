using AutoMapper;
using ERP_APP.Data;
using ERP_APP.Models;

namespace ERP_APP.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Labor, LaborCreateVM>().ReverseMap();
            CreateMap<LaborCategory, LaborCategoryVM>().ReverseMap();
        }
    }
}
