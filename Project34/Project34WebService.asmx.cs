using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Project34
{
    /// <summary>
    /// Summary description for Project34WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Project34WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string About()
        {
            string version = "1.0.0.0";
#if DEBUG
            string build = "DEBUG";
#else
            string build = "RELEASE";
#endif
            return $"{this.GetType().Name} {version} {build}";
        }

        [WebMethod]
        public string Greeting(string name)
        {
            return $"Hello, {name}!";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public string GreetUser(User user)
        {
            return $"Hello, {user.FirstName} {user.LastName} !";
        }

        [WebMethod]
        public User[] GetUsers()
        {
            return _users;
        }

        private User[] _users = new User[]
        {
            new User
            {   FirstName = "George",
                LastName = "Washington"
            },
            new User
            {   FirstName = "John",
                LastName = "Adams"
            },
            new User
            {   FirstName = "Thomas",
                LastName = "Jefferson"
            }
        };
    }
}
