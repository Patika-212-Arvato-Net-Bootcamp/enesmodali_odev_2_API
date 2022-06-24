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
    public class bootcampJoin:ControllerBase
    {
        //Bootcamp'e katılmak isteyen kullanıcılar post metodu ile User metod özellikleri girişi yaparak katılım sağlayabiliyor.
        //User modelinden oluşturduğum _users Listesine ekleme aşağıdaki gibi gerçekleşiyor.
        
        private List<User> _users = FakeData.GetUsers(25);
        [HttpPost]
        public User Post([FromBody] User user)
        {
            _users.Add(user);
            return user;
        }
    }
}
