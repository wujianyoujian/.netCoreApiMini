using System;
using _netCoreApiMini.Model;
using AutoMapper;

namespace _netCoreApiMini.Extensions;

public class CustomProfile : Profile
{
    public CustomProfile()
    {
        CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, m => m.MapFrom(b => b.Name));
        CreateMap<RoleVo, Role>().ForMember(a => a.Name, m => m.MapFrom(b => b.RoleName));
    }
}
