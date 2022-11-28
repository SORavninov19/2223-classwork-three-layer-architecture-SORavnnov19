using System;
using _2223_Classwork_Three_layer_architecture.BLL;

namespace _2223_Classwork_Three_layer_architecture.PL
{
    internal class LoginPL
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.Write("Please enter your username: ");
            username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();

            if(Authentication.VerifyLogin(username, password))
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
