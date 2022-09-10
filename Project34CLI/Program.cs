using Project34CLI.Factories;
using System;

namespace Project34CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = WebServiceClientFactory.CreateClient();

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
            var user = WebServiceModelFactory.CreateUser();
            user.FirstName = "Johnny";
            user.LastName = "Carson";
            rsp = client.GreetUser(user);
            Console.WriteLine(rsp);
            Console.WriteLine();

            Console.WriteLine("--- GetUsers() ---");
            var users = client.GetUsers();
            foreach (var usr in users)
            {
                Console.WriteLine($"User: {usr.FirstName} {usr.LastName}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
