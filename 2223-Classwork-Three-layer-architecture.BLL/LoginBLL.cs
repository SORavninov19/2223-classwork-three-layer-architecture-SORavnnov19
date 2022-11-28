using System;
using System.Collections.Generic;
using _2223_Classwork_Three_layer_architecture.DAL;
using _2223_Classwork_Three_layer_architecture.Models;

namespace _2223_Classwork_Three_layer_architecture.BLL
{
    public class Authentication
    {
        public static bool VerifyLogin(string username, string password)
        {
            List<Account> accounts = LoginDAL.ExtractDataFromFile();

            foreach (var obj in accounts)
            {
                if (obj.Username == username && obj.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {

        }
    }
}
