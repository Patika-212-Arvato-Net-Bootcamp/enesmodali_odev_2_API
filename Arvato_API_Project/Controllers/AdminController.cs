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
    public class AdminController : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(25);

        //Kullanıcı id numarasına göre listeleme işlemini Admin 'api/admin/(idnumarası)' url giriş yaparak görebiliyor.
        // Ör: Postman üzerinden .../api/admin/5 yapıldığı vakit 5 id nolu kullanıcı geliyor.
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }
       
        //Admin postman üzerinden post metodunu kullanarak yeni kullanıcı ekleyebiliyor.
        [HttpPost]
        public User Post([FromBody]User user) 
        {
            _users.Add(user);
            return user;
        }
        //Admin postman üzerinden put metodunu kullanarak id numarası girişi yaparak istediği kullanıcının bilgilerini düzeneleyebiliyor.
        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editUser.FirstName = user.FirstName;
            editUser.LastName = user.LastName;
            editUser.Adress = user.Adress;
            
   
            return user;
        }

        //Admin postman üzerinden delete metodunu kullarak id numarasına göre istediği kullanıcıyı sileybiliyor.
        [HttpDelete("{id}")]
        public void Delete(int id)
            
        {
            var deletedUser = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deletedUser);

        }

    }
}
