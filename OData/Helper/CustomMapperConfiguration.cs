using AutoMapper;

namespace OData.Helper
{
    public static class CustomMapperConfiguration
    {
        public static IMapper GetMapperConfiguration()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            return mapperConfig.CreateMapper();
        }

    }

}
