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
        private readonly IMapper _mapper;


        public RoleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("list")]
        public async Task<List<RoleVo>> QueryList()
        {
            var roleService = new BaseService<Role, RoleVo>(_mapper);
            return await roleService.Query();
        }
    }
}
