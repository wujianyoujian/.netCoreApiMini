using System;
using AutoMapper;

namespace _netCoreApiMini.Extensions;

public class AutoMapperConfig
{
    public static MapperConfiguration RegisterMappings()
    {
        return new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new CustomProfile());
        });
    }
}
