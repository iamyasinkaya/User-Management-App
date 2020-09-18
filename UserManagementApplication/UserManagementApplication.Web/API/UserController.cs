using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementApplication.Application.Interfaces;
using UserManagementApplication.Application.Models;

namespace UserManagementApplication.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
            var entity = await _userService.GetAll();

            return entity.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(UserModel model)
        {
            var entiy = await _userService.GetByIdAsync(model);
            if (entiy == null)
            {
                return NotFound();
            }

            return entiy;
        }
    }
}
