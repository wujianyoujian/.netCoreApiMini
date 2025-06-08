using _netCoreApiMini.Model;
using Newtonsoft.Json;

namespace _netCoreApiMini.Repository;

public class UserRepository : IUserRepository
{
    public async Task<List<User>> Query()
    {
        var task1 = Task.Run(() =>
        {
            var data = "[{\"Name\": \"李四\"}]";
            var result = JsonConvert.DeserializeObject<List<User>>(data);
            return result;
        });
        var response = await task1;
        return response ?? [];
    }
}
