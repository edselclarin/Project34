using Project34CLI.Project34WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project34CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Project34WebServiceSoapClient();

            string rsp = client.HelloWorld();
            Console.WriteLine(rsp);

            rsp = client.Greeting("Mr Smith");
            Console.WriteLine(rsp);

            int a = 4; 
            int b = 6;
            int c = client.Add(a, b);
            Console.WriteLine($"{a} + {b} = {c}");

            rsp = client.GreetUser(new User
            {
                FirstName = "Johnny",
                LastName = "Carson"
            });
            Console.WriteLine(rsp);

            var users = client.GetUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.FirstName} {user.LastName}");
            }

            Console.ReadLine();
        }
    }
}
