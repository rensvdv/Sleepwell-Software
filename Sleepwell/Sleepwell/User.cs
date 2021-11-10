using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepwell
{
   public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }

        public int Age { get; set; }

        public User(int id, string name, string email, int age )
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Age = age;
        }
    }
}
