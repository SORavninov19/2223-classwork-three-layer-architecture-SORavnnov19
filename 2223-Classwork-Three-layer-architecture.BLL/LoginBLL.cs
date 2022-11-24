using System;
using _2223_Classwork_Three_layer_architecture.DAL;
using _2223_Classwork_Three_layer_architecture.Models;

namespace _2223_Classwork_Three_layer_architecture.BLL
{
    public class Authentication
    {
        public static bool VerifyLogin(Account obj, string username, string password)
        {
            return (obj.Username == username && obj.Password == password);
        }
    }

    internal class LoginBLL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
