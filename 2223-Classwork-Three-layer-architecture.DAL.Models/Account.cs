using System;

namespace _2223_Classwork_Three_layer_architecture.Models
{
    public class Account
    {
        private string _username;
        private string _password;
        private string _email;
        private string _phone;

        public Account()
        {
            _username = "Not defined";
            _password = "Not defined";
            _email = "Not defined";
            _phone = "Not defined";
        }

        public Account(string username, string password, string email, string phone)
        {
            _username = username;
            _password = password;
            _email = email;
            _phone = phone;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
