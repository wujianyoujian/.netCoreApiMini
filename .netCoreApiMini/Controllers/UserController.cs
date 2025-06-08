using _netCoreApiMini.Model;
using _netCoreApiMini.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _netCoreApiMini.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("list")]
        public async Task<List<UserVo>> Query()
        {
            var userService = new UserService();
            return await userService.Query();
        }
    }
}
