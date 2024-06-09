using AutoMapper;
using EcoTaxiAPI.Models;
using EcoTaxiAPI.DTO;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Anketa, AnketaDTO>();
        CreateMap<AnketaDTO, Anketa>();
    }
}
