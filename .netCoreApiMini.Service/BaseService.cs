using System;
using _netCoreApiMini.IService;
using _netCoreApiMini.Repository;
using AutoMapper;

namespace _netCoreApiMini.Service;

public class BaseService<TEntity, TVo> : IBaseService<TEntity, TVo> where TEntity : class, new()
{

    private readonly IMapper _mapper;

    public BaseService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<List<TVo>> Query()
    {
        var baseRepo = new BaseRepository<TEntity>();
        var entities = await baseRepo.Query();
        return _mapper.Map<List<TVo>>(entities);
    }
}
