using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4
{
    internal class UserAuth
    {
        List<User> userList = new List<User>
        {
            new User { Username = "Juan", Password = "0000", Role = "User" },
            new User { Username = "Maria", Password = "1111", Role = "User" },
            new User { Username = "Admin", Password = "admin", Role = "Admin" }, 

            // Añadir más usuarios aqui
        };

        public User? Auth(string username, string password)
        {
            // compara y retorna true si el usuario existe.
            return userList?.FirstOrDefault(user => user.Username == username && user.Password == password); 
        }

    }
}
