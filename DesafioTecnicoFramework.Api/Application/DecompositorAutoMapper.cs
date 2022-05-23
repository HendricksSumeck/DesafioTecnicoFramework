using AutoMapper;
using DesafioTecnicoFramework.Api.Domain;

namespace DesafioTecnicoFramework.Api.Application;

public class DecompositorAutoMapper : Profile
{
    public DecompositorAutoMapper()
    {
        CreateMap<Decompose, DecomposeView>();
    }
}