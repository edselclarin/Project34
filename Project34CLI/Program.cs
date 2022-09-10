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
            var client = new Project34WebServiceSoapClient("Project34WebServiceSoap");

            Console.WriteLine("--- About() ---");
            string rsp = client.About();
            Console.WriteLine(rsp);
            Console.WriteLine();

            Console.WriteLine("--- Greeting() ---");
            rsp = client.Greeting("Mr Smith");
            Console.WriteLine(rsp);
            Console.WriteLine();

            int a = 4; 
            int b = 6;
            int c = client.Add(a, b);
            Console.WriteLine("--- Add() ---");
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine();

            Console.WriteLine("--- GreetUser() ---");
            rsp = client.GreetUser(new User
            {
                FirstName = "Johnny",
                LastName = "Carson"
            });
            Console.WriteLine(rsp);
            Console.WriteLine();

            Console.WriteLine("--- GetUsers() ---");
            var users = client.GetUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.FirstName} {user.LastName}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
