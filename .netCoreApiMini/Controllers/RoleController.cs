using _netCoreApiMini.IService;
using _netCoreApiMini.Model;
using _netCoreApiMini.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _netCoreApiMini.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IBaseService<Role, RoleVo> _roleService;

        public RoleController(IMapper mapper, IBaseService<Role, RoleVo> baseService)
        {
            _roleService = baseService;
        }

        [HttpGet("list")]
        public async Task<List<RoleVo>> QueryList()
        {
            return await _roleService.Query();
        }
    }
}
