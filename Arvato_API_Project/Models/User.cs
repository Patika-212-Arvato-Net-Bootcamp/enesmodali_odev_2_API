using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API_Project.Models
{
    //Kullanıcı modelimi aşağıdaki özelliklere göre oluşturdum.
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

       
    }
}
