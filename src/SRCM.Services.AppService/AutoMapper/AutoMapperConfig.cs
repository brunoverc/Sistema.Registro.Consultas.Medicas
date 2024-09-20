using AutoMapper;

namespace SRCM.Services.AppService.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(stngs =>
            {
                stngs.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}
