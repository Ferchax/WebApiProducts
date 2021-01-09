using System;
using System.Collections.Generic;
using System.Linq;
using ProductsQR.Models;

namespace ProductsQR.Repositories
{
    public class UserRepository
    {
        readonly IEnumerable<User> users;

        private int id;

        public UserRepository()
        {
            id = 1;

            users = new List<User>
            {
                new User
                {
                   Id = id++,
                   Name = "Loren",
                   LastName = "Riley",
                   Legajo = "1198",
                   Password = "kN7eT5nF",
                   Email = "loren.riley@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Guillermo",
                   LastName = "Greene",
                   Legajo = "1911",
                   Password = "oJ1tX1kR",
                   Email = "guillermo.greene@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Elmer",
                   LastName = "Santiago",
                   Legajo = "1906",
                   Password = "xD0kD8vI",
                   Email = "elmer.santiago@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Tyrone",
                   LastName = "Pierce",
                   Legajo = "3921",
                   Password = "pS5sD5yB",
                   Email = "tyrone.pierce@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Joyce",
                   LastName = "Kelly",
                   Legajo = "2780",
                   Password = "hK3kI7nS",
                   Email = "joyce.kelly@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Kimberly",
                   LastName = "Patton",
                   Legajo = "3531",
                   Password = "mL2fZ3dO",
                   Email = "kimberly.patton@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Robyn",
                   LastName = "Roy",
                   Legajo = "1771",
                   Password = "zE1qK8rT",
                   Email = "robyn.roy@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Ted",
                   LastName = "Wilkerson",
                   Legajo = "4833",
                   Password = "qG6rU8vJ",
                   Email = "ted.wilkerson@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Norma",
                   LastName = "Mccarthy",
                   Legajo = "3011",
                   Password = "tC1sZ8sG",
                   Email = "norma.mccarthy@refres.com.ar"
                },
                new User
                {
                   Id = id++,
                   Name = "Allen",
                   LastName = "Ortega",
                   Legajo = "4853",
                   Password = "lZ9tK8pJ",
                   Email = "allen.ortega@refres.com.ar"
                }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUserByLegajo(string legajo)
        {
            var user = users.Where(x => x.Legajo == legajo).FirstOrDefault();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            var user = users.Where(x => x.Email == email).FirstOrDefault();
            return user;
        }

        public User GetUserById(int id)
        {
            var user = users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }
    }
}
