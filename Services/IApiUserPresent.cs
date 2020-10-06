using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.data;

namespace TestApi.Services
{
    public interface IApiUserServices
    {
        IActionResult AllUser();
        IActionResult FindUserByName(string name);

        IActionResult SetNewUser(string name, int age);
       
    }
}
