﻿using Core.Users.App;
using Core.Users.App.DTO;
using Microsoft.AspNetCore.Mvc;

namespace equitron_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService service;

        public UsersController(UsersService service)
        {
            this.service = service;
        }

        [HttpGet("get-all")]
        public IEnumerable<UsersDTO> GetAll()
        {
            return service.GetUsers();
        }

        [HttpGet("get/{id}")]
        public UsersDTO GetUser(Guid id)
        {
            return service.GetUser(id);
        }

        [HttpPost("create-user")]
        public UsersDTO CreateUser(UsersDTO dto)
        {
            return service.CreateUser(dto);
        }
    }
}
