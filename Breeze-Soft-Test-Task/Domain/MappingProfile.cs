using AutoMapper;

namespace Breeze_Soft_Test_Task.Domain;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Data.Car, Car>().ReverseMap();
        CreateMap<DateTime, DateOnly>().ReverseMap();
    }
}
