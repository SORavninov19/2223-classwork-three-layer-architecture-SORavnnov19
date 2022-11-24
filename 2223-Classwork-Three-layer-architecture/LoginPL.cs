using System;
using _2223_Classwork_Three_layer_architecture.BLL;
using _2223_Classwork_Three_layer_architecture.Models;

namespace _2223_Classwork_Three_layer_architecture.PL
{
    internal class LoginPL
    {
        static void Main(string[] args)
        {
            string _username;
            string _password;

            Account accountOne = new Account();
            accountOne.Username = "admin";
            accountOne.Password = "admin";

            Console.Write("Please enter your username: ");
            _username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            _password = Console.ReadLine();

            if(Authentication.VerifyLogin(accountOne, _username, _password))
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
    }
}
