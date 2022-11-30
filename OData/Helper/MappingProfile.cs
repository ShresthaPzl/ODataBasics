using AutoMapper;
using AutoMapper.Features;
using OData.Data;
using OData.Models;

namespace OData.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateProjection<Country, CountryDTO>()
                .ForMember(dto => dto.Id, conf => conf.MapFrom(ol => ol.Id));
        } 
    }
}
