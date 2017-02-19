using ProductsShop.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductsShop.Models;

namespace ProductsShop.ConsoleClient
{
    public class Program
    {
        private const string usersPath = "../../../json/users.json";

        public static void Main()
        {
            var db = new ProductsShopContext();

            var n = db.Categories.Count();

            ImportUsers();
        }

        private static void ImportUsers()
        {
            var db = new ProductsShopContext();
            var json = File.ReadAllText(usersPath);
            var users = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);

            foreach (var user in users)
            {
                var firstName = user["firstName"];
                var lastName = user["lastName"];
                var age = user["age"];

                var userEntity = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = int.Parse(age)
                };

                db.Users.Add(userEntity);
                db.SaveChanges();
            }

        }
    }
}
