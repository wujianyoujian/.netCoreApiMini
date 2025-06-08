using System;
using _netCoreApiMini.Model;

namespace _netCoreApiMini.Repository;

public interface IUserRepository
{
    public Task<List<User>> Query();
}
