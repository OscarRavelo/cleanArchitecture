using Cebolla.Domain.Interfaces;
using Cebolla.Infraestructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cebolla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       

        private readonly IUserService _service;

        public UserController(IUserService service )
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public void   Post(User user)
        {
             _service.Create(user);
        }


    }
}
