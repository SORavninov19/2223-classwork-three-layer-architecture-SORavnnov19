using System;

namespace _2223_Classwork_Three_layer_architecture.Models
{
    public class Account
    {
        private int _id;
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _email;

        public Account()
        {
            this._id = 0;
            this._username = "Undefined";
            this._password = "Undefined";
            this._firstName = "Undefined";
            this._lastName = "Undefined";
            this._email = "Undefined";
        }

        public Account(int id, string username, string password, string firstName, string lastName, string email)
        {
            this._id = id;
            this._username = username;
            this._password = password;
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        static void Main(string[] args)
        {

        }
    }
    
}
