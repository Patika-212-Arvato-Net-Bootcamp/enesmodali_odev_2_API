using Arvato_API_Project.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API_Project.Fake
{
    //Bootcamp'e katılacak kişileri random olarak aldım. (Bogus adında bir kütüphaneden.) Aldığım kişileri isim, soyisim ve adres bilgilerine göre id numarası baz alanırak sıraladım.
    public  static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int number) 
        {
            if(_users == null) 
            {
                _users = new Faker<User>()
               .RuleFor(u => u.Id, f => f.IndexFaker+1) //1 arttırma sebebim sıfırdan başlamasın.
               .RuleFor(u => u.FirstName, f => f.Name.FirstName())
               .RuleFor(u => u.LastName, f => f.Name.LastName())
               .RuleFor(u => u.Adress, f => f.Address.FullAddress())    
               .Generate(number);
            }
           

            return _users;
        }
    }
}
