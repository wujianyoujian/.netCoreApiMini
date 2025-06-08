using System;
using Newtonsoft.Json;

namespace _netCoreApiMini.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
{
    public async Task<List<TEntity>> Query()
    {
        var task1 = Task.Run(() =>
       {
           var data = "[{\"id\": \"12\", \"Name\": \"李四\"}]";
           var result = JsonConvert.DeserializeObject<List<TEntity>>(data);
           return result;
       });
        var response = await task1;
        return response ?? [];
    }
}
