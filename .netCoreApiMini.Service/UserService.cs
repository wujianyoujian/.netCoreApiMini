using _netCoreApiMini.IService;
using _netCoreApiMini.Model;
using _netCoreApiMini.Repository;

namespace _netCoreApiMini.Service;

public class UserService : IUserService
{
    public async Task<List<UserVo>> Query()
    {
        var userRepo = new UserRepository();
        var users = await userRepo.Query();
        return [.. users.Select(user => new UserVo() { UserName = user.Name })];
    }
}
