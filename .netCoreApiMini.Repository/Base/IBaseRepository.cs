using System;

namespace _netCoreApiMini.Repository;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> Query();
}
