using System;
using _netCoreApiMini.IService;
using _netCoreApiMini.Repository;
using AutoMapper;

namespace _netCoreApiMini.Service;

public class BaseService<TEntity, TVo> : IBaseService<TEntity, TVo> where TEntity : class, new()
{

    private readonly IMapper _mapper;
    private readonly IBaseRepository<TEntity> _baseRepository;

    public BaseService(IMapper mapper, IBaseRepository<TEntity> baseRepository)
    {
        _mapper = mapper;
        _baseRepository = baseRepository;
    }

    public async Task<List<TVo>> Query()
    {
        var entities = await _baseRepository.Query();
        return _mapper.Map<List<TVo>>(entities);
    }
}
