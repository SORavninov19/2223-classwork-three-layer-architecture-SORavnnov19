using System;
using System.Collections.Generic;
using _2223_Classwork_Three_layer_architecture.Models;

namespace _2223_Classwork_Three_layer_architecture.DAL
{
    public class LoginDAL
    {
        public static List<Account> ExtractDataFromFile()
        {
            string[] fileText = System.IO.File.ReadAllLines("C:\\Users\\dyanakiev\\source\\repos\\2223-classwork-three-layer-architecture-dryanakiev\\2223-Classwork-Three-layer-architecture.DAL\\MOCK_DATA.txt");

            List<Account> accounts = new List<Account>();

             foreach (string line in fileText)
            {
                string[] values = line.Split(",");

                Account obj = new Account();

                obj.Id = int.Parse(values[0]);
                obj.Username = values[1];
                obj.Password = values[2];
                obj.FirstName = values[3];
                obj.LastName = values[4];
                obj.Email = values[5];

                accounts.Add(obj);
            }

             return accounts;
        }
        static void Main(string[] args)
        {

        }
    }
}
