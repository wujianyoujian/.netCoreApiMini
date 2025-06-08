using System;
using _netCoreApiMini.Model;

namespace _netCoreApiMini.IService;

public interface IUserService
{
    public Task<List<UserVo>> Query();

}
