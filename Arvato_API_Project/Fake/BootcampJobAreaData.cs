using Arvato_API_Project.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API_Project.Fake
{
    //Katılan kişilerin hangi meslek grubundan olduklarına dair çıktıyı verebilmek için , hazır kütüphaneden sadece job bilgilerini istedim.
    public static class BootcampJobAreaData
    {
        private static List<UsersJobArea> _usersjob;
        public static List<UsersJobArea> GetUsers(int number)
            //GetUsers metodunun parametre almasını istememin sebebi, kullanıcının istediği kadar gösterim yapılsın amacıyladır.
            //ÖR:GetUsers(25) dediğim vakit 25 kullanıcıyı ekrana getirecektir.
        {
            if (_usersjob == null)
            {
                _usersjob = new Faker<UsersJobArea>()
               .RuleFor(u => u.JobArea, f => f.Name.JobArea()) 
               .Generate(number);
            }


            return _usersjob;
        }
    }
}
