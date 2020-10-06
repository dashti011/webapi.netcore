using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi.data;
using TestApi.Services;

namespace TestApi.Services
{
    public class ApiUserServices: IApiUserServices
    {
        private readonly DbCont _dbCont;

        public ApiUserServices(DbCont dbCont)
        {
            _dbCont = dbCont;
        }

        public IActionResult AllUser()
        {
            var findanyuser = _dbCont.Users.AsNoTracking().ToList();
            return new OkObjectResult(findanyuser);
        }

        /// <summary>
        /// جستجو کاربر بر حسب نام
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IActionResult FindUserByName(string name)
        {
            if(string.IsNullOrWhiteSpace(name)) return new BadRequestResult();

            var find=_dbCont.Users.AsNoTracking().FirstOrDefault(m => m.Name == name);
            if (find != null)
            {
                return new OkObjectResult(find);
            }
            else
            {
                return new NotFoundResult();

            }
        }
        /// <summary>
        /// ایجاد کاربر بر اساس پارامتر ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public IActionResult SetNewUser(string name, int age)
        {
            if(string.IsNullOrWhiteSpace(name)||age<0) return new BadRequestResult();

            var newuser=new UserModelDb{Age = age,Name = name};
            _dbCont.Users.Add(newuser);
            _dbCont.SaveChanges();
            return new OkObjectResult(newuser);
        }
    }

   
}
