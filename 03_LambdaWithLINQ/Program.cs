﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LambdaWithLINQ
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = InitializeList();

            var orderedUsers = users.OrderBy(user => user.Age);

            Print(orderedUsers);

            var filteredUsers = users.Where(user => user.Name.Contains("a"));

            Print(filteredUsers);

        }

        private static List<User> InitializeList()
        {
            List<User> list = new List<User>(10)
            {
                new User { Name ="Alex", Age = 21 },
                new User { Name ="John", Age = 18 },
                new User { Name ="Sarah", Age = 35 },
                new User { Name ="Rick", Age = 28 },
                new User { Name ="Harry", Age = 24 },
                new User { Name ="Jack", Age = 23 },
                new User { Name ="Amanda", Age = 42 },
                new User { Name ="Sofi", Age = 19 },
                new User { Name ="Kate", Age = 22 },
                new User { Name ="George", Age = 25 }
            };
            return list;
        }

        private static void Print(IEnumerable<User> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}
