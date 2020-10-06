using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TestApi.data;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {
        private readonly IApiUserServices _apiUser;


        public Users(IApiUserServices apiUser)
        {
            _apiUser = apiUser;
        }
        [HttpGet]
        [Route("")]
        public IActionResult AllUser()
        {
            return _apiUser.AllUser();
        }
        [HttpGet]
        [Route("Find")]
        public IActionResult FindUserByName(string name)
        {
           return  _apiUser.FindUserByName(name);
        }

        [HttpPost]
        [Route("Set")]
        public IActionResult SetUser(string name, int age)
        {
            return _apiUser.SetNewUser(name, age);
        }
      

    }
}
