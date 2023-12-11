using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class UsersController : ApiController
    {
        // http://localhost:8080/api/users


        User[] users = new User[]
        {
            new User{ ID = new Guid() , FullName = "Arvin Mashayekhi", Age = 21},
            new User{ ID = new Guid() , FullName = "thomas edison", Age = 90},
        };
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

    }
}

public class User
{
    public Guid ID { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
}
