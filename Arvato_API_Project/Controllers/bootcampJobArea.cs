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
    //GetUsers metodu ile istediğim sayıda kullanıcı girişi yapabiliyorum. 
    //Bootcamp'e katılacak olan kullanıcıların sadece meslek bilgilerini görmek istiyorum
    //UsersJobArea modelinden oluşturduğum _usersjob ile bu işlemi yapıyorum
    public class bootcampJobArea : ControllerBase
    {
        private List<UsersJobArea> _usersjob = BootcampJobAreaData.GetUsers(25);

        [HttpGet]
        public List<UsersJobArea> Get()
        {
            return _usersjob;
        }
    }
}
