using Arvato_API_Project.Fake;
using Arvato_API_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Arvato_API_Project.Controllers
{
    [Route("api/[controller]")]
    public class bootcampList : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(25);
        //Bootcamp'e katılan kullanıcıları görebilmek için Get metodunu çağırarak işlemimi gerçekleştiriyorum.

        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
    }
}
