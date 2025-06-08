using System;

namespace _netCoreApiMini.IService;

public interface IBaseService<TEntity, TVo> where TEntity : class
{
    Task<List<TVo>> Query();
}
